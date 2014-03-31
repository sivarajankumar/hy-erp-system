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
	/// 新订购单，数据访问
	/// </summary>
	public class BOOKORDERDao : MapperDaoSupport, IBOOKORDERDao
	{
		/// <summary>
        /// 插入新订购单的单一对象
        /// </summary>
        /// <param name="BOOKORDER">新订购单的单一对象</param>
        /// <returns>当前操作的新订购单对象</returns>
		public BOOKORDER Insert(BOOKORDER BOOKORDER)
		{
			BOOKORDER.ID = Convert.ToInt32(MapperTemplate.Insert(BOOKORDER));
			return BOOKORDER;
		}
		
		/// <summary>
        /// 批量插入新订购单的对象数组
        /// </summary>
        /// <param name="collection">新订购单的对象数组</param>
        public void Insert(IList<BOOKORDER> collection)
        {
            MapperTemplate.InsertBatch< BOOKORDER>(collection);
        }
		
		/// <summary>
        /// 更新新订购单的单一对象
        /// </summary>
        /// <param name="BOOKORDER">新订购单的单一对象</param>
		public void Update(BOOKORDER BOOKORDER)
		{
			MapperTemplate.Update(BOOKORDER);
		}

		/// <summary>
        /// 批量更新新订购单的对象数组
        /// </summary>
        /// <param name="collection">新订购单的对象数组</param>
		public void Update(IList<BOOKORDER> collection)
		{
			MapperTemplate.UpdateBatch< BOOKORDER>(collection);
		}

		/// <summary>
        /// 删除新订购单的单一对象
        /// </summary>
        /// <param name="BOOKORDER">新订购单的单一对象(主键数据不能为空)</param>
		public void Delete(BOOKORDER BOOKORDER)
		{
			MapperTemplate.Delete(BOOKORDER);
		}

		/// <summary>
        /// 批量删除新订购单的对象数组
        /// </summary>
        /// <param name="collection">新订购单的对象数组(主键数据不能为空)</param>
		public void Delete(IList< BOOKORDER> collection)
		{
			MapperTemplate.DeleteBatch< BOOKORDER>(collection);
		}

		/// <summary>
        /// 查找新订购单的单一对象
        /// </summary>
        /// <param name="BOOKORDER">BOOKORDER(主键数据不能为空)</param>
        /// <returns>新订购单对象</returns>
        public BOOKORDER FindOnly(BOOKORDER BOOKORDER)
        {
            return MapperTemplate.FindOnly(BOOKORDER);
        }
		
		/// <summary>
        /// 查询新订购单数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>新订购单的对象数组</returns>
		public IList< BOOKORDER> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< BOOKORDER>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计新订购单数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< BOOKORDER>(conditionCollection);
		}

		/// <summary>
        /// 新订购单分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>新订购单的对象数组</returns>
		public IList< BOOKORDER> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< BOOKORDER>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
