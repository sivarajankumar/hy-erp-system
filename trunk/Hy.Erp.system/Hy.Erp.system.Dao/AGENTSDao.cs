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
	/// 书代理商，数据访问
	/// </summary>
	public class AGENTSDao : MapperDaoSupport, IAGENTSDao
	{
		/// <summary>
        /// 插入书代理商的单一对象
        /// </summary>
        /// <param name="AGENTS">书代理商的单一对象</param>
        /// <returns>当前操作的书代理商对象</returns>
		public AGENTS Insert(AGENTS AGENTS)
		{
			AGENTS.ID = Convert.ToInt32(MapperTemplate.Insert(AGENTS));
			return AGENTS;
		}
		
		/// <summary>
        /// 批量插入书代理商的对象数组
        /// </summary>
        /// <param name="collection">书代理商的对象数组</param>
        public void Insert(IList<AGENTS> collection)
        {
            MapperTemplate.InsertBatch< AGENTS>(collection);
        }
		
		/// <summary>
        /// 更新书代理商的单一对象
        /// </summary>
        /// <param name="AGENTS">书代理商的单一对象</param>
		public void Update(AGENTS AGENTS)
		{
			MapperTemplate.Update(AGENTS);
		}

		/// <summary>
        /// 批量更新书代理商的对象数组
        /// </summary>
        /// <param name="collection">书代理商的对象数组</param>
		public void Update(IList<AGENTS> collection)
		{
			MapperTemplate.UpdateBatch< AGENTS>(collection);
		}

		/// <summary>
        /// 删除书代理商的单一对象
        /// </summary>
        /// <param name="AGENTS">书代理商的单一对象(主键数据不能为空)</param>
		public void Delete(AGENTS AGENTS)
		{
			MapperTemplate.Delete(AGENTS);
		}

		/// <summary>
        /// 批量删除书代理商的对象数组
        /// </summary>
        /// <param name="collection">书代理商的对象数组(主键数据不能为空)</param>
		public void Delete(IList< AGENTS> collection)
		{
			MapperTemplate.DeleteBatch< AGENTS>(collection);
		}

		/// <summary>
        /// 查找书代理商的单一对象
        /// </summary>
        /// <param name="AGENTS">AGENTS(主键数据不能为空)</param>
        /// <returns>书代理商对象</returns>
        public AGENTS FindOnly(AGENTS AGENTS)
        {
            return MapperTemplate.FindOnly(AGENTS);
        }
		
		/// <summary>
        /// 查询书代理商数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书代理商的对象数组</returns>
		public IList< AGENTS> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< AGENTS>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计书代理商数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< AGENTS>(conditionCollection);
		}

		/// <summary>
        /// 书代理商分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书代理商的对象数组</returns>
		public IList< AGENTS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< AGENTS>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
