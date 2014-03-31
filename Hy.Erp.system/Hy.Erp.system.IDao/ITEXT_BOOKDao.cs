using System.Data;
using System.Collections.Generic;
using System.Collections;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IDao
{
	/// <summary>
	/// 购书单
	/// </summary>
    public interface ITEXTBOOKDao
    {
		/// <summary>
        /// 插入购书单的单一对象
        /// </summary>
        /// <param name="TEXTBOOK">购书单的单一对象</param>
        /// <returns>当前操作的购书单对象</returns>
		TEXTBOOK Insert(TEXTBOOK TEXTBOOK);

		/// <summary>
        /// 批量插入购书单的对象数组
        /// </summary>
        /// <param name="collection">购书单的对象数组</param>
        void Insert(IList<TEXTBOOK> collection);
		
		/// <summary>
        /// 批量更新购书单的对象数组
        /// </summary>
        /// <param name="collection">购书单的对象数组</param>
		void Update(TEXTBOOK TEXTBOOK);

		/// <summary>
        /// 批量更新购书单的对象数组
        /// </summary>
        /// <param name="collection">购书单的对象数组</param>
		void Update(IList<TEXTBOOK> collection);

		/// <summary>
        /// 删除购书单的单一对象
        /// </summary>
        /// <param name="TEXTBOOK">购书单的单一对象(主键数据不能为空)</param>
		void Delete(TEXTBOOK TEXTBOOK);

		/// <summary>
        /// 批量删除购书单的对象数组
        /// </summary>
        /// <param name="collection">购书单的对象数组(主键数据不能为空)</param>
		void Delete(IList< TEXTBOOK> collection);

		/// <summary>
        /// 查找购书单的单一对象
        /// </summary>
        /// <param name="TEXTBOOK">TEXTBOOK(主键数据不能为空)</param>
        /// <returns>购书单对象</returns>
		TEXTBOOK FindOnly(TEXTBOOK TEXTBOOK);
		
		/// <summary>
        /// 查询购书单数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>购书单的对象数组</returns>
		IList< TEXTBOOK> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
		
		/// <summary>
        /// 统计购书单数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);
		
		/// <summary>
        /// 购书单分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>购书单的对象数组</returns>
		IList< TEXTBOOK> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
	
	}
}
