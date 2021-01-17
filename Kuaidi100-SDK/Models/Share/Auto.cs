using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kuaidi100.SDK.Models.Share
{
    public class Auto
    {
        /// <summary>
        /// 快递公司代码
        /// </summary>
        [JsonProperty("comCode")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// 快递公司名称
        /// </summary>
        [JsonProperty("name")]
        public string CompanyName { get; set; }

        [JsonProperty("lengthPre")]
        public string LengthPre { get; set; }

        [JsonProperty("noCount")]
        public string NoCount { get; set; }
    }
}
