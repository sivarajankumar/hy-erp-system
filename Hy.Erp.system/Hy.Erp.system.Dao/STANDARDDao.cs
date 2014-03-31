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
	/// 包装规格，数据访问
	/// </summary>
	public class STANDARDDao : MapperDaoSupport, ISTANDARDDao
	{
		/// <summary>
        /// 插入包装规格的单一对象
        /// </summary>
        /// <param name="STANDARD">包装规格的单一对象</param>
        /// <returns>当前操作的包装规格对象</returns>
		public STANDARD Insert(STANDARD STANDARD)
		{
			STANDARD.ID = Convert.ToInt32(MapperTemplate.Insert(STANDARD));
			return STANDARD;
		}
		
		/// <summary>
        /// 批量插入包装规格的对象数组
        /// </summary>
        /// <param name="collection">包装规格的对象数组</param>
        public void Insert(IList<STANDARD> collection)
        {
            MapperTemplate.InsertBatch< STANDARD>(collection);
        }
		
		/// <summary>
        /// 更新包装规格的单一对象
        /// </summary>
        /// <param name="STANDARD">包装规格的单一对象</param>
		public void Update(STANDARD STANDARD)
		{
			MapperTemplate.Update(STANDARD);
		}

		/// <summary>
        /// 批量更新包装规格的对象数组
        /// </summary>
        /// <param name="collection">包装规格的对象数组</param>
		public void Update(IList<STANDARD> collection)
		{
			MapperTemplate.UpdateBatch< STANDARD>(collection);
		}

		/// <summary>
        /// 删除包装规格的单一对象
        /// </summary>
        /// <param name="STANDARD">包装规格的单一对象(主键数据不能为空)</param>
		public void Delete(STANDARD STANDARD)
		{
			MapperTemplate.Delete(STANDARD);
		}

		/// <summary>
        /// 批量删除包装规格的对象数组
        /// </summary>
        /// <param name="collection">包装规格的对象数组(主键数据不能为空)</param>
		public void Delete(IList< STANDARD> collection)
		{
			MapperTemplate.DeleteBatch< STANDARD>(collection);
		}

		/// <summary>
        /// 查找包装规格的单一对象
        /// </summary>
        /// <param name="STANDARD">STANDARD(主键数据不能为空)</param>
        /// <returns>包装规格对象</returns>
        public STANDARD FindOnly(STANDARD STANDARD)
        {
            return MapperTemplate.FindOnly(STANDARD);
        }
		
		/// <summary>
        /// 查询包装规格数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>包装规格的对象数组</returns>
		public IList< STANDARD> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< STANDARD>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计包装规格数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< STANDARD>(conditionCollection);
		}

		/// <summary>
        /// 包装规格分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>包装规格的对象数组</returns>
		public IList< STANDARD> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< STANDARD>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
