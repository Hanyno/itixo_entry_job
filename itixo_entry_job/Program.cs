using itixo_entry_job.Db;
using itixo_entry_job.Dto;
using Newtonsoft.Json;
using System.Reflection;
using System.Xml;

namespace itixo_entry_job
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            string xmlUrl = "https://pastebin.com/raw/PMQueqDV";

            while (true)
            {
                string jsonString = await Utils.DownloadXmlAsJson(xmlUrl);

                RootObject? root = JsonConvert.DeserializeObject<RootObject>(jsonString);
                await Utils.ProcessAndSaveData(root);

                await Task.Delay(3600000);
            }
        }
    }
}
