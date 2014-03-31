using System.Data;
using System.Collections.Generic;
using System.Collections;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IDao
{
	/// <summary>
	/// 购买
	/// </summary>
    public interface IPURCHASEDao
    {
		/// <summary>
        /// 插入购买的单一对象
        /// </summary>
        /// <param name="PURCHASE">购买的单一对象</param>
        /// <returns>当前操作的购买对象</returns>
		PURCHASE Insert(PURCHASE PURCHASE);

		/// <summary>
        /// 批量插入购买的对象数组
        /// </summary>
        /// <param name="collection">购买的对象数组</param>
        void Insert(IList<PURCHASE> collection);
		
		/// <summary>
        /// 批量更新购买的对象数组
        /// </summary>
        /// <param name="collection">购买的对象数组</param>
		void Update(PURCHASE PURCHASE);

		/// <summary>
        /// 批量更新购买的对象数组
        /// </summary>
        /// <param name="collection">购买的对象数组</param>
		void Update(IList<PURCHASE> collection);

		/// <summary>
        /// 删除购买的单一对象
        /// </summary>
        /// <param name="PURCHASE">购买的单一对象(主键数据不能为空)</param>
		void Delete(PURCHASE PURCHASE);

		/// <summary>
        /// 批量删除购买的对象数组
        /// </summary>
        /// <param name="collection">购买的对象数组(主键数据不能为空)</param>
		void Delete(IList< PURCHASE> collection);

		/// <summary>
        /// 查找购买的单一对象
        /// </summary>
        /// <param name="PURCHASE">PURCHASE(主键数据不能为空)</param>
        /// <returns>购买对象</returns>
		PURCHASE FindOnly(PURCHASE PURCHASE);
		
		/// <summary>
        /// 查询购买数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>购买的对象数组</returns>
		IList< PURCHASE> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
		
		/// <summary>
        /// 统计购买数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);
		
		/// <summary>
        /// 购买分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>购买的对象数组</returns>
		IList< PURCHASE> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
	
	}
}
