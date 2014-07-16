using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF01.DataSource
{
    public static class GetData
    {


        public static Coupon[] GetCoupons()
        {

            List<Coupon> listCoupons = new List<Coupon>();

            Coupon coupon = null;

            int i = 0;
            coupon  = new Coupon()
            {
                ID = i + 1,
                Name = "红包名称" + (i + 1).ToString(),
                DateTimeBegin = DateTime.Now,
                DateTimeExpired = DateTime.Now.AddDays(20),
                DefinitionID = i + 1,
                Description = "<html>我是那什么红包</html>",
                MemberMPhone = "123457678" + i.ToString("00"),
                MemberID = 43,
                MemberName = "脑残" + (i + 1).ToString() + "号",
                MerchantID = i + 1,
                MerchantName = "商户" + (i + 1).ToString() + "号",
                PictureUrl = "http://photos.tuchong.com/105722/f/6970118.jpg",
                PictureMiniUrl = "http://img03.mifile.cn/webfile/images/g/2014/cn/index/taozhuang800tu.jpg?width=220&height=220",
                DescriptionPlained = "我是那什么红包",
                SerialNo = "S12332112234567",
                State = Coupon.EnumCouponState.Available,
                TimeUsed = DateTime.Now,
                TimeDrawed = DateTime.Now,
                Strategies=GetCouponStrategy(1),
                IsDeleted = false,
                Amount = 0
            };
            listCoupons.Add(coupon);


            i++;
            coupon = new Coupon()
            {
                ID = i + 1,
                Name = "红包名称" + (i + 1).ToString(),
                DateTimeBegin = DateTime.Now,
                DateTimeExpired = DateTime.Now.AddDays(20),
                DefinitionID = i + 1,
                Description = "<html>我是那什么红包</html>",
                MemberMPhone = "123457678" + i.ToString("00"),
                MemberID = 43,
                MemberName = "脑残" + (i + 1).ToString() + "号",
                MerchantID = i + 1,
                MerchantName = "商户" + (i + 1).ToString() + "号",
                PictureUrl = "http://photos.tuchong.com/105722/f/6970118.jpg",
                PictureMiniUrl = "http://img03.mifile.cn/webfile/images/2014/cn/goods/mipad/p-1.jpg",
                DescriptionPlained = "我是那什么红包",
                SerialNo = "S12332112234567",
                State = Coupon.EnumCouponState.Available,
                TimeUsed = DateTime.Now,
                TimeDrawed = DateTime.Now,
                Strategies = GetCouponStrategy(1),
                IsDeleted = false,
                Amount = 0
            };
            listCoupons.Add(coupon);


            i++;
            coupon = new Coupon()
            {
                ID = i + 1,
                Name = "红包名称" + (i + 1).ToString(),
                DateTimeBegin = DateTime.Now,
                DateTimeExpired = DateTime.Now.AddDays(20),
                DefinitionID = i + 1,
                Description = "<html>我是那什么红包</html>",
                MemberMPhone = "123457678" + i.ToString("00"),
                MemberID = 43,
                MemberName = "脑残" + (i + 1).ToString() + "号",
                MerchantID = i + 1,
                MerchantName = "商户" + (i + 1).ToString() + "号",
                PictureUrl = "http://photos.tuchong.com/105722/f/6970118.jpg",
                PictureMiniUrl = "http://c.hiphotos.baidu.com/image/pic/item/ac4bd11373f0820270b367c949fbfbedab641b26.jpg",
                DescriptionPlained = "我是那什么红包",
                SerialNo = "S12332112234567",
                State = Coupon.EnumCouponState.Available,
                TimeUsed = DateTime.Now,
                TimeDrawed = DateTime.Now,
                Strategies = GetCouponStrategy(1),
                IsDeleted = false,
                Amount = 0
            };
            listCoupons.Add(coupon);


            i++;
            coupon = new Coupon()
            {
                ID = i + 1,
                Name = "红包名称" + (i + 1).ToString(),
                DateTimeBegin = DateTime.Now,
                DateTimeExpired = DateTime.Now.AddDays(20),
                DefinitionID = 43,
                Description = "<html>我是那什么红包</html>",
                MemberMPhone = "123457678" + i.ToString("00"),
                MemberID = i + 1,
                MemberName = "脑残" + (i + 1).ToString() + "号",
                MerchantID = i + 1,
                MerchantName = "商户" + (i + 1).ToString() + "号",
                PictureUrl = "http://photos.tuchong.com/105722/f/6970118.jpg",
                PictureMiniUrl = "http://h.hiphotos.baidu.com/image/pic/item/2e2eb9389b504fc23a0511f0e7dde71191ef6de9.jpg",
                DescriptionPlained = "我是那什么红包",
                SerialNo = "S12332112234567",
                State = Coupon.EnumCouponState.Available,
                TimeUsed = DateTime.Now,
                TimeDrawed = DateTime.Now,
                Strategies = GetCouponStrategy(1),
                IsDeleted = false,
                Amount = 0
            };
            listCoupons.Add(coupon);


            i++;
            coupon = new Coupon()
            {
                ID = i + 1,
                Name = "红包名称" + (i + 1).ToString(),
                DateTimeBegin = DateTime.Now,
                DateTimeExpired = DateTime.Now.AddDays(20),
                DefinitionID = i + 1,
                Description = "<html>我是那什么红包</html>",
                MemberMPhone = "123457678" + i.ToString("00"),
                MemberID = 43,
                MemberName = "脑残" + (i + 1).ToString() + "号",
                MerchantID = i + 1,
                MerchantName = "商户" + (i + 1).ToString() + "号",
                PictureUrl = "http://photos.tuchong.com/105722/f/6970118.jpg",
                PictureMiniUrl = "http://img3.fengniao.com/forum/attachpics/750/9/29961789_1500.jpg",
                DescriptionPlained = "我是那什么红包",
                SerialNo = "S12332112234567",
                State = Coupon.EnumCouponState.Available,
                TimeUsed = DateTime.Now,
                TimeDrawed = DateTime.Now,
                Strategies = GetCouponStrategy(2),
                IsDeleted=false,
                Amount=0
            };
            listCoupons.Add(coupon);


            i++;
            coupon = new Coupon()
            {
                ID = i + 1,
                Name = "红包名称" + (i + 1).ToString(),
                DateTimeBegin = DateTime.Now,
                DateTimeExpired = DateTime.Now.AddDays(20),
                DefinitionID = i + 1,
                Description = "<html>我是那什么红包</html>",
                DescriptionPlained = "我是那什么红包",
                MemberMPhone = "123457678" + i.ToString("00"),
                MemberID = 43,
                MemberName = "脑残" + (i + 1).ToString() + "号",
                MerchantID = i + 1,
                MerchantName = "商户" + (i + 1).ToString() + "号",
                PictureUrl = "http://photos.tuchong.com/105722/f/6970118.jpg",
                PictureMiniUrl = "http://p1.so.qhimg.com/t01e2119d6ef43999b6.jpg",
                SerialNo = "S12332112234567",
                State = Coupon.EnumCouponState.Available,
                TimeUsed = DateTime.Now,
                TimeDrawed = DateTime.Now,
                Strategies = GetCouponStrategy(2),
                IsDeleted = false,
                Amount = 0
            };
            listCoupons.Add(coupon);

            return listCoupons.ToArray();
            


          



 
        }



        /// <summary>
        /// 伪造数据（GetCouponStrategy）
        /// </summary>
        /// <returns></returns>
        /// <param name="definitionID">查找的definitionID</param>
        public static CouponStrategy[] GetCouponStrategy(int definitionID)
        {
           
            List<CouponStrategy> listCouponStrategy = new List<CouponStrategy>();

            int i = 0;
            CouponStrategy couponStrategy = null;
            couponStrategy = new CouponStrategy()
            {
                ID = i + 1,
                DefinitionID = 1,
                MinValue = 1000,
                MaxValue = 2000,
                Amount = 10

            };
            listCouponStrategy.Add(couponStrategy);


            i++;
            couponStrategy = new CouponStrategy()
            {
                ID = i + 1,
                DefinitionID = 1,
                MinValue = 2000,
                MaxValue = 3000,
                Amount = 20
            };
            listCouponStrategy.Add(couponStrategy);


            i++;
            couponStrategy = new CouponStrategy()
            {
                ID = i + 1,
                DefinitionID = 1,
                MinValue = 3000,
                MaxValue = 0,
                Amount=30
            };
            listCouponStrategy.Add(couponStrategy);


            i++;
            couponStrategy = new CouponStrategy()
            {
                ID = i + 1,
                DefinitionID = 2,
                MinValue = 0,
                MaxValue = 100,
                Amount = 5
            };
            listCouponStrategy.Add(couponStrategy);


            i++;
            couponStrategy = new CouponStrategy()
            {
                ID = i + 1,
                DefinitionID = 2,
                MinValue = 100,
                MaxValue = 200,
                Amount = 10
            };
            listCouponStrategy.Add(couponStrategy);


            i++;
            couponStrategy = new CouponStrategy()
            {
                ID = i + 1,
                DefinitionID = 2,
                MinValue = 200,
                MaxValue = 300,
                Amount = 20
            };
            listCouponStrategy.Add(couponStrategy);

            i++;
            couponStrategy = new CouponStrategy()
            {
                ID = i + 1,
                DefinitionID = 2,
                MinValue = 300,
                MaxValue = 0,
                Amount = 30
            };
            listCouponStrategy.Add(couponStrategy);


            return listCouponStrategy.SkipWhile(c=> !(c.DefinitionID==definitionID)).ToArray();

            



        }


    }
}