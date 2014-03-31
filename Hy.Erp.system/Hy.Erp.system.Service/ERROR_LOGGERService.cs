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
    /// 错误日志
    /// </summary>
    [TransactionManager]
	public class ERRORLOGGERService:SupportService, IERRORLOGGERService
    {
	
        #region 属性
		
		/// <summary>
        /// 错误日志，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(ERRORLOGGERDao))]
		public IERRORLOGGERDao ERRORLOGGERDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入错误日志的单一对象
        /// </summary>
        /// <param name="ERRORLOGGER">错误日志的单一对象</param>
        /// <returns>当前操作的错误日志对象</returns>
        public ERRORLOGGER Insert(ERRORLOGGER ERRORLOGGER)
        {
			return ERRORLOGGERDao.Insert(ERRORLOGGER);
        }
		
		/// <summary>
        /// 更新错误日志的单一对象
        /// </summary>
        /// <param name="ERRORLOGGER">错误日志的单一对象</param>
        public void Update(ERRORLOGGER ERRORLOGGER)
        {
            ERRORLOGGERDao.Update(ERRORLOGGER);
        }
		
		/// <summary>
        /// 删除错误日志的单一对象
        /// </summary>
        /// <param name="ERRORLOGGER">错误日志的单一对象(主键数据不能为空)</param>
        public void Delete(ERRORLOGGER ERRORLOGGER)
        {
             ERRORLOGGERDao.Delete(ERRORLOGGER);
        }
		
		/// <summary>
        /// 批量删除错误日志的对象数组
        /// </summary>
        /// <param name="collection">错误日志的对象数组(主键数据不能为空)</param>
        public void Delete(IList< ERRORLOGGER >  collection)
        {
            ERRORLOGGERDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找错误日志的单一对象
        /// </summary>
        /// <param name="ERRORLOGGER">ERRORLOGGER(主键数据不能为空)</param>
        /// <returns>错误日志对象</returns>
        public ERRORLOGGER FindOnly(ERRORLOGGER ERRORLOGGER)
        {
            return ERRORLOGGERDao.FindOnly(ERRORLOGGER);
        }
		
		/// <summary>
        /// 查询错误日志数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>错误日志的对象数组</returns>
		public IList< ERRORLOGGER> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  ERRORLOGGERDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计错误日志数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return ERRORLOGGERDao.Count(conditionCollection);
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
		public IList< ERRORLOGGER> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return ERRORLOGGERDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
