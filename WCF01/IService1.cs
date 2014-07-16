﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF01
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract(Name="ybjaa",Namespace="www.ybjaa.com")]
    public interface IService1
    {

       
        [OperationContract]
        string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);


        //[OperationContract]
        //bool IsCheck(User user);

        // TODO: 在此添加您的服务操作
    }


    //// 使用下面示例中说明的数据约定将复合类型添加到服务操作。
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";


    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }

        
    //    [DataMember]
    //    public string StringValue
    //    {
    //        get { return stringValue; }
    //        set { stringValue = value; }
    //    }
    //}



    //[DataContract]
    //public class User
    //{


    //    string userName="aa";

    //    string passWord = "aaa";

    //    [DataMember]
    //    public string UserName {
    //        get
    //        {
    //            return userName;
    //        }
    //        set
    //        {
    //            userName = value;
    //        }
    //    }

    //    [DataMember]
    //    public string PassWord
    //    {
    //        get
    //        {
    //            return passWord;
    //        }
    //        set
    //        {
    //            passWord = value;
    //        }
    //    } 
    //}

}
