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
    /// 团购通知单
    /// </summary>
    [TransactionManager]
	public class NOTICEService:SupportService, INOTICEService
    {
	
        #region 属性
		
		/// <summary>
        /// 团购通知单，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(NOTICEDao))]
		public INOTICEDao NOTICEDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入团购通知单的单一对象
        /// </summary>
        /// <param name="NOTICE">团购通知单的单一对象</param>
        /// <returns>当前操作的团购通知单对象</returns>
        public NOTICE Insert(NOTICE NOTICE)
        {
			return NOTICEDao.Insert(NOTICE);
        }
		
		/// <summary>
        /// 更新团购通知单的单一对象
        /// </summary>
        /// <param name="NOTICE">团购通知单的单一对象</param>
        public void Update(NOTICE NOTICE)
        {
            NOTICEDao.Update(NOTICE);
        }
		
		/// <summary>
        /// 删除团购通知单的单一对象
        /// </summary>
        /// <param name="NOTICE">团购通知单的单一对象(主键数据不能为空)</param>
        public void Delete(NOTICE NOTICE)
        {
             NOTICEDao.Delete(NOTICE);
        }
		
		/// <summary>
        /// 批量删除团购通知单的对象数组
        /// </summary>
        /// <param name="collection">团购通知单的对象数组(主键数据不能为空)</param>
        public void Delete(IList< NOTICE >  collection)
        {
            NOTICEDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找团购通知单的单一对象
        /// </summary>
        /// <param name="NOTICE">NOTICE(主键数据不能为空)</param>
        /// <returns>团购通知单对象</returns>
        public NOTICE FindOnly(NOTICE NOTICE)
        {
            return NOTICEDao.FindOnly(NOTICE);
        }
		
		/// <summary>
        /// 查询团购通知单数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>团购通知单的对象数组</returns>
		public IList< NOTICE> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  NOTICEDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计团购通知单数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return NOTICEDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 团购通知单分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>团购通知单的对象数组</returns>
		public IList< NOTICE> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return NOTICEDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
