using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 购书单 
	/// </summary>
	[Serializable, Table(TableName = "TEXTBOOK")]
	public class TEXTBOOK : MapperEntity
		{
		private  int _iD = 0;
		private  int _bUNDLE = 0;
		private  int _aGENTS = 0;
		private  int _bOOKID = 0;
		private  string _nAME = string.Empty;
		private  string _sTANDARD = string.Empty;
		private  string _aLIAS = string.Empty;
		private  double _pRICE = 0;
		private  int _cATEGORIES = 0;
		private  int _bUYON = 0;
		private  int _iSLIMIT = 0;
		private  int _iSSELECT = 0;
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
        /// 捆绑包
        /// </summary>
		[Colum(ColumName = "BUNDLE", DbTypeAttr =DbType.Int32)]
		public int BUNDLE
		{
			get { return _bUNDLE; }
			
			set { _bUNDLE = value; }
			
		}

		/// <summary>
        /// 代理商
        /// </summary>
		[Colum(ColumName = "AGENTS", DbTypeAttr =DbType.Int32)]
		public int AGENTS
		{
			get { return _aGENTS; }
			
			set { _aGENTS = value; }
			
		}

		/// <summary>
        /// 书籍
        /// </summary>
		[Colum(ColumName = "BOOK_ID", DbTypeAttr =DbType.Int32)]
		public int BOOKID
		{
			get { return _bOOKID; }
			
			set { _bOOKID = value; }
			
		}

		/// <summary>
        /// 书籍名称
        /// </summary>
		[Colum(ColumName = "NAME", DbTypeAttr =DbType.String)]
		public string NAME
		{
			get { return _nAME; }
			
			set { _nAME = value; }
			
		}

		/// <summary>
        /// 包装规格
        /// </summary>
		[Colum(ColumName = "STANDARD", DbTypeAttr =DbType.String)]
		public string STANDARD
		{
			get { return _sTANDARD; }
			
			set { _sTANDARD = value; }
			
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
        /// 价格
        /// </summary>
		[Colum(ColumName = "PRICE", DbTypeAttr =DbType.Double)]
		public double PRICE
		{
			get { return _pRICE; }
			
			set { _pRICE = value; }
			
		}

		/// <summary>
        /// 类别
        /// </summary>
		[Colum(ColumName = "CATEGORIES", DbTypeAttr =DbType.Int32)]
		public int CATEGORIES
		{
			get { return _cATEGORIES; }
			
			set { _cATEGORIES = value; }
			
		}

		/// <summary>
        /// 购买数
        /// </summary>
		[Colum(ColumName = "BUY_ON", DbTypeAttr =DbType.Int32)]
		public int BUYON
		{
			get { return _bUYON; }
			
			set { _bUYON = value; }
			
		}

		/// <summary>
        /// 是否限价书?
        /// </summary>
		[Colum(ColumName = "IS_LIMIT", DbTypeAttr =DbType.Int32)]
		public int ISLIMIT
		{
			get { return _iSLIMIT; }
			
			set { _iSLIMIT = value; }
			
		}

		/// <summary>
        /// 是否选订书?
        /// </summary>
		[Colum(ColumName = "IS_SELECT", DbTypeAttr =DbType.Int32)]
		public int ISSELECT
		{
			get { return _iSSELECT; }
			
			set { _iSSELECT = value; }
			
		}

	}


}
