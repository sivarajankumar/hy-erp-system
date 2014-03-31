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
    /// 组织
    /// </summary>
    [TransactionManager]
	public class ORGANIZATIONService:SupportService, IORGANIZATIONService
    {
	
        #region 属性
		
		/// <summary>
        /// 组织，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(ORGANIZATIONDao))]
		public IORGANIZATIONDao ORGANIZATIONDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入组织的单一对象
        /// </summary>
        /// <param name="ORGANIZATION">组织的单一对象</param>
        /// <returns>当前操作的组织对象</returns>
        public ORGANIZATION Insert(ORGANIZATION ORGANIZATION)
        {
			return ORGANIZATIONDao.Insert(ORGANIZATION);
        }
		
		/// <summary>
        /// 更新组织的单一对象
        /// </summary>
        /// <param name="ORGANIZATION">组织的单一对象</param>
        public void Update(ORGANIZATION ORGANIZATION)
        {
            ORGANIZATIONDao.Update(ORGANIZATION);
        }
		
		/// <summary>
        /// 删除组织的单一对象
        /// </summary>
        /// <param name="ORGANIZATION">组织的单一对象(主键数据不能为空)</param>
        public void Delete(ORGANIZATION ORGANIZATION)
        {
             ORGANIZATIONDao.Delete(ORGANIZATION);
        }
		
		/// <summary>
        /// 批量删除组织的对象数组
        /// </summary>
        /// <param name="collection">组织的对象数组(主键数据不能为空)</param>
        public void Delete(IList< ORGANIZATION >  collection)
        {
            ORGANIZATIONDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找组织的单一对象
        /// </summary>
        /// <param name="ORGANIZATION">ORGANIZATION(主键数据不能为空)</param>
        /// <returns>组织对象</returns>
        public ORGANIZATION FindOnly(ORGANIZATION ORGANIZATION)
        {
            return ORGANIZATIONDao.FindOnly(ORGANIZATION);
        }
		
		/// <summary>
        /// 查询组织数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>组织的对象数组</returns>
		public IList< ORGANIZATION> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  ORGANIZATIONDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计组织数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return ORGANIZATIONDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 组织分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>组织的对象数组</returns>
		public IList< ORGANIZATION> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return ORGANIZATIONDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
