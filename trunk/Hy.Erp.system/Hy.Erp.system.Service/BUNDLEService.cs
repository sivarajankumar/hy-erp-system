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
    /// 购书捆绑包
    /// </summary>
    [TransactionManager]
	public class BUNDLEService:SupportService, IBUNDLEService
    {
	
        #region 属性
		
		/// <summary>
        /// 购书捆绑包，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(BUNDLEDao))]
		public IBUNDLEDao BUNDLEDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入购书捆绑包的单一对象
        /// </summary>
        /// <param name="BUNDLE">购书捆绑包的单一对象</param>
        /// <returns>当前操作的购书捆绑包对象</returns>
        public BUNDLE Insert(BUNDLE BUNDLE)
        {
			return BUNDLEDao.Insert(BUNDLE);
        }
		
		/// <summary>
        /// 更新购书捆绑包的单一对象
        /// </summary>
        /// <param name="BUNDLE">购书捆绑包的单一对象</param>
        public void Update(BUNDLE BUNDLE)
        {
            BUNDLEDao.Update(BUNDLE);
        }
		
		/// <summary>
        /// 删除购书捆绑包的单一对象
        /// </summary>
        /// <param name="BUNDLE">购书捆绑包的单一对象(主键数据不能为空)</param>
        public void Delete(BUNDLE BUNDLE)
        {
             BUNDLEDao.Delete(BUNDLE);
        }
		
		/// <summary>
        /// 批量删除购书捆绑包的对象数组
        /// </summary>
        /// <param name="collection">购书捆绑包的对象数组(主键数据不能为空)</param>
        public void Delete(IList< BUNDLE >  collection)
        {
            BUNDLEDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找购书捆绑包的单一对象
        /// </summary>
        /// <param name="BUNDLE">BUNDLE(主键数据不能为空)</param>
        /// <returns>购书捆绑包对象</returns>
        public BUNDLE FindOnly(BUNDLE BUNDLE)
        {
            return BUNDLEDao.FindOnly(BUNDLE);
        }
		
		/// <summary>
        /// 查询购书捆绑包数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>购书捆绑包的对象数组</returns>
		public IList< BUNDLE> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  BUNDLEDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计购书捆绑包数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return BUNDLEDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 购书捆绑包分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>购书捆绑包的对象数组</returns>
		public IList< BUNDLE> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return BUNDLEDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
