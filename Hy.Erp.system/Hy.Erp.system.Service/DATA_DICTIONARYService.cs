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
    /// 数据细项
    /// </summary>
    [TransactionManager]
	public class DATADICTIONARYService:SupportService, IDATADICTIONARYService
    {
	
        #region 属性
		
		/// <summary>
        /// 数据细项，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(DATADICTIONARYDao))]
		public IDATADICTIONARYDao DATADICTIONARYDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入数据细项的单一对象
        /// </summary>
        /// <param name="DATADICTIONARY">数据细项的单一对象</param>
        /// <returns>当前操作的数据细项对象</returns>
        public DATADICTIONARY Insert(DATADICTIONARY DATADICTIONARY)
        {
			return DATADICTIONARYDao.Insert(DATADICTIONARY);
        }
		
		/// <summary>
        /// 更新数据细项的单一对象
        /// </summary>
        /// <param name="DATADICTIONARY">数据细项的单一对象</param>
        public void Update(DATADICTIONARY DATADICTIONARY)
        {
            DATADICTIONARYDao.Update(DATADICTIONARY);
        }
		
		/// <summary>
        /// 删除数据细项的单一对象
        /// </summary>
        /// <param name="DATADICTIONARY">数据细项的单一对象(主键数据不能为空)</param>
        public void Delete(DATADICTIONARY DATADICTIONARY)
        {
             DATADICTIONARYDao.Delete(DATADICTIONARY);
        }
		
		/// <summary>
        /// 批量删除数据细项的对象数组
        /// </summary>
        /// <param name="collection">数据细项的对象数组(主键数据不能为空)</param>
        public void Delete(IList< DATADICTIONARY >  collection)
        {
            DATADICTIONARYDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找数据细项的单一对象
        /// </summary>
        /// <param name="DATADICTIONARY">DATADICTIONARY(主键数据不能为空)</param>
        /// <returns>数据细项对象</returns>
        public DATADICTIONARY FindOnly(DATADICTIONARY DATADICTIONARY)
        {
            return DATADICTIONARYDao.FindOnly(DATADICTIONARY);
        }
		
		/// <summary>
        /// 查询数据细项数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>数据细项的对象数组</returns>
		public IList< DATADICTIONARY> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  DATADICTIONARYDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计数据细项数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return DATADICTIONARYDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 数据细项分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>数据细项的对象数组</returns>
		public IList< DATADICTIONARY> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return DATADICTIONARYDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
