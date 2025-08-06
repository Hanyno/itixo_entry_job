using Newtonsoft.Json;
using System.Xml;

namespace itixo_entry_job
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // test URL for XML content
            string test_url = "https://pastebin.com/raw/PMQueqDV";

            using HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(test_url);

            string xmlContent = await response.Content.ReadAsStringAsync();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlContent);

            string jsonString = JsonConvert.SerializeXmlNode(xmlDoc, Newtonsoft.Json.Formatting.Indented);

            Console.WriteLine(jsonString);
        }
    }
}
