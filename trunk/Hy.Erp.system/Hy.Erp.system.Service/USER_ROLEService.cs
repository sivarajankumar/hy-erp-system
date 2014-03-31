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
    /// 用户角色关联
    /// </summary>
    [TransactionManager]
	public class USERROLEService:SupportService, IUSERROLEService
    {
	
        #region 属性
		
		/// <summary>
        /// 用户角色关联，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(USERROLEDao))]
		public IUSERROLEDao USERROLEDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入用户角色关联的单一对象
        /// </summary>
        /// <param name="USERROLE">用户角色关联的单一对象</param>
        /// <returns>当前操作的用户角色关联对象</returns>
        public USERROLE Insert(USERROLE USERROLE)
        {
			return USERROLEDao.Insert(USERROLE);
        }
		
		/// <summary>
        /// 更新用户角色关联的单一对象
        /// </summary>
        /// <param name="USERROLE">用户角色关联的单一对象</param>
        public void Update(USERROLE USERROLE)
        {
            USERROLEDao.Update(USERROLE);
        }
		
		/// <summary>
        /// 删除用户角色关联的单一对象
        /// </summary>
        /// <param name="USERROLE">用户角色关联的单一对象(主键数据不能为空)</param>
        public void Delete(USERROLE USERROLE)
        {
             USERROLEDao.Delete(USERROLE);
        }
		
		/// <summary>
        /// 批量删除用户角色关联的对象数组
        /// </summary>
        /// <param name="collection">用户角色关联的对象数组(主键数据不能为空)</param>
        public void Delete(IList< USERROLE >  collection)
        {
            USERROLEDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找用户角色关联的单一对象
        /// </summary>
        /// <param name="USERROLE">USERROLE(主键数据不能为空)</param>
        /// <returns>用户角色关联对象</returns>
        public USERROLE FindOnly(USERROLE USERROLE)
        {
            return USERROLEDao.FindOnly(USERROLE);
        }
		
		/// <summary>
        /// 查询用户角色关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>用户角色关联的对象数组</returns>
		public IList< USERROLE> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  USERROLEDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计用户角色关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return USERROLEDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 用户角色关联分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>用户角色关联的对象数组</returns>
		public IList< USERROLE> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return USERROLEDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
