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
	/// 书籍代理商关联，数据访问
	/// </summary>
	public class BOOKSAGENTSDao : MapperDaoSupport, IBOOKSAGENTSDao
	{
		/// <summary>
        /// 插入书籍代理商关联的单一对象
        /// </summary>
        /// <param name="BOOKSAGENTS">书籍代理商关联的单一对象</param>
        /// <returns>当前操作的书籍代理商关联对象</returns>
		public BOOKSAGENTS Insert(BOOKSAGENTS BOOKSAGENTS)
		{
			BOOKSAGENTS.ID = Convert.ToInt32(MapperTemplate.Insert(BOOKSAGENTS));
			return BOOKSAGENTS;
		}
		
		/// <summary>
        /// 批量插入书籍代理商关联的对象数组
        /// </summary>
        /// <param name="collection">书籍代理商关联的对象数组</param>
        public void Insert(IList<BOOKSAGENTS> collection)
        {
            MapperTemplate.InsertBatch< BOOKSAGENTS>(collection);
        }
		
		/// <summary>
        /// 更新书籍代理商关联的单一对象
        /// </summary>
        /// <param name="BOOKSAGENTS">书籍代理商关联的单一对象</param>
		public void Update(BOOKSAGENTS BOOKSAGENTS)
		{
			MapperTemplate.Update(BOOKSAGENTS);
		}

		/// <summary>
        /// 批量更新书籍代理商关联的对象数组
        /// </summary>
        /// <param name="collection">书籍代理商关联的对象数组</param>
		public void Update(IList<BOOKSAGENTS> collection)
		{
			MapperTemplate.UpdateBatch< BOOKSAGENTS>(collection);
		}

		/// <summary>
        /// 删除书籍代理商关联的单一对象
        /// </summary>
        /// <param name="BOOKSAGENTS">书籍代理商关联的单一对象(主键数据不能为空)</param>
		public void Delete(BOOKSAGENTS BOOKSAGENTS)
		{
			MapperTemplate.Delete(BOOKSAGENTS);
		}

		/// <summary>
        /// 批量删除书籍代理商关联的对象数组
        /// </summary>
        /// <param name="collection">书籍代理商关联的对象数组(主键数据不能为空)</param>
		public void Delete(IList< BOOKSAGENTS> collection)
		{
			MapperTemplate.DeleteBatch< BOOKSAGENTS>(collection);
		}

		/// <summary>
        /// 查找书籍代理商关联的单一对象
        /// </summary>
        /// <param name="BOOKSAGENTS">BOOKSAGENTS(主键数据不能为空)</param>
        /// <returns>书籍代理商关联对象</returns>
        public BOOKSAGENTS FindOnly(BOOKSAGENTS BOOKSAGENTS)
        {
            return MapperTemplate.FindOnly(BOOKSAGENTS);
        }
		
		/// <summary>
        /// 查询书籍代理商关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书籍代理商关联的对象数组</returns>
		public IList< BOOKSAGENTS> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< BOOKSAGENTS>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计书籍代理商关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< BOOKSAGENTS>(conditionCollection);
		}

		/// <summary>
        /// 书籍代理商关联分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书籍代理商关联的对象数组</returns>
		public IList< BOOKSAGENTS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< BOOKSAGENTS>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
