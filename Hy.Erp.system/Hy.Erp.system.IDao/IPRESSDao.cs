using System.Data;
using System.Collections.Generic;
using System.Collections;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IDao
{
	/// <summary>
	/// 出版社
	/// </summary>
    public interface IPRESSDao
    {
		/// <summary>
        /// 插入出版社的单一对象
        /// </summary>
        /// <param name="PRESS">出版社的单一对象</param>
        /// <returns>当前操作的出版社对象</returns>
		PRESS Insert(PRESS PRESS);

		/// <summary>
        /// 批量插入出版社的对象数组
        /// </summary>
        /// <param name="collection">出版社的对象数组</param>
        void Insert(IList<PRESS> collection);
		
		/// <summary>
        /// 批量更新出版社的对象数组
        /// </summary>
        /// <param name="collection">出版社的对象数组</param>
		void Update(PRESS PRESS);

		/// <summary>
        /// 批量更新出版社的对象数组
        /// </summary>
        /// <param name="collection">出版社的对象数组</param>
		void Update(IList<PRESS> collection);

		/// <summary>
        /// 删除出版社的单一对象
        /// </summary>
        /// <param name="PRESS">出版社的单一对象(主键数据不能为空)</param>
		void Delete(PRESS PRESS);

		/// <summary>
        /// 批量删除出版社的对象数组
        /// </summary>
        /// <param name="collection">出版社的对象数组(主键数据不能为空)</param>
		void Delete(IList< PRESS> collection);

		/// <summary>
        /// 查找出版社的单一对象
        /// </summary>
        /// <param name="PRESS">PRESS(主键数据不能为空)</param>
        /// <returns>出版社对象</returns>
		PRESS FindOnly(PRESS PRESS);
		
		/// <summary>
        /// 查询出版社数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>出版社的对象数组</returns>
		IList< PRESS> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
		
		/// <summary>
        /// 统计出版社数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);
		
		/// <summary>
        /// 出版社分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>出版社的对象数组</returns>
		IList< PRESS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
	
	}
}
