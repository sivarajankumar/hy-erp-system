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
    /// 新订购单
    /// </summary>
    [TransactionManager]
	public class BOOKORDERService:SupportService, IBOOKORDERService
    {
	
        #region 属性
		
		/// <summary>
        /// 新订购单，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(BOOKORDERDao))]
		public IBOOKORDERDao BOOKORDERDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入新订购单的单一对象
        /// </summary>
        /// <param name="BOOKORDER">新订购单的单一对象</param>
        /// <returns>当前操作的新订购单对象</returns>
        public BOOKORDER Insert(BOOKORDER BOOKORDER)
        {
			return BOOKORDERDao.Insert(BOOKORDER);
        }
		
		/// <summary>
        /// 更新新订购单的单一对象
        /// </summary>
        /// <param name="BOOKORDER">新订购单的单一对象</param>
        public void Update(BOOKORDER BOOKORDER)
        {
            BOOKORDERDao.Update(BOOKORDER);
        }
		
		/// <summary>
        /// 删除新订购单的单一对象
        /// </summary>
        /// <param name="BOOKORDER">新订购单的单一对象(主键数据不能为空)</param>
        public void Delete(BOOKORDER BOOKORDER)
        {
             BOOKORDERDao.Delete(BOOKORDER);
        }
		
		/// <summary>
        /// 批量删除新订购单的对象数组
        /// </summary>
        /// <param name="collection">新订购单的对象数组(主键数据不能为空)</param>
        public void Delete(IList< BOOKORDER >  collection)
        {
            BOOKORDERDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找新订购单的单一对象
        /// </summary>
        /// <param name="BOOKORDER">BOOKORDER(主键数据不能为空)</param>
        /// <returns>新订购单对象</returns>
        public BOOKORDER FindOnly(BOOKORDER BOOKORDER)
        {
            return BOOKORDERDao.FindOnly(BOOKORDER);
        }
		
		/// <summary>
        /// 查询新订购单数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>新订购单的对象数组</returns>
		public IList< BOOKORDER> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  BOOKORDERDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计新订购单数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return BOOKORDERDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 新订购单分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>新订购单的对象数组</returns>
		public IList< BOOKORDER> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return BOOKORDERDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
