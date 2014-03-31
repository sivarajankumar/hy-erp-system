using System.Web;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IService
{
	/// <summary>
	/// 物流包装规格
	/// </summary>
    public interface IORDERFROMService
    {
		/// <summary>
        /// 插入物流包装规格的单一对象
        /// </summary>
        /// <param name="ORDERFROM">物流包装规格的单一对象</param>
        /// <returns>当前操作的物流包装规格对象</returns>
  	    ORDERFROM Insert(ORDERFROM ORDERFROM);
		
		/// <summary>
        /// 更新物流包装规格的单一对象
        /// </summary>
        /// <param name="ORDERFROM">物流包装规格的单一对象</param>
		void Update(ORDERFROM ORDERFROM);

		/// <summary>
        /// 删除物流包装规格的单一对象
        /// </summary>
        /// <param name="ORDERFROM">物流包装规格的单一对象(主键数据不能为空)</param>
		void Delete(ORDERFROM ORDERFROM);
		
		/// <summary>
        /// 批量删除物流包装规格的对象数组
        /// </summary>
        /// <param name="collection">物流包装规格的对象数组(主键数据不能为空)</param>
		void Delete(IList< ORDERFROM > collection);

		/// <summary>
        /// 查找物流包装规格的单一对象
        /// </summary>
        /// <param name="ORDERFROM">ORDERFROM(主键数据不能为空)</param>
        /// <returns>物流包装规格对象</returns>
        ORDERFROM FindOnly(ORDERFROM ORDERFROM);
		
		/// <summary>
        /// 查询物流包装规格数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>物流包装规格的对象数组</returns>
		IList< ORDERFROM> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);

		/// <summary>
        /// 统计物流包装规格数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);

		/// <summary>
        /// 物流包装规格分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>物流包装规格的对象数组</returns>
		IList< ORDERFROM> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);    
		
	}
}
