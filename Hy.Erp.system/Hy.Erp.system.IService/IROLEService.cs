using System.Web;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IService
{
	/// <summary>
	/// 角色
	/// </summary>
    public interface IROLEService
    {
		/// <summary>
        /// 插入角色的单一对象
        /// </summary>
        /// <param name="ROLE">角色的单一对象</param>
        /// <returns>当前操作的角色对象</returns>
  	    ROLE Insert(ROLE ROLE);
		
		/// <summary>
        /// 更新角色的单一对象
        /// </summary>
        /// <param name="ROLE">角色的单一对象</param>
		void Update(ROLE ROLE);

		/// <summary>
        /// 删除角色的单一对象
        /// </summary>
        /// <param name="ROLE">角色的单一对象(主键数据不能为空)</param>
		void Delete(ROLE ROLE);
		
		/// <summary>
        /// 批量删除角色的对象数组
        /// </summary>
        /// <param name="collection">角色的对象数组(主键数据不能为空)</param>
		void Delete(IList< ROLE > collection);

		/// <summary>
        /// 查找角色的单一对象
        /// </summary>
        /// <param name="ROLE">ROLE(主键数据不能为空)</param>
        /// <returns>角色对象</returns>
        ROLE FindOnly(ROLE ROLE);
		
		/// <summary>
        /// 查询角色数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>角色的对象数组</returns>
		IList< ROLE> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);

		/// <summary>
        /// 统计角色数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);

		/// <summary>
        /// 角色分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>角色的对象数组</returns>
		IList< ROLE> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);    
		
	}
}
