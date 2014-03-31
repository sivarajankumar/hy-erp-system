using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 系统访问日志 
	/// </summary>
	[Serializable, Table(TableName = "SYSLOGGER")]
	public class SYSLOGGER : MapperEntity
		{
		private  int _iD = 0;
		private  int _uSER = 0;
		private  string _uSERNAME = string.Empty;
		private  string _iPADDRESS = string.Empty;
		private  DateTime _tIME = DateTime.Now;
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
        /// IP地址
        /// </summary>
		[Colum(ColumName = "IP_ADDRESS", DbTypeAttr =DbType.String)]
		public string IPADDRESS
		{
			get { return _iPADDRESS; }
			
			set { _iPADDRESS = value; }
			
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

	}


}
