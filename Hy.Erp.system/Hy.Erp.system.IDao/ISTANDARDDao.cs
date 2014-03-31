using System.Data;
using System.Collections.Generic;
using System.Collections;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IDao
{
	/// <summary>
	/// 包装规格
	/// </summary>
    public interface ISTANDARDDao
    {
		/// <summary>
        /// 插入包装规格的单一对象
        /// </summary>
        /// <param name="STANDARD">包装规格的单一对象</param>
        /// <returns>当前操作的包装规格对象</returns>
		STANDARD Insert(STANDARD STANDARD);

		/// <summary>
        /// 批量插入包装规格的对象数组
        /// </summary>
        /// <param name="collection">包装规格的对象数组</param>
        void Insert(IList<STANDARD> collection);
		
		/// <summary>
        /// 批量更新包装规格的对象数组
        /// </summary>
        /// <param name="collection">包装规格的对象数组</param>
		void Update(STANDARD STANDARD);

		/// <summary>
        /// 批量更新包装规格的对象数组
        /// </summary>
        /// <param name="collection">包装规格的对象数组</param>
		void Update(IList<STANDARD> collection);

		/// <summary>
        /// 删除包装规格的单一对象
        /// </summary>
        /// <param name="STANDARD">包装规格的单一对象(主键数据不能为空)</param>
		void Delete(STANDARD STANDARD);

		/// <summary>
        /// 批量删除包装规格的对象数组
        /// </summary>
        /// <param name="collection">包装规格的对象数组(主键数据不能为空)</param>
		void Delete(IList< STANDARD> collection);

		/// <summary>
        /// 查找包装规格的单一对象
        /// </summary>
        /// <param name="STANDARD">STANDARD(主键数据不能为空)</param>
        /// <returns>包装规格对象</returns>
		STANDARD FindOnly(STANDARD STANDARD);
		
		/// <summary>
        /// 查询包装规格数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>包装规格的对象数组</returns>
		IList< STANDARD> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
		
		/// <summary>
        /// 统计包装规格数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);
		
		/// <summary>
        /// 包装规格分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>包装规格的对象数组</returns>
		IList< STANDARD> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
	
	}
}
