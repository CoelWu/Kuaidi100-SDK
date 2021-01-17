using Kuaidi100.SDK.Models.Share;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kuaidi100.SDK.Models.Response
{
    public class QueryResponse
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
        /// 快递单明细状态标记
        /// </summary>
        [JsonProperty("condition")]
        public string Condition { get; set; }

        /// <summary>
        /// 快递状态
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// 快递是否签收标记
        /// </summary>
        [JsonProperty("ischeck")]
        public string IsCheck { get; set; }

        /// <summary>
        /// 快递公司代码
        /// </summary>
        [JsonProperty("com")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [JsonProperty("nu")]
        public string PostId { get; set; }

        /// <summary>
        /// 快递跟踪进度
        /// </summary>
        [JsonProperty("data")]
        public List<Track> Data { get; set; }
    }
}
