using ItixoEntryJob;
using ItixoEntryJob.Db;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

public class Worker : IHostedService
{
    private readonly AppSettings _appSettings;
    private readonly AppDbContext _dbContext;
    private Timer? _timer;

    public Worker(IOptions<AppSettings> appSettings, AppDbContext dbContext)
    {
        _appSettings = appSettings.Value;
        _dbContext = dbContext;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _timer = new Timer(DoWorkAsync, null, TimeSpan.Zero, TimeSpan.FromHours(1));
        return Task.CompletedTask;
    }

    private async void DoWorkAsync(object? state)
    {
        var wario = new Wario
        {
            DownloadedAt = DateTime.Now
        };
        try
        {
            wario.JsonData = await Utils.DownloadXmlAsJson(_appSettings.XmlUrl);
            wario.Status = Status.OK;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Chyba při stahování dat: {ex.Message}");
            wario.Status = Status.Offline;
            wario.JsonData = null;
        }

        try
        {
            _dbContext.Warios.Add(wario);
            await _dbContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Chyba při ukládání do databáze: {ex.Message}");
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _timer?.Change(Timeout.Infinite, 0);
        return Task.CompletedTask;
    }
    public void Dispose()
    {
        _timer?.Dispose();
    }
}