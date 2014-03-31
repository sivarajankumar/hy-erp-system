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
	/// 权限，数据访问
	/// </summary>
	public class RIGHTSDao : MapperDaoSupport, IRIGHTSDao
	{
		/// <summary>
        /// 插入权限的单一对象
        /// </summary>
        /// <param name="RIGHTS">权限的单一对象</param>
        /// <returns>当前操作的权限对象</returns>
		public RIGHTS Insert(RIGHTS RIGHTS)
		{
			RIGHTS.ID = Convert.ToInt32(MapperTemplate.Insert(RIGHTS));
			return RIGHTS;
		}
		
		/// <summary>
        /// 批量插入权限的对象数组
        /// </summary>
        /// <param name="collection">权限的对象数组</param>
        public void Insert(IList<RIGHTS> collection)
        {
            MapperTemplate.InsertBatch< RIGHTS>(collection);
        }
		
		/// <summary>
        /// 更新权限的单一对象
        /// </summary>
        /// <param name="RIGHTS">权限的单一对象</param>
		public void Update(RIGHTS RIGHTS)
		{
			MapperTemplate.Update(RIGHTS);
		}

		/// <summary>
        /// 批量更新权限的对象数组
        /// </summary>
        /// <param name="collection">权限的对象数组</param>
		public void Update(IList<RIGHTS> collection)
		{
			MapperTemplate.UpdateBatch< RIGHTS>(collection);
		}

		/// <summary>
        /// 删除权限的单一对象
        /// </summary>
        /// <param name="RIGHTS">权限的单一对象(主键数据不能为空)</param>
		public void Delete(RIGHTS RIGHTS)
		{
			MapperTemplate.Delete(RIGHTS);
		}

		/// <summary>
        /// 批量删除权限的对象数组
        /// </summary>
        /// <param name="collection">权限的对象数组(主键数据不能为空)</param>
		public void Delete(IList< RIGHTS> collection)
		{
			MapperTemplate.DeleteBatch< RIGHTS>(collection);
		}

		/// <summary>
        /// 查找权限的单一对象
        /// </summary>
        /// <param name="RIGHTS">RIGHTS(主键数据不能为空)</param>
        /// <returns>权限对象</returns>
        public RIGHTS FindOnly(RIGHTS RIGHTS)
        {
            return MapperTemplate.FindOnly(RIGHTS);
        }
		
		/// <summary>
        /// 查询权限数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>权限的对象数组</returns>
		public IList< RIGHTS> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< RIGHTS>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计权限数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< RIGHTS>(conditionCollection);
		}

		/// <summary>
        /// 权限分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>权限的对象数组</returns>
		public IList< RIGHTS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< RIGHTS>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
