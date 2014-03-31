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
    /// 班级
    /// </summary>
    [TransactionManager]
	public class DEPTService:SupportService, IDEPTService
    {
	
        #region 属性
		
		/// <summary>
        /// 班级，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(DEPTDao))]
		public IDEPTDao DEPTDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入班级的单一对象
        /// </summary>
        /// <param name="DEPT">班级的单一对象</param>
        /// <returns>当前操作的班级对象</returns>
        public DEPT Insert(DEPT DEPT)
        {
			return DEPTDao.Insert(DEPT);
        }
		
		/// <summary>
        /// 更新班级的单一对象
        /// </summary>
        /// <param name="DEPT">班级的单一对象</param>
        public void Update(DEPT DEPT)
        {
            DEPTDao.Update(DEPT);
        }
		
		/// <summary>
        /// 删除班级的单一对象
        /// </summary>
        /// <param name="DEPT">班级的单一对象(主键数据不能为空)</param>
        public void Delete(DEPT DEPT)
        {
             DEPTDao.Delete(DEPT);
        }
		
		/// <summary>
        /// 批量删除班级的对象数组
        /// </summary>
        /// <param name="collection">班级的对象数组(主键数据不能为空)</param>
        public void Delete(IList< DEPT >  collection)
        {
            DEPTDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找班级的单一对象
        /// </summary>
        /// <param name="DEPT">DEPT(主键数据不能为空)</param>
        /// <returns>班级对象</returns>
        public DEPT FindOnly(DEPT DEPT)
        {
            return DEPTDao.FindOnly(DEPT);
        }
		
		/// <summary>
        /// 查询班级数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>班级的对象数组</returns>
		public IList< DEPT> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  DEPTDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计班级数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return DEPTDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 班级分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>班级的对象数组</returns>
		public IList< DEPT> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return DEPTDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
