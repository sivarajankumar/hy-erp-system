using System.Data;
using System.Collections.Generic;
using System.Collections;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IDao
{
	/// <summary>
	/// 书籍条目
	/// </summary>
    public interface IBOOKSDao
    {
		/// <summary>
        /// 插入书籍条目的单一对象
        /// </summary>
        /// <param name="BOOKS">书籍条目的单一对象</param>
        /// <returns>当前操作的书籍条目对象</returns>
		BOOKS Insert(BOOKS BOOKS);

		/// <summary>
        /// 批量插入书籍条目的对象数组
        /// </summary>
        /// <param name="collection">书籍条目的对象数组</param>
        void Insert(IList<BOOKS> collection);
		
		/// <summary>
        /// 批量更新书籍条目的对象数组
        /// </summary>
        /// <param name="collection">书籍条目的对象数组</param>
		void Update(BOOKS BOOKS);

		/// <summary>
        /// 批量更新书籍条目的对象数组
        /// </summary>
        /// <param name="collection">书籍条目的对象数组</param>
		void Update(IList<BOOKS> collection);

		/// <summary>
        /// 删除书籍条目的单一对象
        /// </summary>
        /// <param name="BOOKS">书籍条目的单一对象(主键数据不能为空)</param>
		void Delete(BOOKS BOOKS);

		/// <summary>
        /// 批量删除书籍条目的对象数组
        /// </summary>
        /// <param name="collection">书籍条目的对象数组(主键数据不能为空)</param>
		void Delete(IList< BOOKS> collection);

		/// <summary>
        /// 查找书籍条目的单一对象
        /// </summary>
        /// <param name="BOOKS">BOOKS(主键数据不能为空)</param>
        /// <returns>书籍条目对象</returns>
		BOOKS FindOnly(BOOKS BOOKS);
		
		/// <summary>
        /// 查询书籍条目数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书籍条目的对象数组</returns>
		IList< BOOKS> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
		
		/// <summary>
        /// 统计书籍条目数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);
		
		/// <summary>
        /// 书籍条目分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书籍条目的对象数组</returns>
		IList< BOOKS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
	
	}
}
