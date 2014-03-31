using System.Data;
using System.Collections.Generic;
using System.Collections;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IDao
{
	/// <summary>
	/// 学生
	/// </summary>
    public interface ISTUDENTSDao
    {
		/// <summary>
        /// 插入学生的单一对象
        /// </summary>
        /// <param name="STUDENTS">学生的单一对象</param>
        /// <returns>当前操作的学生对象</returns>
		STUDENTS Insert(STUDENTS STUDENTS);

		/// <summary>
        /// 批量插入学生的对象数组
        /// </summary>
        /// <param name="collection">学生的对象数组</param>
        void Insert(IList<STUDENTS> collection);
		
		/// <summary>
        /// 批量更新学生的对象数组
        /// </summary>
        /// <param name="collection">学生的对象数组</param>
		void Update(STUDENTS STUDENTS);

		/// <summary>
        /// 批量更新学生的对象数组
        /// </summary>
        /// <param name="collection">学生的对象数组</param>
		void Update(IList<STUDENTS> collection);

		/// <summary>
        /// 删除学生的单一对象
        /// </summary>
        /// <param name="STUDENTS">学生的单一对象(主键数据不能为空)</param>
		void Delete(STUDENTS STUDENTS);

		/// <summary>
        /// 批量删除学生的对象数组
        /// </summary>
        /// <param name="collection">学生的对象数组(主键数据不能为空)</param>
		void Delete(IList< STUDENTS> collection);

		/// <summary>
        /// 查找学生的单一对象
        /// </summary>
        /// <param name="STUDENTS">STUDENTS(主键数据不能为空)</param>
        /// <returns>学生对象</returns>
		STUDENTS FindOnly(STUDENTS STUDENTS);
		
		/// <summary>
        /// 查询学生数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>学生的对象数组</returns>
		IList< STUDENTS> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
		
		/// <summary>
        /// 统计学生数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);
		
		/// <summary>
        /// 学生分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>学生的对象数组</returns>
		IList< STUDENTS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
	
	}
}
