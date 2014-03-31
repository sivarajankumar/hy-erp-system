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
    /// 书籍条目
    /// </summary>
    [TransactionManager]
	public class BOOKSService:SupportService, IBOOKSService
    {
	
        #region 属性
		
		/// <summary>
        /// 书籍条目，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(BOOKSDao))]
		public IBOOKSDao BOOKSDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入书籍条目的单一对象
        /// </summary>
        /// <param name="BOOKS">书籍条目的单一对象</param>
        /// <returns>当前操作的书籍条目对象</returns>
        public BOOKS Insert(BOOKS BOOKS)
        {
			return BOOKSDao.Insert(BOOKS);
        }
		
		/// <summary>
        /// 更新书籍条目的单一对象
        /// </summary>
        /// <param name="BOOKS">书籍条目的单一对象</param>
        public void Update(BOOKS BOOKS)
        {
            BOOKSDao.Update(BOOKS);
        }
		
		/// <summary>
        /// 删除书籍条目的单一对象
        /// </summary>
        /// <param name="BOOKS">书籍条目的单一对象(主键数据不能为空)</param>
        public void Delete(BOOKS BOOKS)
        {
             BOOKSDao.Delete(BOOKS);
        }
		
		/// <summary>
        /// 批量删除书籍条目的对象数组
        /// </summary>
        /// <param name="collection">书籍条目的对象数组(主键数据不能为空)</param>
        public void Delete(IList< BOOKS >  collection)
        {
            BOOKSDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找书籍条目的单一对象
        /// </summary>
        /// <param name="BOOKS">BOOKS(主键数据不能为空)</param>
        /// <returns>书籍条目对象</returns>
        public BOOKS FindOnly(BOOKS BOOKS)
        {
            return BOOKSDao.FindOnly(BOOKS);
        }
		
		/// <summary>
        /// 查询书籍条目数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书籍条目的对象数组</returns>
		public IList< BOOKS> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  BOOKSDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计书籍条目数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return BOOKSDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 书籍条目分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书籍条目的对象数组</returns>
		public IList< BOOKS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return BOOKSDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
