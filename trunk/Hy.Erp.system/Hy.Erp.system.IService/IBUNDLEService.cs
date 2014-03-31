using System.Web;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IService
{
	/// <summary>
	/// 购书捆绑包
	/// </summary>
    public interface IBUNDLEService
    {
		/// <summary>
        /// 插入购书捆绑包的单一对象
        /// </summary>
        /// <param name="BUNDLE">购书捆绑包的单一对象</param>
        /// <returns>当前操作的购书捆绑包对象</returns>
  	    BUNDLE Insert(BUNDLE BUNDLE);
		
		/// <summary>
        /// 更新购书捆绑包的单一对象
        /// </summary>
        /// <param name="BUNDLE">购书捆绑包的单一对象</param>
		void Update(BUNDLE BUNDLE);

		/// <summary>
        /// 删除购书捆绑包的单一对象
        /// </summary>
        /// <param name="BUNDLE">购书捆绑包的单一对象(主键数据不能为空)</param>
		void Delete(BUNDLE BUNDLE);
		
		/// <summary>
        /// 批量删除购书捆绑包的对象数组
        /// </summary>
        /// <param name="collection">购书捆绑包的对象数组(主键数据不能为空)</param>
		void Delete(IList< BUNDLE > collection);

		/// <summary>
        /// 查找购书捆绑包的单一对象
        /// </summary>
        /// <param name="BUNDLE">BUNDLE(主键数据不能为空)</param>
        /// <returns>购书捆绑包对象</returns>
        BUNDLE FindOnly(BUNDLE BUNDLE);
		
		/// <summary>
        /// 查询购书捆绑包数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>购书捆绑包的对象数组</returns>
		IList< BUNDLE> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);

		/// <summary>
        /// 统计购书捆绑包数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);

		/// <summary>
        /// 购书捆绑包分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>购书捆绑包的对象数组</returns>
		IList< BUNDLE> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);    
		
	}
}
