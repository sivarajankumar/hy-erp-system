using System.Data;
using System.Collections.Generic;
using System.Collections;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IDao
{
	/// <summary>
	/// 用户
	/// </summary>
    public interface IUSERDao
    {
		/// <summary>
        /// 插入用户的单一对象
        /// </summary>
        /// <param name="USER">用户的单一对象</param>
        /// <returns>当前操作的用户对象</returns>
		USER Insert(USER USER);

		/// <summary>
        /// 批量插入用户的对象数组
        /// </summary>
        /// <param name="collection">用户的对象数组</param>
        void Insert(IList<USER> collection);
		
		/// <summary>
        /// 批量更新用户的对象数组
        /// </summary>
        /// <param name="collection">用户的对象数组</param>
		void Update(USER USER);

		/// <summary>
        /// 批量更新用户的对象数组
        /// </summary>
        /// <param name="collection">用户的对象数组</param>
		void Update(IList<USER> collection);

		/// <summary>
        /// 删除用户的单一对象
        /// </summary>
        /// <param name="USER">用户的单一对象(主键数据不能为空)</param>
		void Delete(USER USER);

		/// <summary>
        /// 批量删除用户的对象数组
        /// </summary>
        /// <param name="collection">用户的对象数组(主键数据不能为空)</param>
		void Delete(IList< USER> collection);

		/// <summary>
        /// 查找用户的单一对象
        /// </summary>
        /// <param name="USER">USER(主键数据不能为空)</param>
        /// <returns>用户对象</returns>
		USER FindOnly(USER USER);
		
		/// <summary>
        /// 查询用户数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>用户的对象数组</returns>
		IList< USER> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
		
		/// <summary>
        /// 统计用户数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);
		
		/// <summary>
        /// 用户分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>用户的对象数组</returns>
		IList< USER> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
	
	}
}
