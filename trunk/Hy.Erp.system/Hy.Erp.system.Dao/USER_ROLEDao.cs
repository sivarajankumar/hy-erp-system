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
	/// 用户角色关联，数据访问
	/// </summary>
	public class USERROLEDao : MapperDaoSupport, IUSERROLEDao
	{
		/// <summary>
        /// 插入用户角色关联的单一对象
        /// </summary>
        /// <param name="USERROLE">用户角色关联的单一对象</param>
        /// <returns>当前操作的用户角色关联对象</returns>
		public USERROLE Insert(USERROLE USERROLE)
		{
			USERROLE.ID = Convert.ToInt32(MapperTemplate.Insert(USERROLE));
			return USERROLE;
		}
		
		/// <summary>
        /// 批量插入用户角色关联的对象数组
        /// </summary>
        /// <param name="collection">用户角色关联的对象数组</param>
        public void Insert(IList<USERROLE> collection)
        {
            MapperTemplate.InsertBatch< USERROLE>(collection);
        }
		
		/// <summary>
        /// 更新用户角色关联的单一对象
        /// </summary>
        /// <param name="USERROLE">用户角色关联的单一对象</param>
		public void Update(USERROLE USERROLE)
		{
			MapperTemplate.Update(USERROLE);
		}

		/// <summary>
        /// 批量更新用户角色关联的对象数组
        /// </summary>
        /// <param name="collection">用户角色关联的对象数组</param>
		public void Update(IList<USERROLE> collection)
		{
			MapperTemplate.UpdateBatch< USERROLE>(collection);
		}

		/// <summary>
        /// 删除用户角色关联的单一对象
        /// </summary>
        /// <param name="USERROLE">用户角色关联的单一对象(主键数据不能为空)</param>
		public void Delete(USERROLE USERROLE)
		{
			MapperTemplate.Delete(USERROLE);
		}

		/// <summary>
        /// 批量删除用户角色关联的对象数组
        /// </summary>
        /// <param name="collection">用户角色关联的对象数组(主键数据不能为空)</param>
		public void Delete(IList< USERROLE> collection)
		{
			MapperTemplate.DeleteBatch< USERROLE>(collection);
		}

		/// <summary>
        /// 查找用户角色关联的单一对象
        /// </summary>
        /// <param name="USERROLE">USERROLE(主键数据不能为空)</param>
        /// <returns>用户角色关联对象</returns>
        public USERROLE FindOnly(USERROLE USERROLE)
        {
            return MapperTemplate.FindOnly(USERROLE);
        }
		
		/// <summary>
        /// 查询用户角色关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>用户角色关联的对象数组</returns>
		public IList< USERROLE> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< USERROLE>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计用户角色关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< USERROLE>(conditionCollection);
		}

		/// <summary>
        /// 用户角色关联分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>用户角色关联的对象数组</returns>
		public IList< USERROLE> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< USERROLE>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
