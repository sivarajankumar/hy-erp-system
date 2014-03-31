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
	/// 学生，数据访问
	/// </summary>
	public class STUDENTSDao : MapperDaoSupport, ISTUDENTSDao
	{
		/// <summary>
        /// 插入学生的单一对象
        /// </summary>
        /// <param name="STUDENTS">学生的单一对象</param>
        /// <returns>当前操作的学生对象</returns>
		public STUDENTS Insert(STUDENTS STUDENTS)
		{
			STUDENTS.ID = Convert.ToInt32(MapperTemplate.Insert(STUDENTS));
			return STUDENTS;
		}
		
		/// <summary>
        /// 批量插入学生的对象数组
        /// </summary>
        /// <param name="collection">学生的对象数组</param>
        public void Insert(IList<STUDENTS> collection)
        {
            MapperTemplate.InsertBatch< STUDENTS>(collection);
        }
		
		/// <summary>
        /// 更新学生的单一对象
        /// </summary>
        /// <param name="STUDENTS">学生的单一对象</param>
		public void Update(STUDENTS STUDENTS)
		{
			MapperTemplate.Update(STUDENTS);
		}

		/// <summary>
        /// 批量更新学生的对象数组
        /// </summary>
        /// <param name="collection">学生的对象数组</param>
		public void Update(IList<STUDENTS> collection)
		{
			MapperTemplate.UpdateBatch< STUDENTS>(collection);
		}

		/// <summary>
        /// 删除学生的单一对象
        /// </summary>
        /// <param name="STUDENTS">学生的单一对象(主键数据不能为空)</param>
		public void Delete(STUDENTS STUDENTS)
		{
			MapperTemplate.Delete(STUDENTS);
		}

		/// <summary>
        /// 批量删除学生的对象数组
        /// </summary>
        /// <param name="collection">学生的对象数组(主键数据不能为空)</param>
		public void Delete(IList< STUDENTS> collection)
		{
			MapperTemplate.DeleteBatch< STUDENTS>(collection);
		}

		/// <summary>
        /// 查找学生的单一对象
        /// </summary>
        /// <param name="STUDENTS">STUDENTS(主键数据不能为空)</param>
        /// <returns>学生对象</returns>
        public STUDENTS FindOnly(STUDENTS STUDENTS)
        {
            return MapperTemplate.FindOnly(STUDENTS);
        }
		
		/// <summary>
        /// 查询学生数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>学生的对象数组</returns>
		public IList< STUDENTS> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< STUDENTS>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计学生数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< STUDENTS>(conditionCollection);
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
		public IList< STUDENTS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< STUDENTS>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
