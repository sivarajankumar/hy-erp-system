using System.Web;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IService
{
	/// <summary>
	/// 团购通知单
	/// </summary>
    public interface INOTICEService
    {
		/// <summary>
        /// 插入团购通知单的单一对象
        /// </summary>
        /// <param name="NOTICE">团购通知单的单一对象</param>
        /// <returns>当前操作的团购通知单对象</returns>
  	    NOTICE Insert(NOTICE NOTICE);
		
		/// <summary>
        /// 更新团购通知单的单一对象
        /// </summary>
        /// <param name="NOTICE">团购通知单的单一对象</param>
		void Update(NOTICE NOTICE);

		/// <summary>
        /// 删除团购通知单的单一对象
        /// </summary>
        /// <param name="NOTICE">团购通知单的单一对象(主键数据不能为空)</param>
		void Delete(NOTICE NOTICE);
		
		/// <summary>
        /// 批量删除团购通知单的对象数组
        /// </summary>
        /// <param name="collection">团购通知单的对象数组(主键数据不能为空)</param>
		void Delete(IList< NOTICE > collection);

		/// <summary>
        /// 查找团购通知单的单一对象
        /// </summary>
        /// <param name="NOTICE">NOTICE(主键数据不能为空)</param>
        /// <returns>团购通知单对象</returns>
        NOTICE FindOnly(NOTICE NOTICE);
		
		/// <summary>
        /// 查询团购通知单数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>团购通知单的对象数组</returns>
		IList< NOTICE> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);

		/// <summary>
        /// 统计团购通知单数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);

		/// <summary>
        /// 团购通知单分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>团购通知单的对象数组</returns>
		IList< NOTICE> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);    
		
	}
}
