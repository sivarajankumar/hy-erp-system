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
	/// 错误日志，数据访问
	/// </summary>
	public class ERRORLOGGERDao : MapperDaoSupport, IERRORLOGGERDao
	{
		/// <summary>
        /// 插入错误日志的单一对象
        /// </summary>
        /// <param name="ERRORLOGGER">错误日志的单一对象</param>
        /// <returns>当前操作的错误日志对象</returns>
		public ERRORLOGGER Insert(ERRORLOGGER ERRORLOGGER)
		{
			ERRORLOGGER.ID = Convert.ToInt32(MapperTemplate.Insert(ERRORLOGGER));
			return ERRORLOGGER;
		}
		
		/// <summary>
        /// 批量插入错误日志的对象数组
        /// </summary>
        /// <param name="collection">错误日志的对象数组</param>
        public void Insert(IList<ERRORLOGGER> collection)
        {
            MapperTemplate.InsertBatch< ERRORLOGGER>(collection);
        }
		
		/// <summary>
        /// 更新错误日志的单一对象
        /// </summary>
        /// <param name="ERRORLOGGER">错误日志的单一对象</param>
		public void Update(ERRORLOGGER ERRORLOGGER)
		{
			MapperTemplate.Update(ERRORLOGGER);
		}

		/// <summary>
        /// 批量更新错误日志的对象数组
        /// </summary>
        /// <param name="collection">错误日志的对象数组</param>
		public void Update(IList<ERRORLOGGER> collection)
		{
			MapperTemplate.UpdateBatch< ERRORLOGGER>(collection);
		}

		/// <summary>
        /// 删除错误日志的单一对象
        /// </summary>
        /// <param name="ERRORLOGGER">错误日志的单一对象(主键数据不能为空)</param>
		public void Delete(ERRORLOGGER ERRORLOGGER)
		{
			MapperTemplate.Delete(ERRORLOGGER);
		}

		/// <summary>
        /// 批量删除错误日志的对象数组
        /// </summary>
        /// <param name="collection">错误日志的对象数组(主键数据不能为空)</param>
		public void Delete(IList< ERRORLOGGER> collection)
		{
			MapperTemplate.DeleteBatch< ERRORLOGGER>(collection);
		}

		/// <summary>
        /// 查找错误日志的单一对象
        /// </summary>
        /// <param name="ERRORLOGGER">ERRORLOGGER(主键数据不能为空)</param>
        /// <returns>错误日志对象</returns>
        public ERRORLOGGER FindOnly(ERRORLOGGER ERRORLOGGER)
        {
            return MapperTemplate.FindOnly(ERRORLOGGER);
        }
		
		/// <summary>
        /// 查询错误日志数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>错误日志的对象数组</returns>
		public IList< ERRORLOGGER> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< ERRORLOGGER>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计错误日志数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< ERRORLOGGER>(conditionCollection);
		}

		/// <summary>
        /// 错误日志分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>错误日志的对象数组</returns>
		public IList< ERRORLOGGER> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< ERRORLOGGER>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
