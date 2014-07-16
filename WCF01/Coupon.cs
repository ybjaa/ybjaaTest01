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
    public class Coupon
    {
        
        /// <summary>
        /// 编号
        /// </summary>
        [DataMember]
        public int ID { get; set; }       //	编号

        /// <summary>
        /// 名称
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// 描述（HTML富文本）
        /// </summary>
        [DataMember]
        public string Description { get; set; }


        /// <summary>
        /// 描述（纯文本）
        /// </summary>
        [DataMember]
        public string DescriptionPlained { get; set; }


        /// <summary>
        /// 图片Uri（相对于根地址）
        /// </summary>
        [DataMember]
        public string PictureUrl { get; set; }

        /// <summary>
        /// 缩略图Uri（相对于根地址）
        /// </summary>
        [DataMember]
        public string PictureMiniUrl { get; set; }


        /// <summary>
        /// 被派发给会员的时间
        /// </summary>
        [DataMember]
        public DateTime TimeDrawed { get; set; }

        
        /// <summary>
        /// 有效期的起始时间
        /// </summary>
        [DataMember]
        public DateTime DateTimeBegin { get; set; }

        
        /// <summary>
        /// 有效期的截止时间
        /// </summary>
        [DataMember]
        public DateTime DateTimeExpired { get; set; }


        /// <summary>
        /// 支付时的金额计算策略
        /// </summary>
        [DataMember]
        public CouponStrategy[] Strategies { get; set; }


        /// <summary>
        /// 使用后关联的订单流水号，未使用时值为""
        /// </summary>
        [DataMember]
        public string SerialNo { get; set; }

       
        /// <summary>
        /// 使用后的折抵金额，未使用时值为0
        /// </summary>
        [DataMember]
        public decimal Amount { get; set; }

        /// <summary>
        /// 使用时的时间，未使用时值为?
        /// </summary>
        [DataMember]
        public DateTime? TimeUsed { get; set; }




        /// <summary>
        /// 优惠券当前状态，值为枚举字符串常量
        /// </summary>
        [DataMember]
        public EnumCouponState State { get; set; }


        /// <summary>
        /// 优惠券是否已删除
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }	

        /// <summary>
        /// 实例化此优惠券的定义编号
        /// </summary>
        [DataMember]
        public int DefinitionID { get; set; }

        /// <summary>
        /// 持有会员的编号
        /// </summary>
        [DataMember]
        public int MemberID { get; set; }

        /// <summary>
        /// 持有会员的名字
        /// </summary>
        [DataMember]
        public string MemberName { get; set; }

        /// <summary>
        /// 持有会员的手机号码
        /// </summary>
        [DataMember]
        public string MemberMPhone { get; set; }

        /// <summary>
        /// 发放商户的编号
        /// </summary>
        [DataMember]
        public int MerchantID { get; set; }

        /// <summary>
        /// 发放商户的名称
        /// </summary>
        [DataMember]
        public string MerchantName { get; set; }




        /// <summary>
        /// 优惠券当前状态，值为枚举字符串常量
        /// </summary>
        public enum EnumCouponState
        {

            	
            /// <summary>
            /// 正常，可使用
            /// </summary>
            Available,

            /// <summary>
            /// 未进入有效期
            /// </summary>
            Inactive,

            /// <summary>
            /// 已过期
            /// </summary>
            Expired,


            /// <summary>
            /// 已使用
            /// </summary>
            Used


        }










    }

}