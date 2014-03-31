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
	/// 用户，数据访问
	/// </summary>
	public class USERDao : MapperDaoSupport, IUSERDao
	{
		/// <summary>
        /// 插入用户的单一对象
        /// </summary>
        /// <param name="USER">用户的单一对象</param>
        /// <returns>当前操作的用户对象</returns>
		public USER Insert(USER USER)
		{
			USER.ID = Convert.ToInt32(MapperTemplate.Insert(USER));
			return USER;
		}
		
		/// <summary>
        /// 批量插入用户的对象数组
        /// </summary>
        /// <param name="collection">用户的对象数组</param>
        public void Insert(IList<USER> collection)
        {
            MapperTemplate.InsertBatch< USER>(collection);
        }
		
		/// <summary>
        /// 更新用户的单一对象
        /// </summary>
        /// <param name="USER">用户的单一对象</param>
		public void Update(USER USER)
		{
			MapperTemplate.Update(USER);
		}

		/// <summary>
        /// 批量更新用户的对象数组
        /// </summary>
        /// <param name="collection">用户的对象数组</param>
		public void Update(IList<USER> collection)
		{
			MapperTemplate.UpdateBatch< USER>(collection);
		}

		/// <summary>
        /// 删除用户的单一对象
        /// </summary>
        /// <param name="USER">用户的单一对象(主键数据不能为空)</param>
		public void Delete(USER USER)
		{
			MapperTemplate.Delete(USER);
		}

		/// <summary>
        /// 批量删除用户的对象数组
        /// </summary>
        /// <param name="collection">用户的对象数组(主键数据不能为空)</param>
		public void Delete(IList< USER> collection)
		{
			MapperTemplate.DeleteBatch< USER>(collection);
		}

		/// <summary>
        /// 查找用户的单一对象
        /// </summary>
        /// <param name="USER">USER(主键数据不能为空)</param>
        /// <returns>用户对象</returns>
        public USER FindOnly(USER USER)
        {
            return MapperTemplate.FindOnly(USER);
        }
		
		/// <summary>
        /// 查询用户数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>用户的对象数组</returns>
		public IList< USER> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< USER>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计用户数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< USER>(conditionCollection);
		}

		/// <summary>
        /// 用户分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>用户的对象数组</returns>
		public IList< USER> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< USER>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
