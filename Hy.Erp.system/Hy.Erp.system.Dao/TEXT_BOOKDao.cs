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
	/// 购书单，数据访问
	/// </summary>
	public class TEXTBOOKDao : MapperDaoSupport, ITEXTBOOKDao
	{
		/// <summary>
        /// 插入购书单的单一对象
        /// </summary>
        /// <param name="TEXTBOOK">购书单的单一对象</param>
        /// <returns>当前操作的购书单对象</returns>
		public TEXTBOOK Insert(TEXTBOOK TEXTBOOK)
		{
			TEXTBOOK.ID = Convert.ToInt32(MapperTemplate.Insert(TEXTBOOK));
			return TEXTBOOK;
		}
		
		/// <summary>
        /// 批量插入购书单的对象数组
        /// </summary>
        /// <param name="collection">购书单的对象数组</param>
        public void Insert(IList<TEXTBOOK> collection)
        {
            MapperTemplate.InsertBatch< TEXTBOOK>(collection);
        }
		
		/// <summary>
        /// 更新购书单的单一对象
        /// </summary>
        /// <param name="TEXTBOOK">购书单的单一对象</param>
		public void Update(TEXTBOOK TEXTBOOK)
		{
			MapperTemplate.Update(TEXTBOOK);
		}

		/// <summary>
        /// 批量更新购书单的对象数组
        /// </summary>
        /// <param name="collection">购书单的对象数组</param>
		public void Update(IList<TEXTBOOK> collection)
		{
			MapperTemplate.UpdateBatch< TEXTBOOK>(collection);
		}

		/// <summary>
        /// 删除购书单的单一对象
        /// </summary>
        /// <param name="TEXTBOOK">购书单的单一对象(主键数据不能为空)</param>
		public void Delete(TEXTBOOK TEXTBOOK)
		{
			MapperTemplate.Delete(TEXTBOOK);
		}

		/// <summary>
        /// 批量删除购书单的对象数组
        /// </summary>
        /// <param name="collection">购书单的对象数组(主键数据不能为空)</param>
		public void Delete(IList< TEXTBOOK> collection)
		{
			MapperTemplate.DeleteBatch< TEXTBOOK>(collection);
		}

		/// <summary>
        /// 查找购书单的单一对象
        /// </summary>
        /// <param name="TEXTBOOK">TEXTBOOK(主键数据不能为空)</param>
        /// <returns>购书单对象</returns>
        public TEXTBOOK FindOnly(TEXTBOOK TEXTBOOK)
        {
            return MapperTemplate.FindOnly(TEXTBOOK);
        }
		
		/// <summary>
        /// 查询购书单数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>购书单的对象数组</returns>
		public IList< TEXTBOOK> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< TEXTBOOK>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计购书单数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< TEXTBOOK>(conditionCollection);
		}

		/// <summary>
        /// 购书单分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>购书单的对象数组</returns>
		public IList< TEXTBOOK> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< TEXTBOOK>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
