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
	/// 班级，数据访问
	/// </summary>
	public class DEPTDao : MapperDaoSupport, IDEPTDao
	{
		/// <summary>
        /// 插入班级的单一对象
        /// </summary>
        /// <param name="DEPT">班级的单一对象</param>
        /// <returns>当前操作的班级对象</returns>
		public DEPT Insert(DEPT DEPT)
		{
			DEPT.ID = Convert.ToInt32(MapperTemplate.Insert(DEPT));
			return DEPT;
		}
		
		/// <summary>
        /// 批量插入班级的对象数组
        /// </summary>
        /// <param name="collection">班级的对象数组</param>
        public void Insert(IList<DEPT> collection)
        {
            MapperTemplate.InsertBatch< DEPT>(collection);
        }
		
		/// <summary>
        /// 更新班级的单一对象
        /// </summary>
        /// <param name="DEPT">班级的单一对象</param>
		public void Update(DEPT DEPT)
		{
			MapperTemplate.Update(DEPT);
		}

		/// <summary>
        /// 批量更新班级的对象数组
        /// </summary>
        /// <param name="collection">班级的对象数组</param>
		public void Update(IList<DEPT> collection)
		{
			MapperTemplate.UpdateBatch< DEPT>(collection);
		}

		/// <summary>
        /// 删除班级的单一对象
        /// </summary>
        /// <param name="DEPT">班级的单一对象(主键数据不能为空)</param>
		public void Delete(DEPT DEPT)
		{
			MapperTemplate.Delete(DEPT);
		}

		/// <summary>
        /// 批量删除班级的对象数组
        /// </summary>
        /// <param name="collection">班级的对象数组(主键数据不能为空)</param>
		public void Delete(IList< DEPT> collection)
		{
			MapperTemplate.DeleteBatch< DEPT>(collection);
		}

		/// <summary>
        /// 查找班级的单一对象
        /// </summary>
        /// <param name="DEPT">DEPT(主键数据不能为空)</param>
        /// <returns>班级对象</returns>
        public DEPT FindOnly(DEPT DEPT)
        {
            return MapperTemplate.FindOnly(DEPT);
        }
		
		/// <summary>
        /// 查询班级数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>班级的对象数组</returns>
		public IList< DEPT> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< DEPT>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计班级数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< DEPT>(conditionCollection);
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
		public IList< DEPT> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< DEPT>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
