using Kuaidi100.SDK.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kuaidi100.SDK
{
    public sealed partial class Kuaidi100Client
    {
        public async Task<PriceAndTimeResponse> QueryPriceAndTime(string start, string end, string weight, string time)
        {
            var dict = new Dictionary<string, string>();
            dict.Add("method", "priceandtimenew");

            var obj = new
            {
                startPlace = start,
                endPlace = end,
                weight = weight,
                startTime = time,
                token = "",
                latitude = "",
                platform = "MWWW"
            };

            var result = await PostAsync<PriceAndTimeResponse>(API_PRICE, dict, obj);
            return result;
        }
    }
}
