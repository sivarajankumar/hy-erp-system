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
    /// 数据种类
    /// </summary>
    [TransactionManager]
	public class DATATYPEService:SupportService, IDATATYPEService
    {
	
        #region 属性
		
		/// <summary>
        /// 数据种类，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(DATATYPEDao))]
		public IDATATYPEDao DATATYPEDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入数据种类的单一对象
        /// </summary>
        /// <param name="DATATYPE">数据种类的单一对象</param>
        /// <returns>当前操作的数据种类对象</returns>
        public DATATYPE Insert(DATATYPE DATATYPE)
        {
			return DATATYPEDao.Insert(DATATYPE);
        }
		
		/// <summary>
        /// 更新数据种类的单一对象
        /// </summary>
        /// <param name="DATATYPE">数据种类的单一对象</param>
        public void Update(DATATYPE DATATYPE)
        {
            DATATYPEDao.Update(DATATYPE);
        }
		
		/// <summary>
        /// 删除数据种类的单一对象
        /// </summary>
        /// <param name="DATATYPE">数据种类的单一对象(主键数据不能为空)</param>
        public void Delete(DATATYPE DATATYPE)
        {
             DATATYPEDao.Delete(DATATYPE);
        }
		
		/// <summary>
        /// 批量删除数据种类的对象数组
        /// </summary>
        /// <param name="collection">数据种类的对象数组(主键数据不能为空)</param>
        public void Delete(IList< DATATYPE >  collection)
        {
            DATATYPEDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找数据种类的单一对象
        /// </summary>
        /// <param name="DATATYPE">DATATYPE(主键数据不能为空)</param>
        /// <returns>数据种类对象</returns>
        public DATATYPE FindOnly(DATATYPE DATATYPE)
        {
            return DATATYPEDao.FindOnly(DATATYPE);
        }
		
		/// <summary>
        /// 查询数据种类数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>数据种类的对象数组</returns>
		public IList< DATATYPE> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  DATATYPEDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计数据种类数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return DATATYPEDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 数据种类分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>数据种类的对象数组</returns>
		public IList< DATATYPE> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return DATATYPEDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
