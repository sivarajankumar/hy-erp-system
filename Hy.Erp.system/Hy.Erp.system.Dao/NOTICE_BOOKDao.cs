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
	/// 团购书籍关联，数据访问
	/// </summary>
	public class NOTICEBOOKDao : MapperDaoSupport, INOTICEBOOKDao
	{
		/// <summary>
        /// 插入团购书籍关联的单一对象
        /// </summary>
        /// <param name="NOTICEBOOK">团购书籍关联的单一对象</param>
        /// <returns>当前操作的团购书籍关联对象</returns>
		public NOTICEBOOK Insert(NOTICEBOOK NOTICEBOOK)
		{
			NOTICEBOOK.ID = Convert.ToInt32(MapperTemplate.Insert(NOTICEBOOK));
			return NOTICEBOOK;
		}
		
		/// <summary>
        /// 批量插入团购书籍关联的对象数组
        /// </summary>
        /// <param name="collection">团购书籍关联的对象数组</param>
        public void Insert(IList<NOTICEBOOK> collection)
        {
            MapperTemplate.InsertBatch< NOTICEBOOK>(collection);
        }
		
		/// <summary>
        /// 更新团购书籍关联的单一对象
        /// </summary>
        /// <param name="NOTICEBOOK">团购书籍关联的单一对象</param>
		public void Update(NOTICEBOOK NOTICEBOOK)
		{
			MapperTemplate.Update(NOTICEBOOK);
		}

		/// <summary>
        /// 批量更新团购书籍关联的对象数组
        /// </summary>
        /// <param name="collection">团购书籍关联的对象数组</param>
		public void Update(IList<NOTICEBOOK> collection)
		{
			MapperTemplate.UpdateBatch< NOTICEBOOK>(collection);
		}

		/// <summary>
        /// 删除团购书籍关联的单一对象
        /// </summary>
        /// <param name="NOTICEBOOK">团购书籍关联的单一对象(主键数据不能为空)</param>
		public void Delete(NOTICEBOOK NOTICEBOOK)
		{
			MapperTemplate.Delete(NOTICEBOOK);
		}

		/// <summary>
        /// 批量删除团购书籍关联的对象数组
        /// </summary>
        /// <param name="collection">团购书籍关联的对象数组(主键数据不能为空)</param>
		public void Delete(IList< NOTICEBOOK> collection)
		{
			MapperTemplate.DeleteBatch< NOTICEBOOK>(collection);
		}

		/// <summary>
        /// 查找团购书籍关联的单一对象
        /// </summary>
        /// <param name="NOTICEBOOK">NOTICEBOOK(主键数据不能为空)</param>
        /// <returns>团购书籍关联对象</returns>
        public NOTICEBOOK FindOnly(NOTICEBOOK NOTICEBOOK)
        {
            return MapperTemplate.FindOnly(NOTICEBOOK);
        }
		
		/// <summary>
        /// 查询团购书籍关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>团购书籍关联的对象数组</returns>
		public IList< NOTICEBOOK> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< NOTICEBOOK>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计团购书籍关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< NOTICEBOOK>(conditionCollection);
		}

		/// <summary>
        /// 团购书籍关联分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>团购书籍关联的对象数组</returns>
		public IList< NOTICEBOOK> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< NOTICEBOOK>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
