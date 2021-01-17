using System;
using System.Collections.Generic;
using System.Text;

namespace Kuaidi100.SDK
{
    public sealed partial class Kuaidi100Client
    {
        /// <summary>
        /// 查询快递公司
        /// </summary>
        private string API_AUTO_COM_NUMBER
        {
            get => _baseUrl + "/apicenter/kdquerytools.do";
        }

        /// <summary>
        /// 查询快递状态
        /// </summary>
        private string API_QUERY
        {
            get => _baseUrl + "/query";
        }

        /// <summary>
        /// 快递公司图标
        /// </summary>
        private string API_ICON
        {
            get => _picUrl + "/images/all/56/";
        }
    }
}
