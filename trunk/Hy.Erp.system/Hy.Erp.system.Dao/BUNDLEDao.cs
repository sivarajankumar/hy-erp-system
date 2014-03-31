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
	/// 购书捆绑包，数据访问
	/// </summary>
	public class BUNDLEDao : MapperDaoSupport, IBUNDLEDao
	{
		/// <summary>
        /// 插入购书捆绑包的单一对象
        /// </summary>
        /// <param name="BUNDLE">购书捆绑包的单一对象</param>
        /// <returns>当前操作的购书捆绑包对象</returns>
		public BUNDLE Insert(BUNDLE BUNDLE)
		{
			BUNDLE.ID = Convert.ToInt32(MapperTemplate.Insert(BUNDLE));
			return BUNDLE;
		}
		
		/// <summary>
        /// 批量插入购书捆绑包的对象数组
        /// </summary>
        /// <param name="collection">购书捆绑包的对象数组</param>
        public void Insert(IList<BUNDLE> collection)
        {
            MapperTemplate.InsertBatch< BUNDLE>(collection);
        }
		
		/// <summary>
        /// 更新购书捆绑包的单一对象
        /// </summary>
        /// <param name="BUNDLE">购书捆绑包的单一对象</param>
		public void Update(BUNDLE BUNDLE)
		{
			MapperTemplate.Update(BUNDLE);
		}

		/// <summary>
        /// 批量更新购书捆绑包的对象数组
        /// </summary>
        /// <param name="collection">购书捆绑包的对象数组</param>
		public void Update(IList<BUNDLE> collection)
		{
			MapperTemplate.UpdateBatch< BUNDLE>(collection);
		}

		/// <summary>
        /// 删除购书捆绑包的单一对象
        /// </summary>
        /// <param name="BUNDLE">购书捆绑包的单一对象(主键数据不能为空)</param>
		public void Delete(BUNDLE BUNDLE)
		{
			MapperTemplate.Delete(BUNDLE);
		}

		/// <summary>
        /// 批量删除购书捆绑包的对象数组
        /// </summary>
        /// <param name="collection">购书捆绑包的对象数组(主键数据不能为空)</param>
		public void Delete(IList< BUNDLE> collection)
		{
			MapperTemplate.DeleteBatch< BUNDLE>(collection);
		}

		/// <summary>
        /// 查找购书捆绑包的单一对象
        /// </summary>
        /// <param name="BUNDLE">BUNDLE(主键数据不能为空)</param>
        /// <returns>购书捆绑包对象</returns>
        public BUNDLE FindOnly(BUNDLE BUNDLE)
        {
            return MapperTemplate.FindOnly(BUNDLE);
        }
		
		/// <summary>
        /// 查询购书捆绑包数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>购书捆绑包的对象数组</returns>
		public IList< BUNDLE> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< BUNDLE>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计购书捆绑包数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< BUNDLE>(conditionCollection);
		}

		/// <summary>
        /// 购书捆绑包分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>购书捆绑包的对象数组</returns>
		public IList< BUNDLE> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< BUNDLE>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
