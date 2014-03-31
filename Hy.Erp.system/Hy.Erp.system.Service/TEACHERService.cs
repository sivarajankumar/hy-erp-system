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
    /// 教师
    /// </summary>
    [TransactionManager]
	public class TEACHERService:SupportService, ITEACHERService
    {
	
        #region 属性
		
		/// <summary>
        /// 教师，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(TEACHERDao))]
		public ITEACHERDao TEACHERDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入教师的单一对象
        /// </summary>
        /// <param name="TEACHER">教师的单一对象</param>
        /// <returns>当前操作的教师对象</returns>
        public TEACHER Insert(TEACHER TEACHER)
        {
			return TEACHERDao.Insert(TEACHER);
        }
		
		/// <summary>
        /// 更新教师的单一对象
        /// </summary>
        /// <param name="TEACHER">教师的单一对象</param>
        public void Update(TEACHER TEACHER)
        {
            TEACHERDao.Update(TEACHER);
        }
		
		/// <summary>
        /// 删除教师的单一对象
        /// </summary>
        /// <param name="TEACHER">教师的单一对象(主键数据不能为空)</param>
        public void Delete(TEACHER TEACHER)
        {
             TEACHERDao.Delete(TEACHER);
        }
		
		/// <summary>
        /// 批量删除教师的对象数组
        /// </summary>
        /// <param name="collection">教师的对象数组(主键数据不能为空)</param>
        public void Delete(IList< TEACHER >  collection)
        {
            TEACHERDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找教师的单一对象
        /// </summary>
        /// <param name="TEACHER">TEACHER(主键数据不能为空)</param>
        /// <returns>教师对象</returns>
        public TEACHER FindOnly(TEACHER TEACHER)
        {
            return TEACHERDao.FindOnly(TEACHER);
        }
		
		/// <summary>
        /// 查询教师数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>教师的对象数组</returns>
		public IList< TEACHER> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  TEACHERDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计教师数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return TEACHERDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 教师分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>教师的对象数组</returns>
		public IList< TEACHER> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return TEACHERDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
