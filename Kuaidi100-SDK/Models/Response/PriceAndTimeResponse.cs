using Kuaidi100.SDK.Models.Share;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kuaidi100.SDK.Models.Response
{
    public class PriceAndTimeResponse
    {
        /// <summary>
        /// HTTP返回的数据状态说明
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// HTTP返回的数据状态码（非HTTP状态码）
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 每家快递公司运费等数据
        /// </summary>
        [JsonProperty("data")]
        public List<CompanyStatus> Data { get; set; }
    }
}
