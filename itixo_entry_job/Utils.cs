using itixo_entry_job.Db;
using itixo_entry_job.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace itixo_entry_job
{
    public class Utils
    {
        public static async Task<string> DownloadXmlAsJson(string url)
        {
            using HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(url);

            string xmlContent = await response.Content.ReadAsStringAsync();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlContent);

            string jsonString = JsonConvert.SerializeXmlNode(xmlDoc, Newtonsoft.Json.Formatting.Indented);

            return jsonString;
        }

        public static async Task ProcessAndSaveData(RootObject? root)
        {
            Wario newWario = new Wario();
            newWario.DownloadedAt = DateTime.Now;

            if (!string.IsNullOrEmpty(root?.Wario?.SerialNumber))
            {
                newWario.Status = Status.OK;

                var warioDto = root.Wario;
                newWario.SerialNumber = warioDto.SerialNumber;
                newWario.Model = warioDto.Model;
                newWario.Firmware = warioDto.Firmware;
                newWario.Degree = warioDto.Degree;
                newWario.Pressure = warioDto.Pressure;
                newWario.R = warioDto.R;
                newWario.Bip = warioDto.Bip;
                newWario.Language = warioDto.Language;
                newWario.PressureType = warioDto.PressureType;
                newWario.Runtime = warioDto.Runtime;
                newWario.Freemem = warioDto.Freemem;

                if (warioDto.Variable != null)
                {
                    newWario.Variable = new Variable
                    {
                        Sunrise = warioDto.Variable.Sunrise,
                        Sunset = warioDto.Variable.Sunset,
                        Civstart = warioDto.Variable.Civstart,
                        Civend = warioDto.Variable.Civend,
                        Nautstart = warioDto.Variable.Nautstart,
                        Nautend = warioDto.Variable.Nautend,
                        Astrostart = warioDto.Variable.Astrostart,
                        Astroend = warioDto.Variable.Astroend,
                        Daylen = warioDto.Variable.Daylen,
                        Civlen = warioDto.Variable.Civlen,
                        Nautlen = warioDto.Variable.Nautlen,
                        Astrolen = warioDto.Variable.Astrolen,
                        Moonphase = warioDto.Variable.Moonphase,
                        Isday = warioDto.Variable.Isday,
                        Bio = warioDto.Variable.Bio,
                        PressureOld = warioDto.Variable.PressureOld,
                        TemperatureAvg = warioDto.Variable.TemperatureAvg,
                        Agl = warioDto.Variable.Agl,
                        Fog = warioDto.Variable.Fog,
                        Lsp = warioDto.Variable.Lsp
                    };
                }

                if (warioDto.Input?.Sensors != null)
                {
                    foreach (var sensor in warioDto.Input.Sensors)
                    {
                        var minMaxData = warioDto.MinMax?.Sensors?.FirstOrDefault(m => m.Id == sensor.Id);
                        newWario.Sensors.Add(new SensorData
                        {
                            SensorId = sensor.Id,
                            Name = sensor.Name,
                            Type = sensor.Type,
                            Place = sensor.Place,
                            Value = sensor.Value,
                            Min = minMaxData?.Min,
                            Max = minMaxData?.Max,
                            GroupType = "input"
                        });
                    }
                }

                if (warioDto.Output?.Sensors != null)
                {
                    foreach (var sensor in warioDto.Output.Sensors)
                    {
                        newWario.Sensors.Add(new SensorData
                        {
                            SensorId = sensor.Id,
                            Name = sensor.Name,
                            Type = sensor.Type,
                            Place = sensor.Place,
                            Value = sensor.Value,
                            GroupType = "output"
                        });
                    }
                }
            }
            else
            {
                newWario.Status = Status.Offline;
                newWario.SerialNumber = "N/A";
            }

            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
                db.Warios.Add(newWario);
                await db.SaveChangesAsync();

                Console.WriteLine($"Data byla uložena do SQLite databáze. Stav: {newWario.Status}");
            }
        }
    }
}
