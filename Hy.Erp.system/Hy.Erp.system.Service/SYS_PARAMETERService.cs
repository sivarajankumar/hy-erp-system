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
    /// 系统参数
    /// </summary>
    [TransactionManager]
	public class SYSPARAMETERService:SupportService, ISYSPARAMETERService
    {
	
        #region 属性
		
		/// <summary>
        /// 系统参数，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(SYSPARAMETERDao))]
		public ISYSPARAMETERDao SYSPARAMETERDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入系统参数的单一对象
        /// </summary>
        /// <param name="SYSPARAMETER">系统参数的单一对象</param>
        /// <returns>当前操作的系统参数对象</returns>
        public SYSPARAMETER Insert(SYSPARAMETER SYSPARAMETER)
        {
			return SYSPARAMETERDao.Insert(SYSPARAMETER);
        }
		
		/// <summary>
        /// 更新系统参数的单一对象
        /// </summary>
        /// <param name="SYSPARAMETER">系统参数的单一对象</param>
        public void Update(SYSPARAMETER SYSPARAMETER)
        {
            SYSPARAMETERDao.Update(SYSPARAMETER);
        }
		
		/// <summary>
        /// 删除系统参数的单一对象
        /// </summary>
        /// <param name="SYSPARAMETER">系统参数的单一对象(主键数据不能为空)</param>
        public void Delete(SYSPARAMETER SYSPARAMETER)
        {
             SYSPARAMETERDao.Delete(SYSPARAMETER);
        }
		
		/// <summary>
        /// 批量删除系统参数的对象数组
        /// </summary>
        /// <param name="collection">系统参数的对象数组(主键数据不能为空)</param>
        public void Delete(IList< SYSPARAMETER >  collection)
        {
            SYSPARAMETERDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找系统参数的单一对象
        /// </summary>
        /// <param name="SYSPARAMETER">SYSPARAMETER(主键数据不能为空)</param>
        /// <returns>系统参数对象</returns>
        public SYSPARAMETER FindOnly(SYSPARAMETER SYSPARAMETER)
        {
            return SYSPARAMETERDao.FindOnly(SYSPARAMETER);
        }
		
		/// <summary>
        /// 查询系统参数数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>系统参数的对象数组</returns>
		public IList< SYSPARAMETER> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  SYSPARAMETERDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计系统参数数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return SYSPARAMETERDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 系统参数分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>系统参数的对象数组</returns>
		public IList< SYSPARAMETER> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return SYSPARAMETERDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
