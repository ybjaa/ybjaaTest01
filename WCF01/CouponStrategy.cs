using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WCF01
{
    /// <summary>
    /// 优惠券定义
    /// </summary>
    [DataContract]
    public class CouponStrategy
    {


        /// <summary>
        /// 策略编号
        /// </summary>
        [DataMember]
        public int ID { get; set; }      


        /// <summary>
        /// 策略关联定义的编号
        /// </summary>
        [DataMember]
        public int DefinitionID { get; set; }

        
        /// <summary>
        /// 生效时的金额
        /// </summary>
        [DataMember]
        public decimal Amount { get; set; }


        /// <summary>
        /// 生效所需的最小金额
        /// </summary>
        [DataMember]
        public decimal MinValue { get; set; }


        /// <summary>
        /// 生效所需的最大金额，为0时表示无穷大
        /// </summary>
        [DataMember]
        public decimal MaxValue { get; set; }


    }

}