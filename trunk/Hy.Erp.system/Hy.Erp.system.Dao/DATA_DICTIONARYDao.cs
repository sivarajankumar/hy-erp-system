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
	/// 数据细项，数据访问
	/// </summary>
	public class DATADICTIONARYDao : MapperDaoSupport, IDATADICTIONARYDao
	{
		/// <summary>
        /// 插入数据细项的单一对象
        /// </summary>
        /// <param name="DATADICTIONARY">数据细项的单一对象</param>
        /// <returns>当前操作的数据细项对象</returns>
		public DATADICTIONARY Insert(DATADICTIONARY DATADICTIONARY)
		{
			DATADICTIONARY.ID = Convert.ToInt32(MapperTemplate.Insert(DATADICTIONARY));
			return DATADICTIONARY;
		}
		
		/// <summary>
        /// 批量插入数据细项的对象数组
        /// </summary>
        /// <param name="collection">数据细项的对象数组</param>
        public void Insert(IList<DATADICTIONARY> collection)
        {
            MapperTemplate.InsertBatch< DATADICTIONARY>(collection);
        }
		
		/// <summary>
        /// 更新数据细项的单一对象
        /// </summary>
        /// <param name="DATADICTIONARY">数据细项的单一对象</param>
		public void Update(DATADICTIONARY DATADICTIONARY)
		{
			MapperTemplate.Update(DATADICTIONARY);
		}

		/// <summary>
        /// 批量更新数据细项的对象数组
        /// </summary>
        /// <param name="collection">数据细项的对象数组</param>
		public void Update(IList<DATADICTIONARY> collection)
		{
			MapperTemplate.UpdateBatch< DATADICTIONARY>(collection);
		}

		/// <summary>
        /// 删除数据细项的单一对象
        /// </summary>
        /// <param name="DATADICTIONARY">数据细项的单一对象(主键数据不能为空)</param>
		public void Delete(DATADICTIONARY DATADICTIONARY)
		{
			MapperTemplate.Delete(DATADICTIONARY);
		}

		/// <summary>
        /// 批量删除数据细项的对象数组
        /// </summary>
        /// <param name="collection">数据细项的对象数组(主键数据不能为空)</param>
		public void Delete(IList< DATADICTIONARY> collection)
		{
			MapperTemplate.DeleteBatch< DATADICTIONARY>(collection);
		}

		/// <summary>
        /// 查找数据细项的单一对象
        /// </summary>
        /// <param name="DATADICTIONARY">DATADICTIONARY(主键数据不能为空)</param>
        /// <returns>数据细项对象</returns>
        public DATADICTIONARY FindOnly(DATADICTIONARY DATADICTIONARY)
        {
            return MapperTemplate.FindOnly(DATADICTIONARY);
        }
		
		/// <summary>
        /// 查询数据细项数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>数据细项的对象数组</returns>
		public IList< DATADICTIONARY> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< DATADICTIONARY>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计数据细项数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< DATADICTIONARY>(conditionCollection);
		}

		/// <summary>
        /// 数据细项分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>数据细项的对象数组</returns>
		public IList< DATADICTIONARY> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< DATADICTIONARY>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
