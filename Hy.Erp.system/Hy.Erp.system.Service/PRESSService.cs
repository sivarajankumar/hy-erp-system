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
    /// 出版社
    /// </summary>
    [TransactionManager]
	public class PRESSService:SupportService, IPRESSService
    {
	
        #region 属性
		
		/// <summary>
        /// 出版社，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(PRESSDao))]
		public IPRESSDao PRESSDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入出版社的单一对象
        /// </summary>
        /// <param name="PRESS">出版社的单一对象</param>
        /// <returns>当前操作的出版社对象</returns>
        public PRESS Insert(PRESS PRESS)
        {
			return PRESSDao.Insert(PRESS);
        }
		
		/// <summary>
        /// 更新出版社的单一对象
        /// </summary>
        /// <param name="PRESS">出版社的单一对象</param>
        public void Update(PRESS PRESS)
        {
            PRESSDao.Update(PRESS);
        }
		
		/// <summary>
        /// 删除出版社的单一对象
        /// </summary>
        /// <param name="PRESS">出版社的单一对象(主键数据不能为空)</param>
        public void Delete(PRESS PRESS)
        {
             PRESSDao.Delete(PRESS);
        }
		
		/// <summary>
        /// 批量删除出版社的对象数组
        /// </summary>
        /// <param name="collection">出版社的对象数组(主键数据不能为空)</param>
        public void Delete(IList< PRESS >  collection)
        {
            PRESSDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找出版社的单一对象
        /// </summary>
        /// <param name="PRESS">PRESS(主键数据不能为空)</param>
        /// <returns>出版社对象</returns>
        public PRESS FindOnly(PRESS PRESS)
        {
            return PRESSDao.FindOnly(PRESS);
        }
		
		/// <summary>
        /// 查询出版社数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>出版社的对象数组</returns>
		public IList< PRESS> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  PRESSDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计出版社数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return PRESSDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 出版社分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>出版社的对象数组</returns>
		public IList< PRESS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return PRESSDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
