using System.Data;
using System.Collections.Generic;
using System.Collections;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IDao
{
	/// <summary>
	/// 系统参数
	/// </summary>
    public interface ISYSPARAMETERDao
    {
		/// <summary>
        /// 插入系统参数的单一对象
        /// </summary>
        /// <param name="SYSPARAMETER">系统参数的单一对象</param>
        /// <returns>当前操作的系统参数对象</returns>
		SYSPARAMETER Insert(SYSPARAMETER SYSPARAMETER);

		/// <summary>
        /// 批量插入系统参数的对象数组
        /// </summary>
        /// <param name="collection">系统参数的对象数组</param>
        void Insert(IList<SYSPARAMETER> collection);
		
		/// <summary>
        /// 批量更新系统参数的对象数组
        /// </summary>
        /// <param name="collection">系统参数的对象数组</param>
		void Update(SYSPARAMETER SYSPARAMETER);

		/// <summary>
        /// 批量更新系统参数的对象数组
        /// </summary>
        /// <param name="collection">系统参数的对象数组</param>
		void Update(IList<SYSPARAMETER> collection);

		/// <summary>
        /// 删除系统参数的单一对象
        /// </summary>
        /// <param name="SYSPARAMETER">系统参数的单一对象(主键数据不能为空)</param>
		void Delete(SYSPARAMETER SYSPARAMETER);

		/// <summary>
        /// 批量删除系统参数的对象数组
        /// </summary>
        /// <param name="collection">系统参数的对象数组(主键数据不能为空)</param>
		void Delete(IList< SYSPARAMETER> collection);

		/// <summary>
        /// 查找系统参数的单一对象
        /// </summary>
        /// <param name="SYSPARAMETER">SYSPARAMETER(主键数据不能为空)</param>
        /// <returns>系统参数对象</returns>
		SYSPARAMETER FindOnly(SYSPARAMETER SYSPARAMETER);
		
		/// <summary>
        /// 查询系统参数数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>系统参数的对象数组</returns>
		IList< SYSPARAMETER> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
		
		/// <summary>
        /// 统计系统参数数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);
		
		/// <summary>
        /// 系统参数分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>系统参数的对象数组</returns>
		IList< SYSPARAMETER> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
	
	}
}
