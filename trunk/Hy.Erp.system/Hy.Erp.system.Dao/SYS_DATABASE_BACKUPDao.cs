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
	/// 数据库备份，数据访问
	/// </summary>
	public class SYSDATABASEBACKUPDao : MapperDaoSupport, ISYSDATABASEBACKUPDao
	{
		/// <summary>
        /// 插入数据库备份的单一对象
        /// </summary>
        /// <param name="SYSDATABASEBACKUP">数据库备份的单一对象</param>
        /// <returns>当前操作的数据库备份对象</returns>
		public SYSDATABASEBACKUP Insert(SYSDATABASEBACKUP SYSDATABASEBACKUP)
		{
			SYSDATABASEBACKUP.ID = Convert.ToInt32(MapperTemplate.Insert(SYSDATABASEBACKUP));
			return SYSDATABASEBACKUP;
		}
		
		/// <summary>
        /// 批量插入数据库备份的对象数组
        /// </summary>
        /// <param name="collection">数据库备份的对象数组</param>
        public void Insert(IList<SYSDATABASEBACKUP> collection)
        {
            MapperTemplate.InsertBatch< SYSDATABASEBACKUP>(collection);
        }
		
		/// <summary>
        /// 更新数据库备份的单一对象
        /// </summary>
        /// <param name="SYSDATABASEBACKUP">数据库备份的单一对象</param>
		public void Update(SYSDATABASEBACKUP SYSDATABASEBACKUP)
		{
			MapperTemplate.Update(SYSDATABASEBACKUP);
		}

		/// <summary>
        /// 批量更新数据库备份的对象数组
        /// </summary>
        /// <param name="collection">数据库备份的对象数组</param>
		public void Update(IList<SYSDATABASEBACKUP> collection)
		{
			MapperTemplate.UpdateBatch< SYSDATABASEBACKUP>(collection);
		}

		/// <summary>
        /// 删除数据库备份的单一对象
        /// </summary>
        /// <param name="SYSDATABASEBACKUP">数据库备份的单一对象(主键数据不能为空)</param>
		public void Delete(SYSDATABASEBACKUP SYSDATABASEBACKUP)
		{
			MapperTemplate.Delete(SYSDATABASEBACKUP);
		}

		/// <summary>
        /// 批量删除数据库备份的对象数组
        /// </summary>
        /// <param name="collection">数据库备份的对象数组(主键数据不能为空)</param>
		public void Delete(IList< SYSDATABASEBACKUP> collection)
		{
			MapperTemplate.DeleteBatch< SYSDATABASEBACKUP>(collection);
		}

		/// <summary>
        /// 查找数据库备份的单一对象
        /// </summary>
        /// <param name="SYSDATABASEBACKUP">SYSDATABASEBACKUP(主键数据不能为空)</param>
        /// <returns>数据库备份对象</returns>
        public SYSDATABASEBACKUP FindOnly(SYSDATABASEBACKUP SYSDATABASEBACKUP)
        {
            return MapperTemplate.FindOnly(SYSDATABASEBACKUP);
        }
		
		/// <summary>
        /// 查询数据库备份数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>数据库备份的对象数组</returns>
		public IList< SYSDATABASEBACKUP> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< SYSDATABASEBACKUP>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计数据库备份数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< SYSDATABASEBACKUP>(conditionCollection);
		}

		/// <summary>
        /// 数据库备份分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>数据库备份的对象数组</returns>
		public IList< SYSDATABASEBACKUP> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< SYSDATABASEBACKUP>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
