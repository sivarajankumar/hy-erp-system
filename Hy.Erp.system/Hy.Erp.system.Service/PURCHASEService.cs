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
    /// 购买
    /// </summary>
    [TransactionManager]
	public class PURCHASEService:SupportService, IPURCHASEService
    {
	
        #region 属性
		
		/// <summary>
        /// 购买，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(PURCHASEDao))]
		public IPURCHASEDao PURCHASEDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入购买的单一对象
        /// </summary>
        /// <param name="PURCHASE">购买的单一对象</param>
        /// <returns>当前操作的购买对象</returns>
        public PURCHASE Insert(PURCHASE PURCHASE)
        {
			return PURCHASEDao.Insert(PURCHASE);
        }
		
		/// <summary>
        /// 更新购买的单一对象
        /// </summary>
        /// <param name="PURCHASE">购买的单一对象</param>
        public void Update(PURCHASE PURCHASE)
        {
            PURCHASEDao.Update(PURCHASE);
        }
		
		/// <summary>
        /// 删除购买的单一对象
        /// </summary>
        /// <param name="PURCHASE">购买的单一对象(主键数据不能为空)</param>
        public void Delete(PURCHASE PURCHASE)
        {
             PURCHASEDao.Delete(PURCHASE);
        }
		
		/// <summary>
        /// 批量删除购买的对象数组
        /// </summary>
        /// <param name="collection">购买的对象数组(主键数据不能为空)</param>
        public void Delete(IList< PURCHASE >  collection)
        {
            PURCHASEDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找购买的单一对象
        /// </summary>
        /// <param name="PURCHASE">PURCHASE(主键数据不能为空)</param>
        /// <returns>购买对象</returns>
        public PURCHASE FindOnly(PURCHASE PURCHASE)
        {
            return PURCHASEDao.FindOnly(PURCHASE);
        }
		
		/// <summary>
        /// 查询购买数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>购买的对象数组</returns>
		public IList< PURCHASE> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  PURCHASEDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计购买数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return PURCHASEDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 购买分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>购买的对象数组</returns>
		public IList< PURCHASE> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return PURCHASEDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
