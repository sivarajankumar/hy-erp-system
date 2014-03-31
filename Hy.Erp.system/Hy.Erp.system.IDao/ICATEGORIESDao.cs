using System.Data;
using System.Collections.Generic;
using System.Collections;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IDao
{
	/// <summary>
	/// 书籍分类
	/// </summary>
    public interface ICATEGORIESDao
    {
		/// <summary>
        /// 插入书籍分类的单一对象
        /// </summary>
        /// <param name="CATEGORIES">书籍分类的单一对象</param>
        /// <returns>当前操作的书籍分类对象</returns>
		CATEGORIES Insert(CATEGORIES CATEGORIES);

		/// <summary>
        /// 批量插入书籍分类的对象数组
        /// </summary>
        /// <param name="collection">书籍分类的对象数组</param>
        void Insert(IList<CATEGORIES> collection);
		
		/// <summary>
        /// 批量更新书籍分类的对象数组
        /// </summary>
        /// <param name="collection">书籍分类的对象数组</param>
		void Update(CATEGORIES CATEGORIES);

		/// <summary>
        /// 批量更新书籍分类的对象数组
        /// </summary>
        /// <param name="collection">书籍分类的对象数组</param>
		void Update(IList<CATEGORIES> collection);

		/// <summary>
        /// 删除书籍分类的单一对象
        /// </summary>
        /// <param name="CATEGORIES">书籍分类的单一对象(主键数据不能为空)</param>
		void Delete(CATEGORIES CATEGORIES);

		/// <summary>
        /// 批量删除书籍分类的对象数组
        /// </summary>
        /// <param name="collection">书籍分类的对象数组(主键数据不能为空)</param>
		void Delete(IList< CATEGORIES> collection);

		/// <summary>
        /// 查找书籍分类的单一对象
        /// </summary>
        /// <param name="CATEGORIES">CATEGORIES(主键数据不能为空)</param>
        /// <returns>书籍分类对象</returns>
		CATEGORIES FindOnly(CATEGORIES CATEGORIES);
		
		/// <summary>
        /// 查询书籍分类数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书籍分类的对象数组</returns>
		IList< CATEGORIES> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
		
		/// <summary>
        /// 统计书籍分类数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);
		
		/// <summary>
        /// 书籍分类分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书籍分类的对象数组</returns>
		IList< CATEGORIES> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
	
	}
}
