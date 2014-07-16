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
    public class CouponDefinition
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
        /// 起始生效时间
        /// </summary>
        [DataMember]
        public DateTime TimeValidate { get; set; }

        /// <summary>
        /// 有效天数
        /// </summary>
        [DataMember]
        public int DaysValid { get; set; }

        /// <summary>
        /// 定义创建时间
        /// </summary>
        [DataMember]
        public DateTime TimeCreated { get; set; }

        /// <summary>
        /// 支付时的金额计算策略
        /// </summary>
        [DataMember]
        public CouponStrategy[] Strategies { get; set; }

        /// <summary>
        /// 优惠券定义的当前状态，值为枚举字符串常量
        /// </summary>
        [DataMember]
        public EnumCouponDefinitionState State { get; set; }


        /// <summary>
        /// 优惠券是否已删除
        /// </summary>
        [DataMember]
        public bool IsDeleted{get;set;}	

        /// <summary>
        /// 所属商户的编号
        /// </summary>
        [DataMember]
        public int MerchantID { get; set; }



        public enum EnumCouponDefinitionState
        {
            /// <summary>
            /// 默认状态，闲置，不能进行派发操作
            /// </summary>
            Default,

            /// <summary>
            /// 已激活，可使用
            /// </summary>
            Actived,

            /// <summary>
            /// 已过期
            /// </summary>
            Expired


        }










    }

}