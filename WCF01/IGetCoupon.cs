using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF01
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“ICoupon”。
    [ServiceContract(Name = "ybjaa", Namespace = "www.ybjaa.com")]
    public interface IGetCoupon
    {


        /// <summary>
        /// 查找可用红包
        /// </summary>
        /// <param name="memberId">会员编号</param>
        /// <param name="merchantId">商户编号</param>
        /// <param name="coupon">找到的红包对象，未找到时为null</param>
        /// <param name="status">操作状态枚举</param>
        [OperationContract]
        void RetrieveAvailableCoupon(int memberId, int merchantId, out Coupon coupon, out EnumCouponStatus status);

      
        
        /// <summary>
        /// 搜索指定会员持有的红包集合
        /// </summary>
        /// <param name="memberId">会员编号</param>
        /// <param name="merchantId">商户编号，为0时表示查找所有商户派发的红包</param>
        /// <param name="keywords">搜索商户名称的关键字，为""时表示查找所有商户</param>
        /// <param name="state">查找指定类型的红包，为""表示查找所有类型</param>
        /// <param name="orderField">排序字段名称，与orderDirection无法构成合法SQL片段时，忽略</param>
        /// <param name="orderDirection">排序方式，仅能为 "ASC" 或 "DESC" </param>
        /// <param name="pageIndex">分页索引值</param>
        /// <param name="pageSize">分页时每页允许的结果条数</param>
        /// <param name="conpons">找到的红包对象集合（至多有pageSize项），未找到时为空集合</param>
        /// <param name="itemCount">符合查找条件的红包数量</param>
        /// <param name="pageCount">服务器端分页数量</param>
        /// <param name="status">操作状态枚举</param>
        [OperationContract]
        void SelectCoupons(int memberId, int merchantId, string keywords, 
            string state, string orderField, string orderDirection,
            int pageIndex, int pageSize,

            out Coupon[] conpons, out int itemCount, out int pageCount,
            out EnumCouponStatus  status);





     


    }



   






}
