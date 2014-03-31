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
	/// 角色权限关联，数据访问
	/// </summary>
	public class ROLERIGHTSDao : MapperDaoSupport, IROLERIGHTSDao
	{
		/// <summary>
        /// 插入角色权限关联的单一对象
        /// </summary>
        /// <param name="ROLERIGHTS">角色权限关联的单一对象</param>
        /// <returns>当前操作的角色权限关联对象</returns>
		public ROLERIGHTS Insert(ROLERIGHTS ROLERIGHTS)
		{
			ROLERIGHTS.ID = Convert.ToInt32(MapperTemplate.Insert(ROLERIGHTS));
			return ROLERIGHTS;
		}
		
		/// <summary>
        /// 批量插入角色权限关联的对象数组
        /// </summary>
        /// <param name="collection">角色权限关联的对象数组</param>
        public void Insert(IList<ROLERIGHTS> collection)
        {
            MapperTemplate.InsertBatch< ROLERIGHTS>(collection);
        }
		
		/// <summary>
        /// 更新角色权限关联的单一对象
        /// </summary>
        /// <param name="ROLERIGHTS">角色权限关联的单一对象</param>
		public void Update(ROLERIGHTS ROLERIGHTS)
		{
			MapperTemplate.Update(ROLERIGHTS);
		}

		/// <summary>
        /// 批量更新角色权限关联的对象数组
        /// </summary>
        /// <param name="collection">角色权限关联的对象数组</param>
		public void Update(IList<ROLERIGHTS> collection)
		{
			MapperTemplate.UpdateBatch< ROLERIGHTS>(collection);
		}

		/// <summary>
        /// 删除角色权限关联的单一对象
        /// </summary>
        /// <param name="ROLERIGHTS">角色权限关联的单一对象(主键数据不能为空)</param>
		public void Delete(ROLERIGHTS ROLERIGHTS)
		{
			MapperTemplate.Delete(ROLERIGHTS);
		}

		/// <summary>
        /// 批量删除角色权限关联的对象数组
        /// </summary>
        /// <param name="collection">角色权限关联的对象数组(主键数据不能为空)</param>
		public void Delete(IList< ROLERIGHTS> collection)
		{
			MapperTemplate.DeleteBatch< ROLERIGHTS>(collection);
		}

		/// <summary>
        /// 查找角色权限关联的单一对象
        /// </summary>
        /// <param name="ROLERIGHTS">ROLERIGHTS(主键数据不能为空)</param>
        /// <returns>角色权限关联对象</returns>
        public ROLERIGHTS FindOnly(ROLERIGHTS ROLERIGHTS)
        {
            return MapperTemplate.FindOnly(ROLERIGHTS);
        }
		
		/// <summary>
        /// 查询角色权限关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>角色权限关联的对象数组</returns>
		public IList< ROLERIGHTS> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< ROLERIGHTS>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计角色权限关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< ROLERIGHTS>(conditionCollection);
		}

		/// <summary>
        /// 角色权限关联分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>角色权限关联的对象数组</returns>
		public IList< ROLERIGHTS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< ROLERIGHTS>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
