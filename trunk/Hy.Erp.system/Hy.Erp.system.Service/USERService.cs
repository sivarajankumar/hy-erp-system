using System;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using HP.Mapper.Service;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;
using Hy.Erp.system.Service.Support;
using Hy.Erp.system.IService;
using Hy.Erp.system.IDao;
using Hy.Erp.system.Dao;
using Hy.Erp.system.Common;

namespace Hy.Erp.system.Service
{
	 /// <summary>
    /// 用户
    /// </summary>
    [TransactionManager]
	public class USERService:SupportService, IUSERService
    {
	
        #region 属性
		
		/// <summary>
        /// 用户，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(USERDao))]
		public IUSERDao USERDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入用户的单一对象
        /// </summary>
        /// <param name="USER">用户的单一对象</param>
        /// <returns>当前操作的用户对象</returns>
        public USER Insert(USER USER)
        {
			return USERDao.Insert(USER);
        }
		
		/// <summary>
        /// 更新用户的单一对象
        /// </summary>
        /// <param name="USER">用户的单一对象</param>
        public void Update(USER USER)
        {
            USERDao.Update(USER);
        }
		
		/// <summary>
        /// 删除用户的单一对象
        /// </summary>
        /// <param name="USER">用户的单一对象(主键数据不能为空)</param>
        public void Delete(USER USER)
        {
             USERDao.Delete(USER);
        }
		
		/// <summary>
        /// 批量删除用户的对象数组
        /// </summary>
        /// <param name="collection">用户的对象数组(主键数据不能为空)</param>
        public void Delete(IList< USER >  collection)
        {
            USERDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找用户的单一对象
        /// </summary>
        /// <param name="USER">USER(主键数据不能为空)</param>
        /// <returns>用户对象</returns>
        public USER FindOnly(USER USER)
        {
            return USERDao.FindOnly(USER);
        }
		
		/// <summary>
        /// 查询用户数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>用户的对象数组</returns>
		public IList< USER> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  USERDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计用户数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return USERDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 用户分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>用户的对象数组</returns>
		public IList< USER> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return USERDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
