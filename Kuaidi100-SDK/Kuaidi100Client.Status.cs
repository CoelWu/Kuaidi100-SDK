using Kuaidi100.SDK.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kuaidi100.SDK
{
    public sealed partial class Kuaidi100Client
    {
        public async Task<AutoComNumberResponse> AutoCompanyNumber(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("请求参数无效");
            }

            var dict = new Dictionary<string, string>();
            dict.Add("method", "autoComNum");
            dict.Add("text", id);

            var obj = new
            {
                token = "",
                platform = "MWWW"
            };

            var result = await PostAsync<AutoComNumberResponse>(API_AUTO_COM_NUMBER, dict, obj);
            return result;
        }

        public async Task<QueryResponse> QueryStatus(string type, string postid, string phone = "")
        {
            if (type == "shunfeng")
            {
                if (string.IsNullOrEmpty(phone) || phone.Length != 4)
                {
                    throw new ArgumentException("手机号参数不正确");
                }
            }

            var dict = new Dictionary<string, string>();
            dict.Add("type", type);
            dict.Add("id", "1");
            dict.Add("valicode", "");
            dict.Add("postid", postid);
            dict.Add("temp", new Random().NextDouble().ToString());
            dict.Add("phone", phone);
            dict.Add("token", "");
            dict.Add("platform", "MWWW");

            var result = await PostAsync<QueryResponse>(API_QUERY, dict);
            return result;
        }
    }
}
