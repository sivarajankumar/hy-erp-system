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
    /// 书籍分类
    /// </summary>
    [TransactionManager]
	public class CATEGORIESService:SupportService, ICATEGORIESService
    {
	
        #region 属性
		
		/// <summary>
        /// 书籍分类，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(CATEGORIESDao))]
		public ICATEGORIESDao CATEGORIESDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入书籍分类的单一对象
        /// </summary>
        /// <param name="CATEGORIES">书籍分类的单一对象</param>
        /// <returns>当前操作的书籍分类对象</returns>
        public CATEGORIES Insert(CATEGORIES CATEGORIES)
        {
			return CATEGORIESDao.Insert(CATEGORIES);
        }
		
		/// <summary>
        /// 更新书籍分类的单一对象
        /// </summary>
        /// <param name="CATEGORIES">书籍分类的单一对象</param>
        public void Update(CATEGORIES CATEGORIES)
        {
            CATEGORIESDao.Update(CATEGORIES);
        }
		
		/// <summary>
        /// 删除书籍分类的单一对象
        /// </summary>
        /// <param name="CATEGORIES">书籍分类的单一对象(主键数据不能为空)</param>
        public void Delete(CATEGORIES CATEGORIES)
        {
             CATEGORIESDao.Delete(CATEGORIES);
        }
		
		/// <summary>
        /// 批量删除书籍分类的对象数组
        /// </summary>
        /// <param name="collection">书籍分类的对象数组(主键数据不能为空)</param>
        public void Delete(IList< CATEGORIES >  collection)
        {
            CATEGORIESDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找书籍分类的单一对象
        /// </summary>
        /// <param name="CATEGORIES">CATEGORIES(主键数据不能为空)</param>
        /// <returns>书籍分类对象</returns>
        public CATEGORIES FindOnly(CATEGORIES CATEGORIES)
        {
            return CATEGORIESDao.FindOnly(CATEGORIES);
        }
		
		/// <summary>
        /// 查询书籍分类数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书籍分类的对象数组</returns>
		public IList< CATEGORIES> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  CATEGORIESDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计书籍分类数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return CATEGORIESDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 书籍分类分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书籍分类的对象数组</returns>
		public IList< CATEGORIES> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return CATEGORIESDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
