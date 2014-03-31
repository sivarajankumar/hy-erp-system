﻿using System.Web;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IService
{
	/// <summary>
	/// 系统访问日志
	/// </summary>
    public interface ISYSLOGGERService
    {
		/// <summary>
        /// 插入系统访问日志的单一对象
        /// </summary>
        /// <param name="SYSLOGGER">系统访问日志的单一对象</param>
        /// <returns>当前操作的系统访问日志对象</returns>
  	    SYSLOGGER Insert(SYSLOGGER SYSLOGGER);
		
		/// <summary>
        /// 更新系统访问日志的单一对象
        /// </summary>
        /// <param name="SYSLOGGER">系统访问日志的单一对象</param>
		void Update(SYSLOGGER SYSLOGGER);

		/// <summary>
        /// 删除系统访问日志的单一对象
        /// </summary>
        /// <param name="SYSLOGGER">系统访问日志的单一对象(主键数据不能为空)</param>
		void Delete(SYSLOGGER SYSLOGGER);
		
		/// <summary>
        /// 批量删除系统访问日志的对象数组
        /// </summary>
        /// <param name="collection">系统访问日志的对象数组(主键数据不能为空)</param>
		void Delete(IList< SYSLOGGER > collection);

		/// <summary>
        /// 查找系统访问日志的单一对象
        /// </summary>
        /// <param name="SYSLOGGER">SYSLOGGER(主键数据不能为空)</param>
        /// <returns>系统访问日志对象</returns>
        SYSLOGGER FindOnly(SYSLOGGER SYSLOGGER);
		
		/// <summary>
        /// 查询系统访问日志数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>系统访问日志的对象数组</returns>
		IList< SYSLOGGER> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);

		/// <summary>
        /// 统计系统访问日志数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);

		/// <summary>
        /// 系统访问日志分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>系统访问日志的对象数组</returns>
		IList< SYSLOGGER> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);    
		
	}
}
