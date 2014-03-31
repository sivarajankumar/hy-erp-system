using System.Web;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IService
{
	/// <summary>
	/// 用户角色关联
	/// </summary>
    public interface IUSERROLEService
    {
		/// <summary>
        /// 插入用户角色关联的单一对象
        /// </summary>
        /// <param name="USERROLE">用户角色关联的单一对象</param>
        /// <returns>当前操作的用户角色关联对象</returns>
  	    USERROLE Insert(USERROLE USERROLE);
		
		/// <summary>
        /// 更新用户角色关联的单一对象
        /// </summary>
        /// <param name="USERROLE">用户角色关联的单一对象</param>
		void Update(USERROLE USERROLE);

		/// <summary>
        /// 删除用户角色关联的单一对象
        /// </summary>
        /// <param name="USERROLE">用户角色关联的单一对象(主键数据不能为空)</param>
		void Delete(USERROLE USERROLE);
		
		/// <summary>
        /// 批量删除用户角色关联的对象数组
        /// </summary>
        /// <param name="collection">用户角色关联的对象数组(主键数据不能为空)</param>
		void Delete(IList< USERROLE > collection);

		/// <summary>
        /// 查找用户角色关联的单一对象
        /// </summary>
        /// <param name="USERROLE">USERROLE(主键数据不能为空)</param>
        /// <returns>用户角色关联对象</returns>
        USERROLE FindOnly(USERROLE USERROLE);
		
		/// <summary>
        /// 查询用户角色关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>用户角色关联的对象数组</returns>
		IList< USERROLE> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);

		/// <summary>
        /// 统计用户角色关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);

		/// <summary>
        /// 用户角色关联分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>用户角色关联的对象数组</returns>
		IList< USERROLE> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);    
		
	}
}
