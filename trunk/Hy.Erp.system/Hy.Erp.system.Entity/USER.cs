using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 用户 
	/// </summary>
	[Serializable, Table(TableName = "USER")]
	public class USER : MapperEntity
		{
		private  int _iD = 0;
		private  string _nAME = string.Empty;
		private  string _pASSWORD = string.Empty;
		private  string _aLIAS = string.Empty;
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
        /// 密码
        /// </summary>
		[Colum(ColumName = "PASSWORD", DbTypeAttr =DbType.String)]
		public string PASSWORD
		{
			get { return _pASSWORD; }
			
			set { _pASSWORD = value; }
			
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
