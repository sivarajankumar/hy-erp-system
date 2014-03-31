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
    /// 学生
    /// </summary>
    [TransactionManager]
	public class STUDENTSService:SupportService, ISTUDENTSService
    {
	
        #region 属性
		
		/// <summary>
        /// 学生，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(STUDENTSDao))]
		public ISTUDENTSDao STUDENTSDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入学生的单一对象
        /// </summary>
        /// <param name="STUDENTS">学生的单一对象</param>
        /// <returns>当前操作的学生对象</returns>
        public STUDENTS Insert(STUDENTS STUDENTS)
        {
			return STUDENTSDao.Insert(STUDENTS);
        }
		
		/// <summary>
        /// 更新学生的单一对象
        /// </summary>
        /// <param name="STUDENTS">学生的单一对象</param>
        public void Update(STUDENTS STUDENTS)
        {
            STUDENTSDao.Update(STUDENTS);
        }
		
		/// <summary>
        /// 删除学生的单一对象
        /// </summary>
        /// <param name="STUDENTS">学生的单一对象(主键数据不能为空)</param>
        public void Delete(STUDENTS STUDENTS)
        {
             STUDENTSDao.Delete(STUDENTS);
        }
		
		/// <summary>
        /// 批量删除学生的对象数组
        /// </summary>
        /// <param name="collection">学生的对象数组(主键数据不能为空)</param>
        public void Delete(IList< STUDENTS >  collection)
        {
            STUDENTSDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找学生的单一对象
        /// </summary>
        /// <param name="STUDENTS">STUDENTS(主键数据不能为空)</param>
        /// <returns>学生对象</returns>
        public STUDENTS FindOnly(STUDENTS STUDENTS)
        {
            return STUDENTSDao.FindOnly(STUDENTS);
        }
		
		/// <summary>
        /// 查询学生数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>学生的对象数组</returns>
		public IList< STUDENTS> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  STUDENTSDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计学生数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return STUDENTSDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 学生分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>学生的对象数组</returns>
		public IList< STUDENTS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return STUDENTSDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
