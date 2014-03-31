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
	/// 教师，数据访问
	/// </summary>
	public class TEACHERDao : MapperDaoSupport, ITEACHERDao
	{
		/// <summary>
        /// 插入教师的单一对象
        /// </summary>
        /// <param name="TEACHER">教师的单一对象</param>
        /// <returns>当前操作的教师对象</returns>
		public TEACHER Insert(TEACHER TEACHER)
		{
			TEACHER.ID = Convert.ToInt32(MapperTemplate.Insert(TEACHER));
			return TEACHER;
		}
		
		/// <summary>
        /// 批量插入教师的对象数组
        /// </summary>
        /// <param name="collection">教师的对象数组</param>
        public void Insert(IList<TEACHER> collection)
        {
            MapperTemplate.InsertBatch< TEACHER>(collection);
        }
		
		/// <summary>
        /// 更新教师的单一对象
        /// </summary>
        /// <param name="TEACHER">教师的单一对象</param>
		public void Update(TEACHER TEACHER)
		{
			MapperTemplate.Update(TEACHER);
		}

		/// <summary>
        /// 批量更新教师的对象数组
        /// </summary>
        /// <param name="collection">教师的对象数组</param>
		public void Update(IList<TEACHER> collection)
		{
			MapperTemplate.UpdateBatch< TEACHER>(collection);
		}

		/// <summary>
        /// 删除教师的单一对象
        /// </summary>
        /// <param name="TEACHER">教师的单一对象(主键数据不能为空)</param>
		public void Delete(TEACHER TEACHER)
		{
			MapperTemplate.Delete(TEACHER);
		}

		/// <summary>
        /// 批量删除教师的对象数组
        /// </summary>
        /// <param name="collection">教师的对象数组(主键数据不能为空)</param>
		public void Delete(IList< TEACHER> collection)
		{
			MapperTemplate.DeleteBatch< TEACHER>(collection);
		}

		/// <summary>
        /// 查找教师的单一对象
        /// </summary>
        /// <param name="TEACHER">TEACHER(主键数据不能为空)</param>
        /// <returns>教师对象</returns>
        public TEACHER FindOnly(TEACHER TEACHER)
        {
            return MapperTemplate.FindOnly(TEACHER);
        }
		
		/// <summary>
        /// 查询教师数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>教师的对象数组</returns>
		public IList< TEACHER> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< TEACHER>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计教师数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< TEACHER>(conditionCollection);
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
		public IList< TEACHER> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< TEACHER>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
