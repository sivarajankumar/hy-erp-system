using System.Data;
using System.Collections.Generic;
using System.Collections;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IDao
{
	/// <summary>
	/// 权限
	/// </summary>
    public interface IRIGHTSDao
    {
		/// <summary>
        /// 插入权限的单一对象
        /// </summary>
        /// <param name="RIGHTS">权限的单一对象</param>
        /// <returns>当前操作的权限对象</returns>
		RIGHTS Insert(RIGHTS RIGHTS);

		/// <summary>
        /// 批量插入权限的对象数组
        /// </summary>
        /// <param name="collection">权限的对象数组</param>
        void Insert(IList<RIGHTS> collection);
		
		/// <summary>
        /// 批量更新权限的对象数组
        /// </summary>
        /// <param name="collection">权限的对象数组</param>
		void Update(RIGHTS RIGHTS);

		/// <summary>
        /// 批量更新权限的对象数组
        /// </summary>
        /// <param name="collection">权限的对象数组</param>
		void Update(IList<RIGHTS> collection);

		/// <summary>
        /// 删除权限的单一对象
        /// </summary>
        /// <param name="RIGHTS">权限的单一对象(主键数据不能为空)</param>
		void Delete(RIGHTS RIGHTS);

		/// <summary>
        /// 批量删除权限的对象数组
        /// </summary>
        /// <param name="collection">权限的对象数组(主键数据不能为空)</param>
		void Delete(IList< RIGHTS> collection);

		/// <summary>
        /// 查找权限的单一对象
        /// </summary>
        /// <param name="RIGHTS">RIGHTS(主键数据不能为空)</param>
        /// <returns>权限对象</returns>
		RIGHTS FindOnly(RIGHTS RIGHTS);
		
		/// <summary>
        /// 查询权限数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>权限的对象数组</returns>
		IList< RIGHTS> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
		
		/// <summary>
        /// 统计权限数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);
		
		/// <summary>
        /// 权限分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>权限的对象数组</returns>
		IList< RIGHTS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
	
	}
}
