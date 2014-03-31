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
	/// 数据种类，数据访问
	/// </summary>
	public class DATATYPEDao : MapperDaoSupport, IDATATYPEDao
	{
		/// <summary>
        /// 插入数据种类的单一对象
        /// </summary>
        /// <param name="DATATYPE">数据种类的单一对象</param>
        /// <returns>当前操作的数据种类对象</returns>
		public DATATYPE Insert(DATATYPE DATATYPE)
		{
			DATATYPE.ID = Convert.ToInt32(MapperTemplate.Insert(DATATYPE));
			return DATATYPE;
		}
		
		/// <summary>
        /// 批量插入数据种类的对象数组
        /// </summary>
        /// <param name="collection">数据种类的对象数组</param>
        public void Insert(IList<DATATYPE> collection)
        {
            MapperTemplate.InsertBatch< DATATYPE>(collection);
        }
		
		/// <summary>
        /// 更新数据种类的单一对象
        /// </summary>
        /// <param name="DATATYPE">数据种类的单一对象</param>
		public void Update(DATATYPE DATATYPE)
		{
			MapperTemplate.Update(DATATYPE);
		}

		/// <summary>
        /// 批量更新数据种类的对象数组
        /// </summary>
        /// <param name="collection">数据种类的对象数组</param>
		public void Update(IList<DATATYPE> collection)
		{
			MapperTemplate.UpdateBatch< DATATYPE>(collection);
		}

		/// <summary>
        /// 删除数据种类的单一对象
        /// </summary>
        /// <param name="DATATYPE">数据种类的单一对象(主键数据不能为空)</param>
		public void Delete(DATATYPE DATATYPE)
		{
			MapperTemplate.Delete(DATATYPE);
		}

		/// <summary>
        /// 批量删除数据种类的对象数组
        /// </summary>
        /// <param name="collection">数据种类的对象数组(主键数据不能为空)</param>
		public void Delete(IList< DATATYPE> collection)
		{
			MapperTemplate.DeleteBatch< DATATYPE>(collection);
		}

		/// <summary>
        /// 查找数据种类的单一对象
        /// </summary>
        /// <param name="DATATYPE">DATATYPE(主键数据不能为空)</param>
        /// <returns>数据种类对象</returns>
        public DATATYPE FindOnly(DATATYPE DATATYPE)
        {
            return MapperTemplate.FindOnly(DATATYPE);
        }
		
		/// <summary>
        /// 查询数据种类数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>数据种类的对象数组</returns>
		public IList< DATATYPE> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< DATATYPE>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计数据种类数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< DATATYPE>(conditionCollection);
		}

		/// <summary>
        /// 数据种类分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>数据种类的对象数组</returns>
		public IList< DATATYPE> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< DATATYPE>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
