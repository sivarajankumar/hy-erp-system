using System.Web;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IService
{
	/// <summary>
	/// 教师
	/// </summary>
    public interface ITEACHERService
    {
		/// <summary>
        /// 插入教师的单一对象
        /// </summary>
        /// <param name="TEACHER">教师的单一对象</param>
        /// <returns>当前操作的教师对象</returns>
  	    TEACHER Insert(TEACHER TEACHER);
		
		/// <summary>
        /// 更新教师的单一对象
        /// </summary>
        /// <param name="TEACHER">教师的单一对象</param>
		void Update(TEACHER TEACHER);

		/// <summary>
        /// 删除教师的单一对象
        /// </summary>
        /// <param name="TEACHER">教师的单一对象(主键数据不能为空)</param>
		void Delete(TEACHER TEACHER);
		
		/// <summary>
        /// 批量删除教师的对象数组
        /// </summary>
        /// <param name="collection">教师的对象数组(主键数据不能为空)</param>
		void Delete(IList< TEACHER > collection);

		/// <summary>
        /// 查找教师的单一对象
        /// </summary>
        /// <param name="TEACHER">TEACHER(主键数据不能为空)</param>
        /// <returns>教师对象</returns>
        TEACHER FindOnly(TEACHER TEACHER);
		
		/// <summary>
        /// 查询教师数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>教师的对象数组</returns>
		IList< TEACHER> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);

		/// <summary>
        /// 统计教师数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);

		/// <summary>
        /// 教师分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>教师的对象数组</returns>
		IList< TEACHER> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);    
		
	}
}
