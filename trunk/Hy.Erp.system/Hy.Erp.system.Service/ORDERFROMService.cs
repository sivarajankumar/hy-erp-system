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
    /// 物流包装规格
    /// </summary>
    [TransactionManager]
	public class ORDERFROMService:SupportService, IORDERFROMService
    {
	
        #region 属性
		
		/// <summary>
        /// 物流包装规格，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(ORDERFROMDao))]
		public IORDERFROMDao ORDERFROMDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入物流包装规格的单一对象
        /// </summary>
        /// <param name="ORDERFROM">物流包装规格的单一对象</param>
        /// <returns>当前操作的物流包装规格对象</returns>
        public ORDERFROM Insert(ORDERFROM ORDERFROM)
        {
			return ORDERFROMDao.Insert(ORDERFROM);
        }
		
		/// <summary>
        /// 更新物流包装规格的单一对象
        /// </summary>
        /// <param name="ORDERFROM">物流包装规格的单一对象</param>
        public void Update(ORDERFROM ORDERFROM)
        {
            ORDERFROMDao.Update(ORDERFROM);
        }
		
		/// <summary>
        /// 删除物流包装规格的单一对象
        /// </summary>
        /// <param name="ORDERFROM">物流包装规格的单一对象(主键数据不能为空)</param>
        public void Delete(ORDERFROM ORDERFROM)
        {
             ORDERFROMDao.Delete(ORDERFROM);
        }
		
		/// <summary>
        /// 批量删除物流包装规格的对象数组
        /// </summary>
        /// <param name="collection">物流包装规格的对象数组(主键数据不能为空)</param>
        public void Delete(IList< ORDERFROM >  collection)
        {
            ORDERFROMDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找物流包装规格的单一对象
        /// </summary>
        /// <param name="ORDERFROM">ORDERFROM(主键数据不能为空)</param>
        /// <returns>物流包装规格对象</returns>
        public ORDERFROM FindOnly(ORDERFROM ORDERFROM)
        {
            return ORDERFROMDao.FindOnly(ORDERFROM);
        }
		
		/// <summary>
        /// 查询物流包装规格数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>物流包装规格的对象数组</returns>
		public IList< ORDERFROM> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  ORDERFROMDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计物流包装规格数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return ORDERFROMDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 物流包装规格分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>物流包装规格的对象数组</returns>
		public IList< ORDERFROM> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return ORDERFROMDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
