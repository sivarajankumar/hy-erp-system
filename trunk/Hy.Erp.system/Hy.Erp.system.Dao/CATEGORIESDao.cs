using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using HP.Mapper.Core.Support;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;
using Hy.Erp.system.IDao;

namespace Hy.Erp.system.Dao
{
	/// <summary>
	/// 书籍分类，数据访问
	/// </summary>
	public class CATEGORIESDao : MapperDaoSupport, ICATEGORIESDao
	{
		/// <summary>
        /// 插入书籍分类的单一对象
        /// </summary>
        /// <param name="CATEGORIES">书籍分类的单一对象</param>
        /// <returns>当前操作的书籍分类对象</returns>
		public CATEGORIES Insert(CATEGORIES CATEGORIES)
		{
			CATEGORIES.ID = Convert.ToInt32(MapperTemplate.Insert(CATEGORIES));
			return CATEGORIES;
		}
		
		/// <summary>
        /// 批量插入书籍分类的对象数组
        /// </summary>
        /// <param name="collection">书籍分类的对象数组</param>
        public void Insert(IList<CATEGORIES> collection)
        {
            MapperTemplate.InsertBatch< CATEGORIES>(collection);
        }
		
		/// <summary>
        /// 更新书籍分类的单一对象
        /// </summary>
        /// <param name="CATEGORIES">书籍分类的单一对象</param>
		public void Update(CATEGORIES CATEGORIES)
		{
			MapperTemplate.Update(CATEGORIES);
		}

		/// <summary>
        /// 批量更新书籍分类的对象数组
        /// </summary>
        /// <param name="collection">书籍分类的对象数组</param>
		public void Update(IList<CATEGORIES> collection)
		{
			MapperTemplate.UpdateBatch< CATEGORIES>(collection);
		}

		/// <summary>
        /// 删除书籍分类的单一对象
        /// </summary>
        /// <param name="CATEGORIES">书籍分类的单一对象(主键数据不能为空)</param>
		public void Delete(CATEGORIES CATEGORIES)
		{
			MapperTemplate.Delete(CATEGORIES);
		}

		/// <summary>
        /// 批量删除书籍分类的对象数组
        /// </summary>
        /// <param name="collection">书籍分类的对象数组(主键数据不能为空)</param>
		public void Delete(IList< CATEGORIES> collection)
		{
			MapperTemplate.DeleteBatch< CATEGORIES>(collection);
		}

		/// <summary>
        /// 查找书籍分类的单一对象
        /// </summary>
        /// <param name="CATEGORIES">CATEGORIES(主键数据不能为空)</param>
        /// <returns>书籍分类对象</returns>
        public CATEGORIES FindOnly(CATEGORIES CATEGORIES)
        {
            return MapperTemplate.FindOnly(CATEGORIES);
        }
		
		/// <summary>
        /// 查询书籍分类数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书籍分类的对象数组</returns>
		public IList< CATEGORIES> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< CATEGORIES>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计书籍分类数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< CATEGORIES>(conditionCollection);
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
		public IList< CATEGORIES> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< CATEGORIES>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
