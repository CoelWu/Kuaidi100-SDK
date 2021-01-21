using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Kuaidi100.SDK.Enums
{
    public enum StateType
    {
        /// <summary>
        /// 在途
        /// </summary>
        [EnumMember(Value = "0")]
        Transiting,

        /// <summary>
        /// 揽收
        /// </summary>
        [EnumMember(Value = "1")]
        Collected,

        /// <summary>
        /// 疑难
        /// </summary>
        [EnumMember(Value = "2")]
        Difficulty,

        /// <summary>
        /// 签收
        /// </summary>
        [EnumMember(Value = "3")]
        Signed,

        /// <summary>
        /// 退签
        /// </summary>
        [EnumMember(Value = "4")]
        BackSigned,

        /// <summary>
        /// 派件
        /// </summary>
        [EnumMember(Value = "5")]
        Delivering,

        /// <summary>
        /// 退回
        /// </summary>
        [EnumMember(Value = "6")]
        Returning,

        /// <summary>
        /// 转单
        /// </summary>
        [EnumMember(Value = "7")]
        Transfered,

        /// <summary>
        /// 待清关
        /// </summary>
        [EnumMember(Value = "10")]
        PendingClearance,

        /// <summary>
        /// 清关中
        /// </summary>
        [EnumMember(Value = "11")]
        DuringClearance,

        /// <summary>
        /// 已清关
        /// </summary>
        [EnumMember(Value = "12")]
        Cleared,

        /// <summary>
        /// 清关异常
        /// </summary>
        [EnumMember(Value = "13")]
        ClearanceError,

        /// <summary>
        /// 收件人拒签
        /// </summary>
        [EnumMember(Value = "14")]
        Rejected

    }
}
