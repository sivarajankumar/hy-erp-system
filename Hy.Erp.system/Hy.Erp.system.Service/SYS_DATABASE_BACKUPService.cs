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
    /// 数据库备份
    /// </summary>
    [TransactionManager]
	public class SYSDATABASEBACKUPService:SupportService, ISYSDATABASEBACKUPService
    {
	
        #region 属性
		
		/// <summary>
        /// 数据库备份，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(SYSDATABASEBACKUPDao))]
		public ISYSDATABASEBACKUPDao SYSDATABASEBACKUPDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入数据库备份的单一对象
        /// </summary>
        /// <param name="SYSDATABASEBACKUP">数据库备份的单一对象</param>
        /// <returns>当前操作的数据库备份对象</returns>
        public SYSDATABASEBACKUP Insert(SYSDATABASEBACKUP SYSDATABASEBACKUP)
        {
			return SYSDATABASEBACKUPDao.Insert(SYSDATABASEBACKUP);
        }
		
		/// <summary>
        /// 更新数据库备份的单一对象
        /// </summary>
        /// <param name="SYSDATABASEBACKUP">数据库备份的单一对象</param>
        public void Update(SYSDATABASEBACKUP SYSDATABASEBACKUP)
        {
            SYSDATABASEBACKUPDao.Update(SYSDATABASEBACKUP);
        }
		
		/// <summary>
        /// 删除数据库备份的单一对象
        /// </summary>
        /// <param name="SYSDATABASEBACKUP">数据库备份的单一对象(主键数据不能为空)</param>
        public void Delete(SYSDATABASEBACKUP SYSDATABASEBACKUP)
        {
             SYSDATABASEBACKUPDao.Delete(SYSDATABASEBACKUP);
        }
		
		/// <summary>
        /// 批量删除数据库备份的对象数组
        /// </summary>
        /// <param name="collection">数据库备份的对象数组(主键数据不能为空)</param>
        public void Delete(IList< SYSDATABASEBACKUP >  collection)
        {
            SYSDATABASEBACKUPDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找数据库备份的单一对象
        /// </summary>
        /// <param name="SYSDATABASEBACKUP">SYSDATABASEBACKUP(主键数据不能为空)</param>
        /// <returns>数据库备份对象</returns>
        public SYSDATABASEBACKUP FindOnly(SYSDATABASEBACKUP SYSDATABASEBACKUP)
        {
            return SYSDATABASEBACKUPDao.FindOnly(SYSDATABASEBACKUP);
        }
		
		/// <summary>
        /// 查询数据库备份数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>数据库备份的对象数组</returns>
		public IList< SYSDATABASEBACKUP> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  SYSDATABASEBACKUPDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计数据库备份数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return SYSDATABASEBACKUPDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 数据库备份分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>数据库备份的对象数组</returns>
		public IList< SYSDATABASEBACKUP> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return SYSDATABASEBACKUPDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
