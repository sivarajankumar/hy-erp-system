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
    /// 包装规格
    /// </summary>
    [TransactionManager]
	public class STANDARDService:SupportService, ISTANDARDService
    {
	
        #region 属性
		
		/// <summary>
        /// 包装规格，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(STANDARDDao))]
		public ISTANDARDDao STANDARDDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入包装规格的单一对象
        /// </summary>
        /// <param name="STANDARD">包装规格的单一对象</param>
        /// <returns>当前操作的包装规格对象</returns>
        public STANDARD Insert(STANDARD STANDARD)
        {
			return STANDARDDao.Insert(STANDARD);
        }
		
		/// <summary>
        /// 更新包装规格的单一对象
        /// </summary>
        /// <param name="STANDARD">包装规格的单一对象</param>
        public void Update(STANDARD STANDARD)
        {
            STANDARDDao.Update(STANDARD);
        }
		
		/// <summary>
        /// 删除包装规格的单一对象
        /// </summary>
        /// <param name="STANDARD">包装规格的单一对象(主键数据不能为空)</param>
        public void Delete(STANDARD STANDARD)
        {
             STANDARDDao.Delete(STANDARD);
        }
		
		/// <summary>
        /// 批量删除包装规格的对象数组
        /// </summary>
        /// <param name="collection">包装规格的对象数组(主键数据不能为空)</param>
        public void Delete(IList< STANDARD >  collection)
        {
            STANDARDDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找包装规格的单一对象
        /// </summary>
        /// <param name="STANDARD">STANDARD(主键数据不能为空)</param>
        /// <returns>包装规格对象</returns>
        public STANDARD FindOnly(STANDARD STANDARD)
        {
            return STANDARDDao.FindOnly(STANDARD);
        }
		
		/// <summary>
        /// 查询包装规格数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>包装规格的对象数组</returns>
		public IList< STANDARD> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  STANDARDDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计包装规格数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return STANDARDDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 包装规格分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>包装规格的对象数组</returns>
		public IList< STANDARD> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return STANDARDDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
