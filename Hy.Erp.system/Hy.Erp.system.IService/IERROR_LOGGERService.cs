using System.Web;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IService
{
	/// <summary>
	/// 错误日志
	/// </summary>
    public interface IERRORLOGGERService
    {
		/// <summary>
        /// 插入错误日志的单一对象
        /// </summary>
        /// <param name="ERRORLOGGER">错误日志的单一对象</param>
        /// <returns>当前操作的错误日志对象</returns>
  	    ERRORLOGGER Insert(ERRORLOGGER ERRORLOGGER);
		
		/// <summary>
        /// 更新错误日志的单一对象
        /// </summary>
        /// <param name="ERRORLOGGER">错误日志的单一对象</param>
		void Update(ERRORLOGGER ERRORLOGGER);

		/// <summary>
        /// 删除错误日志的单一对象
        /// </summary>
        /// <param name="ERRORLOGGER">错误日志的单一对象(主键数据不能为空)</param>
		void Delete(ERRORLOGGER ERRORLOGGER);
		
		/// <summary>
        /// 批量删除错误日志的对象数组
        /// </summary>
        /// <param name="collection">错误日志的对象数组(主键数据不能为空)</param>
		void Delete(IList< ERRORLOGGER > collection);

		/// <summary>
        /// 查找错误日志的单一对象
        /// </summary>
        /// <param name="ERRORLOGGER">ERRORLOGGER(主键数据不能为空)</param>
        /// <returns>错误日志对象</returns>
        ERRORLOGGER FindOnly(ERRORLOGGER ERRORLOGGER);
		
		/// <summary>
        /// 查询错误日志数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>错误日志的对象数组</returns>
		IList< ERRORLOGGER> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);

		/// <summary>
        /// 统计错误日志数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);

		/// <summary>
        /// 错误日志分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>错误日志的对象数组</returns>
		IList< ERRORLOGGER> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);    
		
	}
}
