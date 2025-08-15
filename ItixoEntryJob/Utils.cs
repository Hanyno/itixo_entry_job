using Newtonsoft.Json;
using System.Xml;

namespace ItixoEntryJob
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
    }
}
