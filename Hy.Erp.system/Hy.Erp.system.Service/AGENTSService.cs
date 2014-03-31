using System;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using HP.Mapper.Service;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;
using Hy.Erp.system.Service.Support;
using Hy.Erp.system.IService;
using Hy.Erp.system.IDao;
using Hy.Erp.system.Dao;
using Hy.Erp.system.Common;

namespace Hy.Erp.system.Service
{
	 /// <summary>
    /// 书代理商
    /// </summary>
    [TransactionManager]
	public class AGENTSService:SupportService, IAGENTSService
    {
	
        #region 属性
		
		/// <summary>
        /// 书代理商，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(AGENTSDao))]
		public IAGENTSDao AGENTSDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入书代理商的单一对象
        /// </summary>
        /// <param name="AGENTS">书代理商的单一对象</param>
        /// <returns>当前操作的书代理商对象</returns>
        public AGENTS Insert(AGENTS AGENTS)
        {
			return AGENTSDao.Insert(AGENTS);
        }
		
		/// <summary>
        /// 更新书代理商的单一对象
        /// </summary>
        /// <param name="AGENTS">书代理商的单一对象</param>
        public void Update(AGENTS AGENTS)
        {
            AGENTSDao.Update(AGENTS);
        }
		
		/// <summary>
        /// 删除书代理商的单一对象
        /// </summary>
        /// <param name="AGENTS">书代理商的单一对象(主键数据不能为空)</param>
        public void Delete(AGENTS AGENTS)
        {
             AGENTSDao.Delete(AGENTS);
        }
		
		/// <summary>
        /// 批量删除书代理商的对象数组
        /// </summary>
        /// <param name="collection">书代理商的对象数组(主键数据不能为空)</param>
        public void Delete(IList< AGENTS >  collection)
        {
            AGENTSDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找书代理商的单一对象
        /// </summary>
        /// <param name="AGENTS">AGENTS(主键数据不能为空)</param>
        /// <returns>书代理商对象</returns>
        public AGENTS FindOnly(AGENTS AGENTS)
        {
            return AGENTSDao.FindOnly(AGENTS);
        }
		
		/// <summary>
        /// 查询书代理商数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>书代理商的对象数组</returns>
		public IList< AGENTS> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  AGENTSDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计书代理商数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return AGENTSDao.Count(conditionCollection);
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
		public IList< AGENTS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return AGENTSDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
