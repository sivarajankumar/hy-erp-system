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
    /// 权限
    /// </summary>
    [TransactionManager]
	public class RIGHTSService:SupportService, IRIGHTSService
    {
	
        #region 属性
		
		/// <summary>
        /// 权限，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(RIGHTSDao))]
		public IRIGHTSDao RIGHTSDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入权限的单一对象
        /// </summary>
        /// <param name="RIGHTS">权限的单一对象</param>
        /// <returns>当前操作的权限对象</returns>
        public RIGHTS Insert(RIGHTS RIGHTS)
        {
			return RIGHTSDao.Insert(RIGHTS);
        }
		
		/// <summary>
        /// 更新权限的单一对象
        /// </summary>
        /// <param name="RIGHTS">权限的单一对象</param>
        public void Update(RIGHTS RIGHTS)
        {
            RIGHTSDao.Update(RIGHTS);
        }
		
		/// <summary>
        /// 删除权限的单一对象
        /// </summary>
        /// <param name="RIGHTS">权限的单一对象(主键数据不能为空)</param>
        public void Delete(RIGHTS RIGHTS)
        {
             RIGHTSDao.Delete(RIGHTS);
        }
		
		/// <summary>
        /// 批量删除权限的对象数组
        /// </summary>
        /// <param name="collection">权限的对象数组(主键数据不能为空)</param>
        public void Delete(IList< RIGHTS >  collection)
        {
            RIGHTSDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找权限的单一对象
        /// </summary>
        /// <param name="RIGHTS">RIGHTS(主键数据不能为空)</param>
        /// <returns>权限对象</returns>
        public RIGHTS FindOnly(RIGHTS RIGHTS)
        {
            return RIGHTSDao.FindOnly(RIGHTS);
        }
		
		/// <summary>
        /// 查询权限数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>权限的对象数组</returns>
		public IList< RIGHTS> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  RIGHTSDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计权限数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return RIGHTSDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 权限分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>权限的对象数组</returns>
		public IList< RIGHTS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return RIGHTSDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
