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
	/// 购买，数据访问
	/// </summary>
	public class PURCHASEDao : MapperDaoSupport, IPURCHASEDao
	{
		/// <summary>
        /// 插入购买的单一对象
        /// </summary>
        /// <param name="PURCHASE">购买的单一对象</param>
        /// <returns>当前操作的购买对象</returns>
		public PURCHASE Insert(PURCHASE PURCHASE)
		{
			PURCHASE.ID = Convert.ToInt32(MapperTemplate.Insert(PURCHASE));
			return PURCHASE;
		}
		
		/// <summary>
        /// 批量插入购买的对象数组
        /// </summary>
        /// <param name="collection">购买的对象数组</param>
        public void Insert(IList<PURCHASE> collection)
        {
            MapperTemplate.InsertBatch< PURCHASE>(collection);
        }
		
		/// <summary>
        /// 更新购买的单一对象
        /// </summary>
        /// <param name="PURCHASE">购买的单一对象</param>
		public void Update(PURCHASE PURCHASE)
		{
			MapperTemplate.Update(PURCHASE);
		}

		/// <summary>
        /// 批量更新购买的对象数组
        /// </summary>
        /// <param name="collection">购买的对象数组</param>
		public void Update(IList<PURCHASE> collection)
		{
			MapperTemplate.UpdateBatch< PURCHASE>(collection);
		}

		/// <summary>
        /// 删除购买的单一对象
        /// </summary>
        /// <param name="PURCHASE">购买的单一对象(主键数据不能为空)</param>
		public void Delete(PURCHASE PURCHASE)
		{
			MapperTemplate.Delete(PURCHASE);
		}

		/// <summary>
        /// 批量删除购买的对象数组
        /// </summary>
        /// <param name="collection">购买的对象数组(主键数据不能为空)</param>
		public void Delete(IList< PURCHASE> collection)
		{
			MapperTemplate.DeleteBatch< PURCHASE>(collection);
		}

		/// <summary>
        /// 查找购买的单一对象
        /// </summary>
        /// <param name="PURCHASE">PURCHASE(主键数据不能为空)</param>
        /// <returns>购买对象</returns>
        public PURCHASE FindOnly(PURCHASE PURCHASE)
        {
            return MapperTemplate.FindOnly(PURCHASE);
        }
		
		/// <summary>
        /// 查询购买数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>购买的对象数组</returns>
		public IList< PURCHASE> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< PURCHASE>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计购买数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< PURCHASE>(conditionCollection);
		}

		/// <summary>
        /// 购买分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>购买的对象数组</returns>
		public IList< PURCHASE> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< PURCHASE>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
