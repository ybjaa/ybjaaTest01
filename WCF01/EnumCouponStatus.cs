using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WCF01
{

    [DataContract]
    /// <summary>
    /// 优惠券操作状态枚举
    /// </summary>
    public enum EnumCouponStatus
    {

        /// <summary>
        /// 操作已完成
        /// </summary>
        [EnumMember]
        OK,

        /// <summary>
        /// 操作失败，业务逻辑不允许进行操作或其它错误
        /// </summary>
        [EnumMember]
        Failure,

        /// <summary>
        /// 未查找的请求的项，仅用于查询
        /// </summary>
        [EnumMember]
        NotFound,

        /// <summary>
        /// 请求参数中存在不符合定义的项
        /// </summary>
        [EnumMember]
        ArgumentsIncorrect


    }
}