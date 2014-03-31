using System.Web;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IService
{
	/// <summary>
	/// 数据库备份
	/// </summary>
    public interface ISYSDATABASEBACKUPService
    {
		/// <summary>
        /// 插入数据库备份的单一对象
        /// </summary>
        /// <param name="SYSDATABASEBACKUP">数据库备份的单一对象</param>
        /// <returns>当前操作的数据库备份对象</returns>
  	    SYSDATABASEBACKUP Insert(SYSDATABASEBACKUP SYSDATABASEBACKUP);
		
		/// <summary>
        /// 更新数据库备份的单一对象
        /// </summary>
        /// <param name="SYSDATABASEBACKUP">数据库备份的单一对象</param>
		void Update(SYSDATABASEBACKUP SYSDATABASEBACKUP);

		/// <summary>
        /// 删除数据库备份的单一对象
        /// </summary>
        /// <param name="SYSDATABASEBACKUP">数据库备份的单一对象(主键数据不能为空)</param>
		void Delete(SYSDATABASEBACKUP SYSDATABASEBACKUP);
		
		/// <summary>
        /// 批量删除数据库备份的对象数组
        /// </summary>
        /// <param name="collection">数据库备份的对象数组(主键数据不能为空)</param>
		void Delete(IList< SYSDATABASEBACKUP > collection);

		/// <summary>
        /// 查找数据库备份的单一对象
        /// </summary>
        /// <param name="SYSDATABASEBACKUP">SYSDATABASEBACKUP(主键数据不能为空)</param>
        /// <returns>数据库备份对象</returns>
        SYSDATABASEBACKUP FindOnly(SYSDATABASEBACKUP SYSDATABASEBACKUP);
		
		/// <summary>
        /// 查询数据库备份数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>数据库备份的对象数组</returns>
		IList< SYSDATABASEBACKUP> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);

		/// <summary>
        /// 统计数据库备份数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);

		/// <summary>
        /// 数据库备份分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>数据库备份的对象数组</returns>
		IList< SYSDATABASEBACKUP> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);    
		
	}
}
