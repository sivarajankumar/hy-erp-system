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
	/// 物流包装规格，数据访问
	/// </summary>
	public class ORDERFROMDao : MapperDaoSupport, IORDERFROMDao
	{
		/// <summary>
        /// 插入物流包装规格的单一对象
        /// </summary>
        /// <param name="ORDERFROM">物流包装规格的单一对象</param>
        /// <returns>当前操作的物流包装规格对象</returns>
		public ORDERFROM Insert(ORDERFROM ORDERFROM)
		{
			ORDERFROM.ID = Convert.ToInt32(MapperTemplate.Insert(ORDERFROM));
			return ORDERFROM;
		}
		
		/// <summary>
        /// 批量插入物流包装规格的对象数组
        /// </summary>
        /// <param name="collection">物流包装规格的对象数组</param>
        public void Insert(IList<ORDERFROM> collection)
        {
            MapperTemplate.InsertBatch< ORDERFROM>(collection);
        }
		
		/// <summary>
        /// 更新物流包装规格的单一对象
        /// </summary>
        /// <param name="ORDERFROM">物流包装规格的单一对象</param>
		public void Update(ORDERFROM ORDERFROM)
		{
			MapperTemplate.Update(ORDERFROM);
		}

		/// <summary>
        /// 批量更新物流包装规格的对象数组
        /// </summary>
        /// <param name="collection">物流包装规格的对象数组</param>
		public void Update(IList<ORDERFROM> collection)
		{
			MapperTemplate.UpdateBatch< ORDERFROM>(collection);
		}

		/// <summary>
        /// 删除物流包装规格的单一对象
        /// </summary>
        /// <param name="ORDERFROM">物流包装规格的单一对象(主键数据不能为空)</param>
		public void Delete(ORDERFROM ORDERFROM)
		{
			MapperTemplate.Delete(ORDERFROM);
		}

		/// <summary>
        /// 批量删除物流包装规格的对象数组
        /// </summary>
        /// <param name="collection">物流包装规格的对象数组(主键数据不能为空)</param>
		public void Delete(IList< ORDERFROM> collection)
		{
			MapperTemplate.DeleteBatch< ORDERFROM>(collection);
		}

		/// <summary>
        /// 查找物流包装规格的单一对象
        /// </summary>
        /// <param name="ORDERFROM">ORDERFROM(主键数据不能为空)</param>
        /// <returns>物流包装规格对象</returns>
        public ORDERFROM FindOnly(ORDERFROM ORDERFROM)
        {
            return MapperTemplate.FindOnly(ORDERFROM);
        }
		
		/// <summary>
        /// 查询物流包装规格数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>物流包装规格的对象数组</returns>
		public IList< ORDERFROM> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< ORDERFROM>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计物流包装规格数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< ORDERFROM>(conditionCollection);
		}

		/// <summary>
        /// 物流包装规格分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>物流包装规格的对象数组</returns>
		public IList< ORDERFROM> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< ORDERFROM>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
