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
	/// 组织，数据访问
	/// </summary>
	public class ORGANIZATIONDao : MapperDaoSupport, IORGANIZATIONDao
	{
		/// <summary>
        /// 插入组织的单一对象
        /// </summary>
        /// <param name="ORGANIZATION">组织的单一对象</param>
        /// <returns>当前操作的组织对象</returns>
		public ORGANIZATION Insert(ORGANIZATION ORGANIZATION)
		{
			ORGANIZATION.ID = Convert.ToInt32(MapperTemplate.Insert(ORGANIZATION));
			return ORGANIZATION;
		}
		
		/// <summary>
        /// 批量插入组织的对象数组
        /// </summary>
        /// <param name="collection">组织的对象数组</param>
        public void Insert(IList<ORGANIZATION> collection)
        {
            MapperTemplate.InsertBatch< ORGANIZATION>(collection);
        }
		
		/// <summary>
        /// 更新组织的单一对象
        /// </summary>
        /// <param name="ORGANIZATION">组织的单一对象</param>
		public void Update(ORGANIZATION ORGANIZATION)
		{
			MapperTemplate.Update(ORGANIZATION);
		}

		/// <summary>
        /// 批量更新组织的对象数组
        /// </summary>
        /// <param name="collection">组织的对象数组</param>
		public void Update(IList<ORGANIZATION> collection)
		{
			MapperTemplate.UpdateBatch< ORGANIZATION>(collection);
		}

		/// <summary>
        /// 删除组织的单一对象
        /// </summary>
        /// <param name="ORGANIZATION">组织的单一对象(主键数据不能为空)</param>
		public void Delete(ORGANIZATION ORGANIZATION)
		{
			MapperTemplate.Delete(ORGANIZATION);
		}

		/// <summary>
        /// 批量删除组织的对象数组
        /// </summary>
        /// <param name="collection">组织的对象数组(主键数据不能为空)</param>
		public void Delete(IList< ORGANIZATION> collection)
		{
			MapperTemplate.DeleteBatch< ORGANIZATION>(collection);
		}

		/// <summary>
        /// 查找组织的单一对象
        /// </summary>
        /// <param name="ORGANIZATION">ORGANIZATION(主键数据不能为空)</param>
        /// <returns>组织对象</returns>
        public ORGANIZATION FindOnly(ORGANIZATION ORGANIZATION)
        {
            return MapperTemplate.FindOnly(ORGANIZATION);
        }
		
		/// <summary>
        /// 查询组织数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>组织的对象数组</returns>
		public IList< ORGANIZATION> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< ORGANIZATION>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计组织数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< ORGANIZATION>(conditionCollection);
		}

		/// <summary>
        /// 组织分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>组织的对象数组</returns>
		public IList< ORGANIZATION> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< ORGANIZATION>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
