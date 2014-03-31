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
    /// 团购书籍关联
    /// </summary>
    [TransactionManager]
	public class NOTICEBOOKService:SupportService, INOTICEBOOKService
    {
	
        #region 属性
		
		/// <summary>
        /// 团购书籍关联，数据操作对象
        /// </summary>
		[IoC(ClassType = typeof(NOTICEBOOKDao))]
		public INOTICEBOOKDao NOTICEBOOKDao { get; set; }
		
        #endregion
		
		/// <summary>
        /// 插入团购书籍关联的单一对象
        /// </summary>
        /// <param name="NOTICEBOOK">团购书籍关联的单一对象</param>
        /// <returns>当前操作的团购书籍关联对象</returns>
        public NOTICEBOOK Insert(NOTICEBOOK NOTICEBOOK)
        {
			return NOTICEBOOKDao.Insert(NOTICEBOOK);
        }
		
		/// <summary>
        /// 更新团购书籍关联的单一对象
        /// </summary>
        /// <param name="NOTICEBOOK">团购书籍关联的单一对象</param>
        public void Update(NOTICEBOOK NOTICEBOOK)
        {
            NOTICEBOOKDao.Update(NOTICEBOOK);
        }
		
		/// <summary>
        /// 删除团购书籍关联的单一对象
        /// </summary>
        /// <param name="NOTICEBOOK">团购书籍关联的单一对象(主键数据不能为空)</param>
        public void Delete(NOTICEBOOK NOTICEBOOK)
        {
             NOTICEBOOKDao.Delete(NOTICEBOOK);
        }
		
		/// <summary>
        /// 批量删除团购书籍关联的对象数组
        /// </summary>
        /// <param name="collection">团购书籍关联的对象数组(主键数据不能为空)</param>
        public void Delete(IList< NOTICEBOOK >  collection)
        {
            NOTICEBOOKDao.Delete(collection);
        }
		
		/// <summary>
        /// 查找团购书籍关联的单一对象
        /// </summary>
        /// <param name="NOTICEBOOK">NOTICEBOOK(主键数据不能为空)</param>
        /// <returns>团购书籍关联对象</returns>
        public NOTICEBOOK FindOnly(NOTICEBOOK NOTICEBOOK)
        {
            return NOTICEBOOKDao.FindOnly(NOTICEBOOK);
        }
		
		/// <summary>
        /// 查询团购书籍关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>团购书籍关联的对象数组</returns>
		public IList< NOTICEBOOK> Find(ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return  NOTICEBOOKDao.Find(conditionCollection, sortOrderCollection);
        }
		
		/// <summary>
        /// 统计团购书籍关联数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection)
        {
            return NOTICEBOOKDao.Count(conditionCollection);
        }
		
		/// <summary>
        /// 团购书籍关联分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>团购书籍关联的对象数组</returns>
		public IList< NOTICEBOOK> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection, SortOrderCollection sortOrderCollection)
        {
            return NOTICEBOOKDao.Pages(ref total, start, limit, conditionCollection, sortOrderCollection);
        }
    }
}
