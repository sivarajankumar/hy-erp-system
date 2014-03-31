using System.Web;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IService
{
	/// <summary>
	/// 角色权限关联
	/// </summary>
    public interface IROLERIGHTSService
    {
		/// <summary>
        /// 插入角色权限关联的单一对象
        /// </summary>
        /// <param name="ROLERIGHTS">角色权限关联的单一对象</param>
        /// <returns>当前操作的角色权限关联对象</returns>
  	    ROLERIGHTS Insert(ROLERIGHTS ROLERIGHTS);
		
		/// <summary>
        /// 更新角色权限关联的单一对象
        /// </summary>
        /// <param name="ROLERIGHTS">角色权限关联的单一对象</param>
		void Update(ROLERIGHTS ROLERIGHTS);

		/// <summary>
        /// 删除角色权限关联的单一对象
        /// </summary>
        /// <param name="ROLERIGHTS">角色权限关联的单一对象(主键数据不能为空)</param>
		void Delete(ROLERIGHTS ROLERIGHTS);
		
		/// <summary>
        /// 批量删除角色权限关联的对象数组
        /// </summary>
        /// <param name="collection">角色权限关联的对象数组(主键数据不能为空)</param>
		void Delete(IList< ROLERIGHTS > collection);

		/// <summary>
        /// 查找角色权限关联的单一对象
        /// </summary>
        /// <param name="ROLERIGHTS">ROLERIGHTS(主键数据不能为空)</param>
        /// <returns>角色权限关联对象</returns>
        ROLERIGHTS FindOnly(ROLERIGHTS ROLERIGHTS);
		
		/// <summary>
        /// 查询角色权限关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>角色权限关联的对象数组</returns>
		IList< ROLERIGHTS> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);

		/// <summary>
        /// 统计角色权限关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);

		/// <summary>
        /// 角色权限关联分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>角色权限关联的对象数组</returns>
		IList< ROLERIGHTS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);    
		
	}
}
