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
    /// 书籍代理商关联
    /// </summary>
    [TransactionManager]
	public class BOOKSAGENTSService:SupportService, IBOOKSAGENTSService
    {
	
        #region 属性
		
		/// <summary>
        /// 书籍代理商关联，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(BOOKSAGENTSDao))]
		public IBOOKSAGENTSDao BOOKSAGENTSDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入书籍代理商关联的单一对象
        /// </summary>
        /// <param name="BOOKSAGENTS">书籍代理商关联的单一对象</param>
        /// <returns>当前操作的书籍代理商关联对象</returns>
        public BOOKSAGENTS Insert(BOOKSAGENTS BOOKSAGENTS)
        {
			return BOOKSAGENTSDao.Insert(BOOKSAGENTS);
        }
		
		/// <summary>
        /// 更新书籍代理商关联的单一对象
        /// </summary>
        /// <param name="BOOKSAGENTS">书籍代理商关联的单一对象</param>
        public void Update(BOOKSAGENTS BOOKSAGENTS)
        {
            BOOKSAGENTSDao.Update(BOOKSAGENTS);
        }
		
		/// <summary>
        /// 删除书籍代理商关联的单一对象
        /// </summary>
        /// <param name="BOOKSAGENTS">书籍代理商关联的单一对象(主键数据不能为空)</param>
        public void Delete(BOOKSAGENTS BOOKSAGENTS)
        {
             BOOKSAGENTSDao.Delete(BOOKSAGENTS);
        }
		
		/// <summary>
        /// 批量删除书籍代理商关联的对象数组
        /// </summary>
        /// <param name="collection">书籍代理商关联的对象数组(主键数据不能为空)</param>
        public void Delete(IList< BOOKSAGENTS >  collection)
        {
            BOOKSAGENTSDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找书籍代理商关联的单一对象
        /// </summary>
        /// <param name="BOOKSAGENTS">BOOKSAGENTS(主键数据不能为空)</param>
        /// <returns>书籍代理商关联对象</returns>
        public BOOKSAGENTS FindOnly(BOOKSAGENTS BOOKSAGENTS)
        {
            return BOOKSAGENTSDao.FindOnly(BOOKSAGENTS);
        }
		
		/// <summary>
        /// 查询书籍代理商关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书籍代理商关联的对象数组</returns>
		public IList< BOOKSAGENTS> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  BOOKSAGENTSDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计书籍代理商关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return BOOKSAGENTSDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 书籍代理商关联分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书籍代理商关联的对象数组</returns>
		public IList< BOOKSAGENTS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return BOOKSAGENTSDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
