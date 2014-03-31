using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using HP.Mapper.Core.Support;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;
using Hy.Erp.system.IDao;

namespace Hy.Erp.system.Dao
{
	/// <summary>
	/// 系统访问日志，数据访问
	/// </summary>
	public class SYSLOGGERDao : MapperDaoSupport, ISYSLOGGERDao
	{
		/// <summary>
        /// 插入系统访问日志的单一对象
        /// </summary>
        /// <param name="SYSLOGGER">系统访问日志的单一对象</param>
        /// <returns>当前操作的系统访问日志对象</returns>
		public SYSLOGGER Insert(SYSLOGGER SYSLOGGER)
		{
			SYSLOGGER.ID = Convert.ToInt32(MapperTemplate.Insert(SYSLOGGER));
			return SYSLOGGER;
		}
		
		/// <summary>
        /// 批量插入系统访问日志的对象数组
        /// </summary>
        /// <param name="collection">系统访问日志的对象数组</param>
        public void Insert(IList<SYSLOGGER> collection)
        {
            MapperTemplate.InsertBatch< SYSLOGGER>(collection);
        }
		
		/// <summary>
        /// 更新系统访问日志的单一对象
        /// </summary>
        /// <param name="SYSLOGGER">系统访问日志的单一对象</param>
		public void Update(SYSLOGGER SYSLOGGER)
		{
			MapperTemplate.Update(SYSLOGGER);
		}

		/// <summary>
        /// 批量更新系统访问日志的对象数组
        /// </summary>
        /// <param name="collection">系统访问日志的对象数组</param>
		public void Update(IList<SYSLOGGER> collection)
		{
			MapperTemplate.UpdateBatch< SYSLOGGER>(collection);
		}

		/// <summary>
        /// 删除系统访问日志的单一对象
        /// </summary>
        /// <param name="SYSLOGGER">系统访问日志的单一对象(主键数据不能为空)</param>
		public void Delete(SYSLOGGER SYSLOGGER)
		{
			MapperTemplate.Delete(SYSLOGGER);
		}

		/// <summary>
        /// 批量删除系统访问日志的对象数组
        /// </summary>
        /// <param name="collection">系统访问日志的对象数组(主键数据不能为空)</param>
		public void Delete(IList< SYSLOGGER> collection)
		{
			MapperTemplate.DeleteBatch< SYSLOGGER>(collection);
		}

		/// <summary>
        /// 查找系统访问日志的单一对象
        /// </summary>
        /// <param name="SYSLOGGER">SYSLOGGER(主键数据不能为空)</param>
        /// <returns>系统访问日志对象</returns>
        public SYSLOGGER FindOnly(SYSLOGGER SYSLOGGER)
        {
            return MapperTemplate.FindOnly(SYSLOGGER);
        }
		
		/// <summary>
        /// 查询系统访问日志数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>系统访问日志的对象数组</returns>
		public IList< SYSLOGGER> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< SYSLOGGER>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计系统访问日志数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< SYSLOGGER>(conditionCollection);
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
		public IList< SYSLOGGER> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< SYSLOGGER>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
