using System.Web;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IService
{
	/// <summary>
	/// 新订购单
	/// </summary>
    public interface IBOOKORDERService
    {
		/// <summary>
        /// 插入新订购单的单一对象
        /// </summary>
        /// <param name="BOOKORDER">新订购单的单一对象</param>
        /// <returns>当前操作的新订购单对象</returns>
  	    BOOKORDER Insert(BOOKORDER BOOKORDER);
		
		/// <summary>
        /// 更新新订购单的单一对象
        /// </summary>
        /// <param name="BOOKORDER">新订购单的单一对象</param>
		void Update(BOOKORDER BOOKORDER);

		/// <summary>
        /// 删除新订购单的单一对象
        /// </summary>
        /// <param name="BOOKORDER">新订购单的单一对象(主键数据不能为空)</param>
		void Delete(BOOKORDER BOOKORDER);
		
		/// <summary>
        /// 批量删除新订购单的对象数组
        /// </summary>
        /// <param name="collection">新订购单的对象数组(主键数据不能为空)</param>
		void Delete(IList< BOOKORDER > collection);

		/// <summary>
        /// 查找新订购单的单一对象
        /// </summary>
        /// <param name="BOOKORDER">BOOKORDER(主键数据不能为空)</param>
        /// <returns>新订购单对象</returns>
        BOOKORDER FindOnly(BOOKORDER BOOKORDER);
		
		/// <summary>
        /// 查询新订购单数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>新订购单的对象数组</returns>
		IList< BOOKORDER> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);

		/// <summary>
        /// 统计新订购单数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);

		/// <summary>
        /// 新订购单分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>新订购单的对象数组</returns>
		IList< BOOKORDER> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);    
		
	}
}
