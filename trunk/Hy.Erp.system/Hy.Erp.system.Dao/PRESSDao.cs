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
	/// 出版社，数据访问
	/// </summary>
	public class PRESSDao : MapperDaoSupport, IPRESSDao
	{
		/// <summary>
        /// 插入出版社的单一对象
        /// </summary>
        /// <param name="PRESS">出版社的单一对象</param>
        /// <returns>当前操作的出版社对象</returns>
		public PRESS Insert(PRESS PRESS)
		{
			PRESS.ID = Convert.ToInt32(MapperTemplate.Insert(PRESS));
			return PRESS;
		}
		
		/// <summary>
        /// 批量插入出版社的对象数组
        /// </summary>
        /// <param name="collection">出版社的对象数组</param>
        public void Insert(IList<PRESS> collection)
        {
            MapperTemplate.InsertBatch< PRESS>(collection);
        }
		
		/// <summary>
        /// 更新出版社的单一对象
        /// </summary>
        /// <param name="PRESS">出版社的单一对象</param>
		public void Update(PRESS PRESS)
		{
			MapperTemplate.Update(PRESS);
		}

		/// <summary>
        /// 批量更新出版社的对象数组
        /// </summary>
        /// <param name="collection">出版社的对象数组</param>
		public void Update(IList<PRESS> collection)
		{
			MapperTemplate.UpdateBatch< PRESS>(collection);
		}

		/// <summary>
        /// 删除出版社的单一对象
        /// </summary>
        /// <param name="PRESS">出版社的单一对象(主键数据不能为空)</param>
		public void Delete(PRESS PRESS)
		{
			MapperTemplate.Delete(PRESS);
		}

		/// <summary>
        /// 批量删除出版社的对象数组
        /// </summary>
        /// <param name="collection">出版社的对象数组(主键数据不能为空)</param>
		public void Delete(IList< PRESS> collection)
		{
			MapperTemplate.DeleteBatch< PRESS>(collection);
		}

		/// <summary>
        /// 查找出版社的单一对象
        /// </summary>
        /// <param name="PRESS">PRESS(主键数据不能为空)</param>
        /// <returns>出版社对象</returns>
        public PRESS FindOnly(PRESS PRESS)
        {
            return MapperTemplate.FindOnly(PRESS);
        }
		
		/// <summary>
        /// 查询出版社数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>出版社的对象数组</returns>
		public IList< PRESS> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< PRESS>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计出版社数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< PRESS>(conditionCollection);
		}

		/// <summary>
        /// 出版社分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>出版社的对象数组</returns>
		public IList< PRESS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< PRESS>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
