using System.Data;
using System.Collections.Generic;
using System.Collections;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IDao
{
	/// <summary>
	/// 班级
	/// </summary>
    public interface IDEPTDao
    {
		/// <summary>
        /// 插入班级的单一对象
        /// </summary>
        /// <param name="DEPT">班级的单一对象</param>
        /// <returns>当前操作的班级对象</returns>
		DEPT Insert(DEPT DEPT);

		/// <summary>
        /// 批量插入班级的对象数组
        /// </summary>
        /// <param name="collection">班级的对象数组</param>
        void Insert(IList<DEPT> collection);
		
		/// <summary>
        /// 批量更新班级的对象数组
        /// </summary>
        /// <param name="collection">班级的对象数组</param>
		void Update(DEPT DEPT);

		/// <summary>
        /// 批量更新班级的对象数组
        /// </summary>
        /// <param name="collection">班级的对象数组</param>
		void Update(IList<DEPT> collection);

		/// <summary>
        /// 删除班级的单一对象
        /// </summary>
        /// <param name="DEPT">班级的单一对象(主键数据不能为空)</param>
		void Delete(DEPT DEPT);

		/// <summary>
        /// 批量删除班级的对象数组
        /// </summary>
        /// <param name="collection">班级的对象数组(主键数据不能为空)</param>
		void Delete(IList< DEPT> collection);

		/// <summary>
        /// 查找班级的单一对象
        /// </summary>
        /// <param name="DEPT">DEPT(主键数据不能为空)</param>
        /// <returns>班级对象</returns>
		DEPT FindOnly(DEPT DEPT);
		
		/// <summary>
        /// 查询班级数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>班级的对象数组</returns>
		IList< DEPT> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
		
		/// <summary>
        /// 统计班级数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);
		
		/// <summary>
        /// 班级分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>班级的对象数组</returns>
		IList< DEPT> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
	
	}
}
