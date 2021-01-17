using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Kuaidi100.SDK
{
    public sealed partial class Kuaidi100Client : IDisposable
    {
        private static string _baseUrl;
        internal HttpClient _httpClient;

        public Kuaidi100Client()
        {
            _baseUrl = "https://m.kuaidi100.com";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Host", "www.kuaidi100.com");
            _httpClient.DefaultRequestHeaders.Add("Origin", "https://m.kuaidi100.com");
            _httpClient.DefaultRequestHeaders.Add("Referer", "https://m.kuaidi100.com/");
            _httpClient.DefaultRequestHeaders.Connection.Add("keep-alive");
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.141 Safari/537.36");
        }

        internal async Task<T> GetAsync<T>(string url, Dictionary<string, string> parameters = null)
        {
            string query = "";
            if (parameters != null && parameters.Count > 0)
            {
                query = "?" + string.Join("&", parameters.Select(p => p.Key + "=" + WebUtility.UrlEncode(p.Value)));
                url += query;
            }
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(result);
        }

        internal async Task<T> PostAsync<T>(string url, Dictionary<string, string> parameters = null, object postData = null)
        {
            string query = "";
            if (parameters != null && parameters.Count > 0)
            {
                query = "?" + string.Join("&", parameters.Select(p => p.Key + "=" + WebUtility.UrlEncode(p.Value)));
                url += query;
            }
            string json = JsonConvert.SerializeObject(postData);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, httpContent);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(result);
        }

        public void Dispose()
        {
            _httpClient.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
