using System.Web;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IService
{
	/// <summary>
	/// 数据种类
	/// </summary>
    public interface IDATATYPEService
    {
		/// <summary>
        /// 插入数据种类的单一对象
        /// </summary>
        /// <param name="DATATYPE">数据种类的单一对象</param>
        /// <returns>当前操作的数据种类对象</returns>
  	    DATATYPE Insert(DATATYPE DATATYPE);
		
		/// <summary>
        /// 更新数据种类的单一对象
        /// </summary>
        /// <param name="DATATYPE">数据种类的单一对象</param>
		void Update(DATATYPE DATATYPE);

		/// <summary>
        /// 删除数据种类的单一对象
        /// </summary>
        /// <param name="DATATYPE">数据种类的单一对象(主键数据不能为空)</param>
		void Delete(DATATYPE DATATYPE);
		
		/// <summary>
        /// 批量删除数据种类的对象数组
        /// </summary>
        /// <param name="collection">数据种类的对象数组(主键数据不能为空)</param>
		void Delete(IList< DATATYPE > collection);

		/// <summary>
        /// 查找数据种类的单一对象
        /// </summary>
        /// <param name="DATATYPE">DATATYPE(主键数据不能为空)</param>
        /// <returns>数据种类对象</returns>
        DATATYPE FindOnly(DATATYPE DATATYPE);
		
		/// <summary>
        /// 查询数据种类数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>数据种类的对象数组</returns>
		IList< DATATYPE> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);

		/// <summary>
        /// 统计数据种类数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);

		/// <summary>
        /// 数据种类分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>数据种类的对象数组</returns>
		IList< DATATYPE> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);    
		
	}
}
