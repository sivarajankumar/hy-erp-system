using System.Web;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IService
{
	/// <summary>
	/// 数据细项
	/// </summary>
    public interface IDATADICTIONARYService
    {
		/// <summary>
        /// 插入数据细项的单一对象
        /// </summary>
        /// <param name="DATADICTIONARY">数据细项的单一对象</param>
        /// <returns>当前操作的数据细项对象</returns>
  	    DATADICTIONARY Insert(DATADICTIONARY DATADICTIONARY);
		
		/// <summary>
        /// 更新数据细项的单一对象
        /// </summary>
        /// <param name="DATADICTIONARY">数据细项的单一对象</param>
		void Update(DATADICTIONARY DATADICTIONARY);

		/// <summary>
        /// 删除数据细项的单一对象
        /// </summary>
        /// <param name="DATADICTIONARY">数据细项的单一对象(主键数据不能为空)</param>
		void Delete(DATADICTIONARY DATADICTIONARY);
		
		/// <summary>
        /// 批量删除数据细项的对象数组
        /// </summary>
        /// <param name="collection">数据细项的对象数组(主键数据不能为空)</param>
		void Delete(IList< DATADICTIONARY > collection);

		/// <summary>
        /// 查找数据细项的单一对象
        /// </summary>
        /// <param name="DATADICTIONARY">DATADICTIONARY(主键数据不能为空)</param>
        /// <returns>数据细项对象</returns>
        DATADICTIONARY FindOnly(DATADICTIONARY DATADICTIONARY);
		
		/// <summary>
        /// 查询数据细项数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>数据细项的对象数组</returns>
		IList< DATADICTIONARY> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);

		/// <summary>
        /// 统计数据细项数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);

		/// <summary>
        /// 数据细项分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>数据细项的对象数组</returns>
		IList< DATADICTIONARY> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);    
		
	}
}
