using System.Data;
using System.Collections.Generic;
using System.Collections;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IDao
{
	/// <summary>
	/// 团购书籍关联
	/// </summary>
    public interface INOTICEBOOKDao
    {
		/// <summary>
        /// 插入团购书籍关联的单一对象
        /// </summary>
        /// <param name="NOTICEBOOK">团购书籍关联的单一对象</param>
        /// <returns>当前操作的团购书籍关联对象</returns>
		NOTICEBOOK Insert(NOTICEBOOK NOTICEBOOK);

		/// <summary>
        /// 批量插入团购书籍关联的对象数组
        /// </summary>
        /// <param name="collection">团购书籍关联的对象数组</param>
        void Insert(IList<NOTICEBOOK> collection);
		
		/// <summary>
        /// 批量更新团购书籍关联的对象数组
        /// </summary>
        /// <param name="collection">团购书籍关联的对象数组</param>
		void Update(NOTICEBOOK NOTICEBOOK);

		/// <summary>
        /// 批量更新团购书籍关联的对象数组
        /// </summary>
        /// <param name="collection">团购书籍关联的对象数组</param>
		void Update(IList<NOTICEBOOK> collection);

		/// <summary>
        /// 删除团购书籍关联的单一对象
        /// </summary>
        /// <param name="NOTICEBOOK">团购书籍关联的单一对象(主键数据不能为空)</param>
		void Delete(NOTICEBOOK NOTICEBOOK);

		/// <summary>
        /// 批量删除团购书籍关联的对象数组
        /// </summary>
        /// <param name="collection">团购书籍关联的对象数组(主键数据不能为空)</param>
		void Delete(IList< NOTICEBOOK> collection);

		/// <summary>
        /// 查找团购书籍关联的单一对象
        /// </summary>
        /// <param name="NOTICEBOOK">NOTICEBOOK(主键数据不能为空)</param>
        /// <returns>团购书籍关联对象</returns>
		NOTICEBOOK FindOnly(NOTICEBOOK NOTICEBOOK);
		
		/// <summary>
        /// 查询团购书籍关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>团购书籍关联的对象数组</returns>
		IList< NOTICEBOOK> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
		
		/// <summary>
        /// 统计团购书籍关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);
		
		/// <summary>
        /// 团购书籍关联分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>团购书籍关联的对象数组</returns>
		IList< NOTICEBOOK> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
	
	}
}
