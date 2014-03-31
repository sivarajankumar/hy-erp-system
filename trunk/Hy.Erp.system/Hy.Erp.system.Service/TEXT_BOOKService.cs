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
    /// 购书单
    /// </summary>
    [TransactionManager]
	public class TEXTBOOKService:SupportService, ITEXTBOOKService
    {
	
        #region 属性
		
		/// <summary>
        /// 购书单，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(TEXTBOOKDao))]
		public ITEXTBOOKDao TEXTBOOKDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入购书单的单一对象
        /// </summary>
        /// <param name="TEXTBOOK">购书单的单一对象</param>
        /// <returns>当前操作的购书单对象</returns>
        public TEXTBOOK Insert(TEXTBOOK TEXTBOOK)
        {
			return TEXTBOOKDao.Insert(TEXTBOOK);
        }
		
		/// <summary>
        /// 更新购书单的单一对象
        /// </summary>
        /// <param name="TEXTBOOK">购书单的单一对象</param>
        public void Update(TEXTBOOK TEXTBOOK)
        {
            TEXTBOOKDao.Update(TEXTBOOK);
        }
		
		/// <summary>
        /// 删除购书单的单一对象
        /// </summary>
        /// <param name="TEXTBOOK">购书单的单一对象(主键数据不能为空)</param>
        public void Delete(TEXTBOOK TEXTBOOK)
        {
             TEXTBOOKDao.Delete(TEXTBOOK);
        }
		
		/// <summary>
        /// 批量删除购书单的对象数组
        /// </summary>
        /// <param name="collection">购书单的对象数组(主键数据不能为空)</param>
        public void Delete(IList< TEXTBOOK >  collection)
        {
            TEXTBOOKDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找购书单的单一对象
        /// </summary>
        /// <param name="TEXTBOOK">TEXTBOOK(主键数据不能为空)</param>
        /// <returns>购书单对象</returns>
        public TEXTBOOK FindOnly(TEXTBOOK TEXTBOOK)
        {
            return TEXTBOOKDao.FindOnly(TEXTBOOK);
        }
		
		/// <summary>
        /// 查询购书单数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>购书单的对象数组</returns>
		public IList< TEXTBOOK> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  TEXTBOOKDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计购书单数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return TEXTBOOKDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 购书单分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>购书单的对象数组</returns>
		public IList< TEXTBOOK> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return TEXTBOOKDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
