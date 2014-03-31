using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 系统参数 
	/// </summary>
	[Serializable, Table(TableName = "SYSPARAMETER")]
	public class SYSPARAMETER : MapperEntity
		{
		private  int _iD = 0;
		private  string _kEY = string.Empty;
		private  string _tEXT = string.Empty;
		private  int _sTATUS = 0;
		/// <summary>
        /// 标识
        /// </summary>
		[Colum(ColumName = "ID", DbTypeAttr =DbType.Int32,IsPrimaryKey = true, IsIdentity = true)]
		public int ID
		{
			get {return _iD;}
			set {_iD = value;}
		}

		/// <summary>
        /// 键
        /// </summary>
		[Colum(ColumName = "KEY", DbTypeAttr =DbType.String)]
		public string KEY
		{
			get { return _kEY; }
			
			set { _kEY = value; }
			
		}

		/// <summary>
        /// 值
        /// </summary>
		[Colum(ColumName = "TEXT", DbTypeAttr =DbType.String)]
		public string TEXT
		{
			get { return _tEXT; }
			
			set { _tEXT = value; }
			
		}

		/// <summary>
        /// 状态
        /// </summary>
		[Colum(ColumName = "STATUS", DbTypeAttr =DbType.Int32)]
		public int STATUS
		{
			get { return _sTATUS; }
			
			set { _sTATUS = value; }
			
		}

	}


}
