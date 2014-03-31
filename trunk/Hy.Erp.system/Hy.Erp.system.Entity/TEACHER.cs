using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 教师 
	/// </summary>
	[Serializable, Table(TableName = "TEACHER")]
	public class TEACHER : MapperEntity
		{
		private  int _iD = 0;
		private  string _nAME = string.Empty;
		private  string _aLIAS = string.Empty;
		private  string _tELEPHONE = string.Empty;
		private  string _eMAIL = string.Empty;
		private  int _sEX = 0;
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
        /// 电话
        /// </summary>
		[Colum(ColumName = "TELEPHONE", DbTypeAttr =DbType.String)]
		public string TELEPHONE
		{
			get { return _tELEPHONE; }
			
			set { _tELEPHONE = value; }
			
		}

		/// <summary>
        /// 邮箱
        /// </summary>
		[Colum(ColumName = "EMAIL", DbTypeAttr =DbType.String)]
		public string EMAIL
		{
			get { return _eMAIL; }
			
			set { _eMAIL = value; }
			
		}

		/// <summary>
        /// 性别(0表示男，1表示女)
        /// </summary>
		[Colum(ColumName = "SEX", DbTypeAttr =DbType.Int32)]
		public int SEX
		{
			get { return _sEX; }
			
			set { _sEX = value; }
			
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
