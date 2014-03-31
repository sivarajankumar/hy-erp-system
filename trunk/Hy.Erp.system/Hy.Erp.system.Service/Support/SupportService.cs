/* **************************************************************************
 * 功能描述:Xh.TrafficPolice.SMSService
 * 开发者: lihuap
 * 建立时间:2012-09-03 10:48:58
 * 修订描述: 
 * 进度描述:
 * 版本号:    1.0
 * **************************************************************************/

using HP.Mapper.Data;
using HP.Mapper.Service;
using HP.Mapper.Core;
using Hy.Erp.system.Entity;
using System.Web;
using Hy.Erp.system.Common;

namespace Hy.Erp.system.Service.Support
{
    public abstract class SupportService : ServiceContext
    {
        public SupportService()
            : base("~/SqlMap.xml")
        {
        }

        //private User _CUR_USER = null;

        ///// <summary>
        ///// 获取当前登录用户信息
        ///// </summary>
        //public User CUR_USER
        //{
        //    get
        //    {
        //        if (_CUR_USER == null)
        //        {
        //            _CUR_USER = HttpContext.Current.Session[Constant.CUR_USER] as User;
        //        }
        //        return _CUR_USER;
        //    }
        //}

      
    }
}


