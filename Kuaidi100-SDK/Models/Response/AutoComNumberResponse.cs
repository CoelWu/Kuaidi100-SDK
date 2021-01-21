using Kuaidi100.SDK.Models.Share;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kuaidi100.SDK.Models.Response
{
    public class AutoComNumberResponse
    {
        [JsonProperty("comCode")]
        public string CompanyCode { get; set; }

        [JsonProperty("num")]
        public string Num { get; set; }

        /// <summary>
        /// 真正的数据
        /// </summary>
        [JsonProperty("auto")]
        public List<AutoCompany> Data { get; set; }
    }
}
