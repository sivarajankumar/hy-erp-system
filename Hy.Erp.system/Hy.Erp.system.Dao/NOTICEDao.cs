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
	/// 团购通知单，数据访问
	/// </summary>
	public class NOTICEDao : MapperDaoSupport, INOTICEDao
	{
		/// <summary>
        /// 插入团购通知单的单一对象
        /// </summary>
        /// <param name="NOTICE">团购通知单的单一对象</param>
        /// <returns>当前操作的团购通知单对象</returns>
		public NOTICE Insert(NOTICE NOTICE)
		{
			NOTICE.ID = Convert.ToInt32(MapperTemplate.Insert(NOTICE));
			return NOTICE;
		}
		
		/// <summary>
        /// 批量插入团购通知单的对象数组
        /// </summary>
        /// <param name="collection">团购通知单的对象数组</param>
        public void Insert(IList<NOTICE> collection)
        {
            MapperTemplate.InsertBatch< NOTICE>(collection);
        }
		
		/// <summary>
        /// 更新团购通知单的单一对象
        /// </summary>
        /// <param name="NOTICE">团购通知单的单一对象</param>
		public void Update(NOTICE NOTICE)
		{
			MapperTemplate.Update(NOTICE);
		}

		/// <summary>
        /// 批量更新团购通知单的对象数组
        /// </summary>
        /// <param name="collection">团购通知单的对象数组</param>
		public void Update(IList<NOTICE> collection)
		{
			MapperTemplate.UpdateBatch< NOTICE>(collection);
		}

		/// <summary>
        /// 删除团购通知单的单一对象
        /// </summary>
        /// <param name="NOTICE">团购通知单的单一对象(主键数据不能为空)</param>
		public void Delete(NOTICE NOTICE)
		{
			MapperTemplate.Delete(NOTICE);
		}

		/// <summary>
        /// 批量删除团购通知单的对象数组
        /// </summary>
        /// <param name="collection">团购通知单的对象数组(主键数据不能为空)</param>
		public void Delete(IList< NOTICE> collection)
		{
			MapperTemplate.DeleteBatch< NOTICE>(collection);
		}

		/// <summary>
        /// 查找团购通知单的单一对象
        /// </summary>
        /// <param name="NOTICE">NOTICE(主键数据不能为空)</param>
        /// <returns>团购通知单对象</returns>
        public NOTICE FindOnly(NOTICE NOTICE)
        {
            return MapperTemplate.FindOnly(NOTICE);
        }
		
		/// <summary>
        /// 查询团购通知单数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>团购通知单的对象数组</returns>
		public IList< NOTICE> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< NOTICE>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计团购通知单数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< NOTICE>(conditionCollection);
		}

		/// <summary>
        /// 团购通知单分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>团购通知单的对象数组</returns>
		public IList< NOTICE> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< NOTICE>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
