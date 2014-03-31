using System;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using HP.Mapper.Service;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;
using Hy.Erp.system.Service.Support;
using Hy.Erp.system.IService;
using Hy.Erp.system.IDao;
using Hy.Erp.system.Dao;
using Hy.Erp.system.Common;

namespace Hy.Erp.system.Service
{
	 /// <summary>
    /// 系统访问日志
    /// </summary>
    [TransactionManager]
	public class SYSLOGGERService:SupportService, ISYSLOGGERService
    {
	
        #region 属性
		
		/// <summary>
        /// 系统访问日志，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(SYSLOGGERDao))]
		public ISYSLOGGERDao SYSLOGGERDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入系统访问日志的单一对象
        /// </summary>
        /// <param name="SYSLOGGER">系统访问日志的单一对象</param>
        /// <returns>当前操作的系统访问日志对象</returns>
        public SYSLOGGER Insert(SYSLOGGER SYSLOGGER)
        {
			return SYSLOGGERDao.Insert(SYSLOGGER);
        }
		
		/// <summary>
        /// 更新系统访问日志的单一对象
        /// </summary>
        /// <param name="SYSLOGGER">系统访问日志的单一对象</param>
        public void Update(SYSLOGGER SYSLOGGER)
        {
            SYSLOGGERDao.Update(SYSLOGGER);
        }
		
		/// <summary>
        /// 删除系统访问日志的单一对象
        /// </summary>
        /// <param name="SYSLOGGER">系统访问日志的单一对象(主键数据不能为空)</param>
        public void Delete(SYSLOGGER SYSLOGGER)
        {
             SYSLOGGERDao.Delete(SYSLOGGER);
        }
		
		/// <summary>
        /// 批量删除系统访问日志的对象数组
        /// </summary>
        /// <param name="collection">系统访问日志的对象数组(主键数据不能为空)</param>
        public void Delete(IList< SYSLOGGER >  collection)
        {
            SYSLOGGERDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找系统访问日志的单一对象
        /// </summary>
        /// <param name="SYSLOGGER">SYSLOGGER(主键数据不能为空)</param>
        /// <returns>系统访问日志对象</returns>
        public SYSLOGGER FindOnly(SYSLOGGER SYSLOGGER)
        {
            return SYSLOGGERDao.FindOnly(SYSLOGGER);
        }
		
		/// <summary>
        /// 查询系统访问日志数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>系统访问日志的对象数组</returns>
		public IList< SYSLOGGER> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  SYSLOGGERDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计系统访问日志数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return SYSLOGGERDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 系统访问日志分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>系统访问日志的对象数组</returns>
		public IList< SYSLOGGER> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return SYSLOGGERDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
