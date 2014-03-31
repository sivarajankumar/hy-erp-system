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
	/// 书籍条目，数据访问
	/// </summary>
	public class BOOKSDao : MapperDaoSupport, IBOOKSDao
	{
		/// <summary>
        /// 插入书籍条目的单一对象
        /// </summary>
        /// <param name="BOOKS">书籍条目的单一对象</param>
        /// <returns>当前操作的书籍条目对象</returns>
		public BOOKS Insert(BOOKS BOOKS)
		{
			BOOKS.ID = Convert.ToInt32(MapperTemplate.Insert(BOOKS));
			return BOOKS;
		}
		
		/// <summary>
        /// 批量插入书籍条目的对象数组
        /// </summary>
        /// <param name="collection">书籍条目的对象数组</param>
        public void Insert(IList<BOOKS> collection)
        {
            MapperTemplate.InsertBatch< BOOKS>(collection);
        }
		
		/// <summary>
        /// 更新书籍条目的单一对象
        /// </summary>
        /// <param name="BOOKS">书籍条目的单一对象</param>
		public void Update(BOOKS BOOKS)
		{
			MapperTemplate.Update(BOOKS);
		}

		/// <summary>
        /// 批量更新书籍条目的对象数组
        /// </summary>
        /// <param name="collection">书籍条目的对象数组</param>
		public void Update(IList<BOOKS> collection)
		{
			MapperTemplate.UpdateBatch< BOOKS>(collection);
		}

		/// <summary>
        /// 删除书籍条目的单一对象
        /// </summary>
        /// <param name="BOOKS">书籍条目的单一对象(主键数据不能为空)</param>
		public void Delete(BOOKS BOOKS)
		{
			MapperTemplate.Delete(BOOKS);
		}

		/// <summary>
        /// 批量删除书籍条目的对象数组
        /// </summary>
        /// <param name="collection">书籍条目的对象数组(主键数据不能为空)</param>
		public void Delete(IList< BOOKS> collection)
		{
			MapperTemplate.DeleteBatch< BOOKS>(collection);
		}

		/// <summary>
        /// 查找书籍条目的单一对象
        /// </summary>
        /// <param name="BOOKS">BOOKS(主键数据不能为空)</param>
        /// <returns>书籍条目对象</returns>
        public BOOKS FindOnly(BOOKS BOOKS)
        {
            return MapperTemplate.FindOnly(BOOKS);
        }
		
		/// <summary>
        /// 查询书籍条目数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书籍条目的对象数组</returns>
		public IList< BOOKS> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< BOOKS>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计书籍条目数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< BOOKS>(conditionCollection);
		}

		/// <summary>
        /// 书籍条目分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书籍条目的对象数组</returns>
		public IList< BOOKS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< BOOKS>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
