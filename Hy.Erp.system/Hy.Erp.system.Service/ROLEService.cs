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
    /// 角色
    /// </summary>
    [TransactionManager]
	public class ROLEService:SupportService, IROLEService
    {
	
        #region 属性
		
		/// <summary>
        /// 角色，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(ROLEDao))]
		public IROLEDao ROLEDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入角色的单一对象
        /// </summary>
        /// <param name="ROLE">角色的单一对象</param>
        /// <returns>当前操作的角色对象</returns>
        public ROLE Insert(ROLE ROLE)
        {
			return ROLEDao.Insert(ROLE);
        }
		
		/// <summary>
        /// 更新角色的单一对象
        /// </summary>
        /// <param name="ROLE">角色的单一对象</param>
        public void Update(ROLE ROLE)
        {
            ROLEDao.Update(ROLE);
        }
		
		/// <summary>
        /// 删除角色的单一对象
        /// </summary>
        /// <param name="ROLE">角色的单一对象(主键数据不能为空)</param>
        public void Delete(ROLE ROLE)
        {
             ROLEDao.Delete(ROLE);
        }
		
		/// <summary>
        /// 批量删除角色的对象数组
        /// </summary>
        /// <param name="collection">角色的对象数组(主键数据不能为空)</param>
        public void Delete(IList< ROLE >  collection)
        {
            ROLEDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找角色的单一对象
        /// </summary>
        /// <param name="ROLE">ROLE(主键数据不能为空)</param>
        /// <returns>角色对象</returns>
        public ROLE FindOnly(ROLE ROLE)
        {
            return ROLEDao.FindOnly(ROLE);
        }
		
		/// <summary>
        /// 查询角色数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>角色的对象数组</returns>
		public IList< ROLE> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  ROLEDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计角色数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return ROLEDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 角色分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>角色的对象数组</returns>
		public IList< ROLE> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return ROLEDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
