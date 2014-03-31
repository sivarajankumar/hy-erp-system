using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 书代理商 
	/// </summary>
	[Serializable, Table(TableName = "AGENTS")]
	public class AGENTS : MapperEntity
		{
		private  int _iD = 0;
		private  string _nAME = string.Empty;
		private  string _aLIAS = string.Empty;
		private  string _aDDRESS = string.Empty;
		private  string _tELEPHONE = string.Empty;
		private  string _cONTACT1NAME = string.Empty;
		private  string _cONTACT1TEL = string.Empty;
		private  string _cONTACT1MOBILE = string.Empty;
		private  string _cONTACT1QQ = string.Empty;
		private  string _cONTACT2NAME = string.Empty;
		private  string _cONTACT2TEL = string.Empty;
		private  string _cONTACT2MOBILE = string.Empty;
		private  string _cONTACT2QQ = string.Empty;
		private  string _dESCRIPTION = string.Empty;
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
        /// 名称
        /// </summary>
		[Colum(ColumName = "NAME", DbTypeAttr =DbType.String)]
		public string NAME
		{
			get { return _nAME; }
			
			set { _nAME = value; }
			
		}

		/// <summary>
        /// 别名
        /// </summary>
		[Colum(ColumName = "ALIAS", DbTypeAttr =DbType.String)]
		public string ALIAS
		{
			get { return _aLIAS; }
			
			set { _aLIAS = value; }
			
		}

		/// <summary>
        /// 地址
        /// </summary>
		[Colum(ColumName = "ADDRESS", DbTypeAttr =DbType.String)]
		public string ADDRESS
		{
			get { return _aDDRESS; }
			
			set { _aDDRESS = value; }
			
		}

		/// <summary>
        /// 电话
        /// </summary>
		[Colum(ColumName = "TELEPHONE", DbTypeAttr =DbType.String)]
		public string TELEPHONE
		{
			get { return _tELEPHONE; }
			
			set { _tELEPHONE = value; }
			
		}

		/// <summary>
        /// 联系人1
        /// </summary>
		[Colum(ColumName = "CONTACT1_NAME", DbTypeAttr =DbType.String)]
		public string CONTACT1NAME
		{
			get { return _cONTACT1NAME; }
			
			set { _cONTACT1NAME = value; }
			
		}

		/// <summary>
        /// 联系人1电话
        /// </summary>
		[Colum(ColumName = "CONTACT1_TEL", DbTypeAttr =DbType.String)]
		public string CONTACT1TEL
		{
			get { return _cONTACT1TEL; }
			
			set { _cONTACT1TEL = value; }
			
		}

		/// <summary>
        /// 联系人1手机
        /// </summary>
		[Colum(ColumName = "CONTACT1_MOBILE", DbTypeAttr =DbType.String)]
		public string CONTACT1MOBILE
		{
			get { return _cONTACT1MOBILE; }
			
			set { _cONTACT1MOBILE = value; }
			
		}

		/// <summary>
        /// 联系人1QQ
        /// </summary>
		[Colum(ColumName = "CONTACT1_QQ", DbTypeAttr =DbType.String)]
		public string CONTACT1QQ
		{
			get { return _cONTACT1QQ; }
			
			set { _cONTACT1QQ = value; }
			
		}

		/// <summary>
        /// 联系人2
        /// </summary>
		[Colum(ColumName = "CONTACT2_NAME", DbTypeAttr =DbType.String)]
		public string CONTACT2NAME
		{
			get { return _cONTACT2NAME; }
			
			set { _cONTACT2NAME = value; }
			
		}

		/// <summary>
        /// 联系人2电话
        /// </summary>
		[Colum(ColumName = "CONTACT2_TEL", DbTypeAttr =DbType.String)]
		public string CONTACT2TEL
		{
			get { return _cONTACT2TEL; }
			
			set { _cONTACT2TEL = value; }
			
		}

		/// <summary>
        /// 联系人2手机
        /// </summary>
		[Colum(ColumName = "CONTACT2_MOBILE", DbTypeAttr =DbType.String)]
		public string CONTACT2MOBILE
		{
			get { return _cONTACT2MOBILE; }
			
			set { _cONTACT2MOBILE = value; }
			
		}

		/// <summary>
        /// 联系人2QQ
        /// </summary>
		[Colum(ColumName = "CONTACT2_QQ", DbTypeAttr =DbType.String)]
		public string CONTACT2QQ
		{
			get { return _cONTACT2QQ; }
			
			set { _cONTACT2QQ = value; }
			
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
