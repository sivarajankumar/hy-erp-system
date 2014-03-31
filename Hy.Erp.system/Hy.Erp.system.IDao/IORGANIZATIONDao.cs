using System.Data;
using System.Collections.Generic;
using System.Collections;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IDao
{
	/// <summary>
	/// 组织
	/// </summary>
    public interface IORGANIZATIONDao
    {
		/// <summary>
        /// 插入组织的单一对象
        /// </summary>
        /// <param name="ORGANIZATION">组织的单一对象</param>
        /// <returns>当前操作的组织对象</returns>
		ORGANIZATION Insert(ORGANIZATION ORGANIZATION);

		/// <summary>
        /// 批量插入组织的对象数组
        /// </summary>
        /// <param name="collection">组织的对象数组</param>
        void Insert(IList<ORGANIZATION> collection);
		
		/// <summary>
        /// 批量更新组织的对象数组
        /// </summary>
        /// <param name="collection">组织的对象数组</param>
		void Update(ORGANIZATION ORGANIZATION);

		/// <summary>
        /// 批量更新组织的对象数组
        /// </summary>
        /// <param name="collection">组织的对象数组</param>
		void Update(IList<ORGANIZATION> collection);

		/// <summary>
        /// 删除组织的单一对象
        /// </summary>
        /// <param name="ORGANIZATION">组织的单一对象(主键数据不能为空)</param>
		void Delete(ORGANIZATION ORGANIZATION);

		/// <summary>
        /// 批量删除组织的对象数组
        /// </summary>
        /// <param name="collection">组织的对象数组(主键数据不能为空)</param>
		void Delete(IList< ORGANIZATION> collection);

		/// <summary>
        /// 查找组织的单一对象
        /// </summary>
        /// <param name="ORGANIZATION">ORGANIZATION(主键数据不能为空)</param>
        /// <returns>组织对象</returns>
		ORGANIZATION FindOnly(ORGANIZATION ORGANIZATION);
		
		/// <summary>
        /// 查询组织数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>组织的对象数组</returns>
		IList< ORGANIZATION> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
		
		/// <summary>
        /// 统计组织数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);
		
		/// <summary>
        /// 组织分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>组织的对象数组</returns>
		IList< ORGANIZATION> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
	
	}
}
