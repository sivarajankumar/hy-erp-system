using System.Data;
using System.Collections.Generic;
using System.Collections;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;

namespace Hy.Erp.system.IDao
{
	/// <summary>
	/// 书代理商
	/// </summary>
    public interface IAGENTSDao
    {
		/// <summary>
        /// 插入书代理商的单一对象
        /// </summary>
        /// <param name="AGENTS">书代理商的单一对象</param>
        /// <returns>当前操作的书代理商对象</returns>
		AGENTS Insert(AGENTS AGENTS);

		/// <summary>
        /// 批量插入书代理商的对象数组
        /// </summary>
        /// <param name="collection">书代理商的对象数组</param>
        void Insert(IList<AGENTS> collection);
		
		/// <summary>
        /// 批量更新书代理商的对象数组
        /// </summary>
        /// <param name="collection">书代理商的对象数组</param>
		void Update(AGENTS AGENTS);

		/// <summary>
        /// 批量更新书代理商的对象数组
        /// </summary>
        /// <param name="collection">书代理商的对象数组</param>
		void Update(IList<AGENTS> collection);

		/// <summary>
        /// 删除书代理商的单一对象
        /// </summary>
        /// <param name="AGENTS">书代理商的单一对象(主键数据不能为空)</param>
		void Delete(AGENTS AGENTS);

		/// <summary>
        /// 批量删除书代理商的对象数组
        /// </summary>
        /// <param name="collection">书代理商的对象数组(主键数据不能为空)</param>
		void Delete(IList< AGENTS> collection);

		/// <summary>
        /// 查找书代理商的单一对象
        /// </summary>
        /// <param name="AGENTS">AGENTS(主键数据不能为空)</param>
        /// <returns>书代理商对象</returns>
		AGENTS FindOnly(AGENTS AGENTS);
		
		/// <summary>
        /// 查询书代理商数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书代理商的对象数组</returns>
		IList< AGENTS> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
		
		/// <summary>
        /// 统计书代理商数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		int Count(ConditionCollection conditionCollection);
		
		/// <summary>
        /// 书代理商分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书代理商的对象数组</returns>
		IList< AGENTS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection);
	
	}
}
