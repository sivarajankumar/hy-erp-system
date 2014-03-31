using System.Web;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IService
{
	/// <summary>
	/// 书籍代理商关联
	/// </summary>
    public interface IBOOKSAGENTSService
    {
		/// <summary>
        /// 插入书籍代理商关联的单一对象
        /// </summary>
        /// <param name="BOOKSAGENTS">书籍代理商关联的单一对象</param>
        /// <returns>当前操作的书籍代理商关联对象</returns>
  	    BOOKSAGENTS Insert(BOOKSAGENTS BOOKSAGENTS);
		
		/// <summary>
        /// 更新书籍代理商关联的单一对象
        /// </summary>
        /// <param name="BOOKSAGENTS">书籍代理商关联的单一对象</param>
		void Update(BOOKSAGENTS BOOKSAGENTS);

		/// <summary>
        /// 删除书籍代理商关联的单一对象
        /// </summary>
        /// <param name="BOOKSAGENTS">书籍代理商关联的单一对象(主键数据不能为空)</param>
		void Delete(BOOKSAGENTS BOOKSAGENTS);
		
		/// <summary>
        /// 批量删除书籍代理商关联的对象数组
        /// </summary>
        /// <param name="collection">书籍代理商关联的对象数组(主键数据不能为空)</param>
		void Delete(IList< BOOKSAGENTS > collection);

		/// <summary>
        /// 查找书籍代理商关联的单一对象
        /// </summary>
        /// <param name="BOOKSAGENTS">BOOKSAGENTS(主键数据不能为空)</param>
        /// <returns>书籍代理商关联对象</returns>
        BOOKSAGENTS FindOnly(BOOKSAGENTS BOOKSAGENTS);
		
		/// <summary>
        /// 查询书籍代理商关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书籍代理商关联的对象数组</returns>
		IList< BOOKSAGENTS> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);

		/// <summary>
        /// 统计书籍代理商关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);

		/// <summary>
        /// 书籍代理商关联分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书籍代理商关联的对象数组</returns>
		IList< BOOKSAGENTS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);    
		
	}
}
