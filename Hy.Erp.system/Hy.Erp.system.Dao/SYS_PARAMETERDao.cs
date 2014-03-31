using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using HP.Mapper.Core.Support;
using HP.Mapper.Common;
using Hy.Erp.system.Entity;
using Hy.Erp.system.IDao;

namespace Hy.Erp.system.Dao
{
	/// <summary>
	/// 系统参数，数据访问
	/// </summary>
	public class SYSPARAMETERDao : MapperDaoSupport, ISYSPARAMETERDao
	{
		/// <summary>
        /// 插入系统参数的单一对象
        /// </summary>
        /// <param name="SYSPARAMETER">系统参数的单一对象</param>
        /// <returns>当前操作的系统参数对象</returns>
		public SYSPARAMETER Insert(SYSPARAMETER SYSPARAMETER)
		{
			SYSPARAMETER.ID = Convert.ToInt32(MapperTemplate.Insert(SYSPARAMETER));
			return SYSPARAMETER;
		}
		
		/// <summary>
        /// 批量插入系统参数的对象数组
        /// </summary>
        /// <param name="collection">系统参数的对象数组</param>
        public void Insert(IList<SYSPARAMETER> collection)
        {
            MapperTemplate.InsertBatch< SYSPARAMETER>(collection);
        }
		
		/// <summary>
        /// 更新系统参数的单一对象
        /// </summary>
        /// <param name="SYSPARAMETER">系统参数的单一对象</param>
		public void Update(SYSPARAMETER SYSPARAMETER)
		{
			MapperTemplate.Update(SYSPARAMETER);
		}

		/// <summary>
        /// 批量更新系统参数的对象数组
        /// </summary>
        /// <param name="collection">系统参数的对象数组</param>
		public void Update(IList<SYSPARAMETER> collection)
		{
			MapperTemplate.UpdateBatch< SYSPARAMETER>(collection);
		}

		/// <summary>
        /// 删除系统参数的单一对象
        /// </summary>
        /// <param name="SYSPARAMETER">系统参数的单一对象(主键数据不能为空)</param>
		public void Delete(SYSPARAMETER SYSPARAMETER)
		{
			MapperTemplate.Delete(SYSPARAMETER);
		}

		/// <summary>
        /// 批量删除系统参数的对象数组
        /// </summary>
        /// <param name="collection">系统参数的对象数组(主键数据不能为空)</param>
		public void Delete(IList< SYSPARAMETER> collection)
		{
			MapperTemplate.DeleteBatch< SYSPARAMETER>(collection);
		}

		/// <summary>
        /// 查找系统参数的单一对象
        /// </summary>
        /// <param name="SYSPARAMETER">SYSPARAMETER(主键数据不能为空)</param>
        /// <returns>系统参数对象</returns>
        public SYSPARAMETER FindOnly(SYSPARAMETER SYSPARAMETER)
        {
            return MapperTemplate.FindOnly(SYSPARAMETER);
        }
		
		/// <summary>
        /// 查询系统参数数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>系统参数的对象数组</returns>
		public IList< SYSPARAMETER> Find(ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Find< SYSPARAMETER>(conditionCollection, sortOrderCollection);
		}

		/// <summary>
        /// 统计系统参数数据
        /// </summary>
        /// <param name="conditionCollection">查询条件</param>
        /// <returns>数量</returns>
		public int Count(ConditionCollection conditionCollection = null)
		{
			return MapperTemplate.Count< SYSPARAMETER>(conditionCollection);
		}

		/// <summary>
        /// 系统参数分页
        /// </summary>
        /// <param name="total">ref 总条数</param>
        /// <param name="start">开始分页的数目</param>
        /// <param name="limit">每页显示的条数</param>
        /// <param name="conditionCollection">查询条件</param>
        /// <param name="sortOrderCollection">排序方式</param>
        /// <returns>系统参数的对象数组</returns>
		public IList< SYSPARAMETER> Pages(ref int total, int start, int limit, ConditionCollection conditionCollection = null, SortOrderCollection sortOrderCollection = null)
		{
			return MapperTemplate.Pages< SYSPARAMETER>(ref total, start, limit, conditionCollection, sortOrderCollection);
		}
	}
}
