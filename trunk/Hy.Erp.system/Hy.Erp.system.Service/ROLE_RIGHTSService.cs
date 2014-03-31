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
    /// 角色权限关联
    /// </summary>
    [TransactionManager]
	public class ROLERIGHTSService:SupportService, IROLERIGHTSService
    {
	
        #region 属性
		
		/// <summary>
        /// 角色权限关联，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(ROLERIGHTSDao))]
		public IROLERIGHTSDao ROLERIGHTSDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入角色权限关联的单一对象
        /// </summary>
        /// <param name="ROLERIGHTS">角色权限关联的单一对象</param>
        /// <returns>当前操作的角色权限关联对象</returns>
        public ROLERIGHTS Insert(ROLERIGHTS ROLERIGHTS)
        {
			return ROLERIGHTSDao.Insert(ROLERIGHTS);
        }
		
		/// <summary>
        /// 更新角色权限关联的单一对象
        /// </summary>
        /// <param name="ROLERIGHTS">角色权限关联的单一对象</param>
        public void Update(ROLERIGHTS ROLERIGHTS)
        {
            ROLERIGHTSDao.Update(ROLERIGHTS);
        }
		
		/// <summary>
        /// 删除角色权限关联的单一对象
        /// </summary>
        /// <param name="ROLERIGHTS">角色权限关联的单一对象(主键数据不能为空)</param>
        public void Delete(ROLERIGHTS ROLERIGHTS)
        {
             ROLERIGHTSDao.Delete(ROLERIGHTS);
        }
		
		/// <summary>
        /// 批量删除角色权限关联的对象数组
        /// </summary>
        /// <param name="collection">角色权限关联的对象数组(主键数据不能为空)</param>
        public void Delete(IList< ROLERIGHTS >  collection)
        {
            ROLERIGHTSDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找角色权限关联的单一对象
        /// </summary>
        /// <param name="ROLERIGHTS">ROLERIGHTS(主键数据不能为空)</param>
        /// <returns>角色权限关联对象</returns>
        public ROLERIGHTS FindOnly(ROLERIGHTS ROLERIGHTS)
        {
            return ROLERIGHTSDao.FindOnly(ROLERIGHTS);
        }
		
		/// <summary>
        /// 查询角色权限关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>角色权限关联的对象数组</returns>
		public IList< ROLERIGHTS> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  ROLERIGHTSDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计角色权限关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return ROLERIGHTSDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 角色权限关联分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>角色权限关联的对象数组</returns>
		public IList< ROLERIGHTS> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return ROLERIGHTSDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
