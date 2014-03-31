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
	/// 角色，数据访问
	/// </summary>
	public class ROLEDao : MapperDaoSupport, IROLEDao
	{
		/// <summary>
        /// 插入角色的单一对象
        /// </summary>
        /// <param name="ROLE">角色的单一对象</param>
        /// <returns>当前操作的角色对象</returns>
		public ROLE Insert(ROLE ROLE)
		{
			ROLE.ID = Convert.ToInt32(MapperTemplate.Insert(ROLE));
			return ROLE;
		}
		
		/// <summary>
        /// 批量插入角色的对象数组
        /// </summary>
        /// <param name="collection">角色的对象数组</param>
        public void Insert(IList<ROLE> collection)
        {
            MapperTemplate.InsertBatch< ROLE>(collection);
        }
		
		/// <summary>
        /// 更新角色的单一对象
        /// </summary>
        /// <param name="ROLE">角色的单一对象</param>
		public void Update(ROLE ROLE)
		{
			MapperTemplate.Update(ROLE);
		}

		/// <summary>
        /// 批量更新角色的对象数组
        /// </summary>
        /// <param name="collection">角色的对象数组</param>
		public void Update(IList<ROLE> collection)
		{
			MapperTemplate.UpdateBatch< ROLE>(collection);
		}

		/// <summary>
        /// 删除角色的单一对象
        /// </summary>
        /// <param name="ROLE">角色的单一对象(主键数据不能为空)</param>
		public void Delete(ROLE ROLE)
		{
			MapperTemplate.Delete(ROLE);
		}

		/// <summary>
        /// 批量删除角色的对象数组
        /// </summary>
        /// <param name="collection">角色的对象数组(主键数据不能为空)</param>
		public void Delete(IList< ROLE> collection)
		{
			MapperTemplate.DeleteBatch< ROLE>(collection);
		}

		/// <summary>
        /// 查找角色的单一对象
        /// </summary>
        /// <param name="ROLE">ROLE(主键数据不能为空)</param>
        /// <returns>角色对象</returns>
        public ROLE FindOnly(ROLE ROLE)
        {
            return MapperTemplate.FindOnly(ROLE);
        }
		
		/// <summary>
        /// 查询角色数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>角色的对象数组</returns>
		public IList< ROLE> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< ROLE>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计角色数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< ROLE>(conditionCollection);
		}

		/// <summary>
        /// 角色分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>角色的对象数组</returns>
		public IList< ROLE> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< ROLE>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
