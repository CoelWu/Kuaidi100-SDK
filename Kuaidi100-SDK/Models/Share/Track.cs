using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kuaidi100.SDK.Models.Share
{
    public class Track
    {
        /// <summary>
        /// 时间，原始格式
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; set; }

        /// <summary>
        /// 格式化后的时间
        /// </summary>
        [JsonProperty("ftime")]
        public string FormatTime { get; set; }

        /// <summary>
        /// 追踪内容
        /// </summary>
        [JsonProperty("context")]
        public string Context { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }
}
