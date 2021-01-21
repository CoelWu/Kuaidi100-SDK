using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kuaidi100.SDK.Models.Share
{
    public class CompanyStatus
    {
        /// <summary>
        /// 快递公司代码
        /// </summary>
        [JsonProperty("companyCode")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// 第一公斤价格
        /// </summary>
        [JsonProperty("firstPrice")]
        public string FirstPrice { get; set; }

        /// <summary>
        /// 超过一公斤每斤价格
        /// </summary>
        [JsonProperty("overPrice")]
        public string OverPrice { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("firstWeight")]
        public string FirstWeight { get; set; }

        [JsonProperty("avgTime")]
        public string AverageTime { get; set; }

        /// <summary>
        /// 总价格
        /// </summary>
        [JsonProperty("totalPrice")]
        public string TotalPrice { get; set; }

        /// <summary>
        /// 快递公司图标
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 快递公司名称
        /// </summary>
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("leastTime")]
        public string LeastTime { get; set; }

        [JsonProperty("leastPrice")]
        public string LeastPrice { get; set; }

        [JsonProperty("marketCount")]
        public string MarketCount { get; set; }

        /// <summary>
        /// 排行分数
        /// </summary>
        [JsonProperty("rankScore")]
        public string RankScore { get; set; }
    }
}
