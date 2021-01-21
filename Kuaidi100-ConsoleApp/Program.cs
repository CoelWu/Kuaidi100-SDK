using System;
using System.Threading.Tasks;
using Kuaidi100.SDK;
using Kuaidi100.SDK.Enums;

namespace Kuaidi100.ConsoleApp
{
    class Program
    {
        static Kuaidi100Client _client;
        static void Main(string[] args)
        {
            _client = new Kuaidi100Client();
            Task.Run(async () =>
            {
                await Query();
            }).GetAwaiter().GetResult();
        }

        static async Task Query()
        {
            Console.Write("请输入快递单号：");
            string id = Console.ReadLine();
            string phone = "";
            try
            {
                Console.WriteLine("正在获取快递信息...");
                var autoComNumberResponse = await _client.AutoCompanyNumber(id);
                Console.WriteLine($"快递公司名称: {autoComNumberResponse.Data[0].CompanyName}");
                if (autoComNumberResponse.Data[0].CompanyCode == "shunfeng")
                {
                    Console.Write("请输入收件人手机号后四位：");
                    phone = Console.ReadLine();
                }
                var postStatusResponse = await _client.QueryPostStatus(autoComNumberResponse.Data[0].CompanyCode, id, phone);
                switch (postStatusResponse.State)
                {
                    case StateType.Collected:
                        Console.WriteLine("快递状态: 已揽收");
                        break;
                    case StateType.Delivering:
                        Console.WriteLine("快递状态: 派送中");
                        break;
                    case StateType.Signed:
                        Console.WriteLine("快递状态: 已签收");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("快递追踪如下:");
                foreach (var data in postStatusResponse.Data)
                {
                    Console.WriteLine($"{data.FormatTime} {data.Context}");
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
