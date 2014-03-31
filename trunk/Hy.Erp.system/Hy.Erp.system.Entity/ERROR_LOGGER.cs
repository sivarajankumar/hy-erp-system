using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 错误日志 
	/// </summary>
	[Serializable, Table(TableName = "ERRORLOGGER")]
	public class ERRORLOGGER : MapperEntity
		{
		private  int _iD = 0;
		private  string _mESSAGE = string.Empty;
		private  string _rAWURL = string.Empty;
		private  string _uRL = string.Empty;
		private  string _sOURCE = string.Empty;
		private  string _sTACKTRACE = string.Empty;
		private  string _fORM = string.Empty;
		private  string _qUERYSTRING = string.Empty;
		private  string _iNNEREXCEPTION = string.Empty;
		private  DateTime _tIME = DateTime.Now;
		private  string _iP = string.Empty;
		private  string _oPERATOR = string.Empty;
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
        /// 信息
        /// </summary>
		[Colum(ColumName = "MESSAGE", DbTypeAttr =DbType.String)]
		public string MESSAGE
		{
			get { return _mESSAGE; }
			
			set { _mESSAGE = value; }
			
		}

		/// <summary>
        /// 请求页
        /// </summary>
		[Colum(ColumName = "RAW_URL", DbTypeAttr =DbType.String)]
		public string RAWURL
		{
			get { return _rAWURL; }
			
			set { _rAWURL = value; }
			
		}

		/// <summary>
        /// 原始页
        /// </summary>
		[Colum(ColumName = "URL", DbTypeAttr =DbType.String)]
		public string URL
		{
			get { return _uRL; }
			
			set { _uRL = value; }
			
		}

		/// <summary>
        /// Source
        /// </summary>
		[Colum(ColumName = "SOURCE", DbTypeAttr =DbType.String)]
		public string SOURCE
		{
			get { return _sOURCE; }
			
			set { _sOURCE = value; }
			
		}

		/// <summary>
        /// StackTrace
        /// </summary>
		[Colum(ColumName = "STACK_TRACE", DbTypeAttr =DbType.String)]
		public string STACKTRACE
		{
			get { return _sTACKTRACE; }
			
			set { _sTACKTRACE = value; }
			
		}

		/// <summary>
        /// Form
        /// </summary>
		[Colum(ColumName = "FORM", DbTypeAttr =DbType.String)]
		public string FORM
		{
			get { return _fORM; }
			
			set { _fORM = value; }
			
		}

		/// <summary>
        /// QueryString
        /// </summary>
		[Colum(ColumName = "QUERY_STRING", DbTypeAttr =DbType.String)]
		public string QUERYSTRING
		{
			get { return _qUERYSTRING; }
			
			set { _qUERYSTRING = value; }
			
		}

		/// <summary>
        /// 异常的原因
        /// </summary>
		[Colum(ColumName = "INNER_EXCEPTION", DbTypeAttr =DbType.String)]
		public string INNEREXCEPTION
		{
			get { return _iNNEREXCEPTION; }
			
			set { _iNNEREXCEPTION = value; }
			
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
        /// IP
        /// </summary>
		[Colum(ColumName = "IP", DbTypeAttr =DbType.String)]
		public string IP
		{
			get { return _iP; }
			
			set { _iP = value; }
			
		}

		/// <summary>
        /// 操作人
        /// </summary>
		[Colum(ColumName = "OPERATOR", DbTypeAttr =DbType.String)]
		public string OPERATOR
		{
			get { return _oPERATOR; }
			
			set { _oPERATOR = value; }
			
		}

	}


}
