using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 数据库备份 
	/// </summary>
	[Serializable, Table(TableName = "SYSDATABASEBACKUP")]
	public class SYSDATABASEBACKUP : MapperEntity
		{
		private  int _iD = 0;
		private  string _nAME = string.Empty;
		private  string _pATH = string.Empty;
		private  int _uSER = 0;
		private  string _uSERNAME = string.Empty;
		private  DateTime _tIME = DateTime.Now;
		private  string _dESCRIPTION = string.Empty;
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
        /// 名称
        /// </summary>
		[Colum(ColumName = "NAME", DbTypeAttr =DbType.String)]
		public string NAME
		{
			get { return _nAME; }
			
			set { _nAME = value; }
			
		}

		/// <summary>
        /// 路径
        /// </summary>
		[Colum(ColumName = "PATH", DbTypeAttr =DbType.String)]
		public string PATH
		{
			get { return _pATH; }
			
			set { _pATH = value; }
			
		}

		/// <summary>
        /// 用户
        /// </summary>
		[Colum(ColumName = "USER", DbTypeAttr =DbType.Int32)]
		public int USER
		{
			get { return _uSER; }
			
			set { _uSER = value; }
			
		}

		/// <summary>
        /// 用户名称
        /// </summary>
		[Colum(ColumName = "USER_NAME", DbTypeAttr =DbType.String)]
		public string USERNAME
		{
			get { return _uSERNAME; }
			
			set { _uSERNAME = value; }
			
		}

		/// <summary>
        /// 时间
        /// </summary>
		[Colum(ColumName = "TIME", DbTypeAttr =DbType.DateTime)]
		public DateTime TIME
		{
			get { return _tIME; }
			
			set { _tIME = value; }
			
		}

		/// <summary>
        /// 描述
        /// </summary>
		[Colum(ColumName = "DESCRIPTION", DbTypeAttr =DbType.String)]
		public string DESCRIPTION
		{
			get { return _dESCRIPTION; }
			
			set { _dESCRIPTION = value; }
			
		}

	}


}
