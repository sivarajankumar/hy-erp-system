using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 书籍条目 
	/// </summary>
	[Serializable, Table(TableName = "BOOKS")]
	public class BOOKS : MapperEntity
		{
		private  int _iD = 0;
		private  int _cATEGORIES = 0;
		private  int _pRESS = 0;
		private  string _nAME = string.Empty;
		private  string _aLIAS = string.Empty;
		private  string _tYPE = string.Empty;
		private  int _iSRECOMMEND = 0;
		private  string _cOVERIMG = string.Empty;
		private  string _bACKCOVERIMG = string.Empty;
		private  string _iNSIDEIMG = string.Empty;
		private  string _sUMMARY = string.Empty;
		private  string _aUTHOR = string.Empty;
		private  DateTime _pUBLICATIONDATE = DateTime.Now;
		private  string _rEVISISON = string.Empty;
		private  int _pAGES = 0;
		private  DateTime _pRINTINGDATE = DateTime.Now;
		private  string _bOOKSIZE = string.Empty;
		private  string _pAPER = string.Empty;
		private  string _pRINTED = string.Empty;
		private  string _iSBN = string.Empty;
		private  string _pACKAGES = string.Empty;
		private  string _dESCRIPTION = string.Empty;
		private  int _sTATUS = 0;
		private  int _iSLIMIT = 0;
		private  double _pRICE = 0;
		private  string _sPEC = string.Empty;
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
        /// 分类
        /// </summary>
		[Colum(ColumName = "CATEGORIES", DbTypeAttr =DbType.Int32)]
		public int CATEGORIES
		{
			get { return _cATEGORIES; }
			
			set { _cATEGORIES = value; }
			
		}

		/// <summary>
        /// 出版社
        /// </summary>
		[Colum(ColumName = "PRESS", DbTypeAttr =DbType.Int32)]
		public int PRESS
		{
			get { return _pRESS; }
			
			set { _pRESS = value; }
			
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
        /// 类型(上下册,全册)
        /// </summary>
		[Colum(ColumName = "TYPE", DbTypeAttr =DbType.String)]
		public string TYPE
		{
			get { return _tYPE; }
			
			set { _tYPE = value; }
			
		}

		/// <summary>
        /// 是否推荐?
        /// </summary>
		[Colum(ColumName = "IS_RECOMMEND", DbTypeAttr =DbType.Int32)]
		public int ISRECOMMEND
		{
			get { return _iSRECOMMEND; }
			
			set { _iSRECOMMEND = value; }
			
		}

		/// <summary>
        /// 封面图片
        /// </summary>
		[Colum(ColumName = "COVER_IMG", DbTypeAttr =DbType.String)]
		public string COVERIMG
		{
			get { return _cOVERIMG; }
			
			set { _cOVERIMG = value; }
			
		}

		/// <summary>
        /// 封底图片
        /// </summary>
		[Colum(ColumName = "BACK_COVER_IMG", DbTypeAttr =DbType.String)]
		public string BACKCOVERIMG
		{
			get { return _bACKCOVERIMG; }
			
			set { _bACKCOVERIMG = value; }
			
		}

		/// <summary>
        /// 内页图片
        /// </summary>
		[Colum(ColumName = "INSIDE_IMG", DbTypeAttr =DbType.String)]
		public string INSIDEIMG
		{
			get { return _iNSIDEIMG; }
			
			set { _iNSIDEIMG = value; }
			
		}

		/// <summary>
        /// 简介
        /// </summary>
		[Colum(ColumName = "SUMMARY", DbTypeAttr =DbType.String)]
		public string SUMMARY
		{
			get { return _sUMMARY; }
			
			set { _sUMMARY = value; }
			
		}

		/// <summary>
        /// 作者
        /// </summary>
		[Colum(ColumName = "AUTHOR", DbTypeAttr =DbType.String)]
		public string AUTHOR
		{
			get { return _aUTHOR; }
			
			set { _aUTHOR = value; }
			
		}

		/// <summary>
        /// 出版日期
        /// </summary>
		[Colum(ColumName = "PUBLICATION_DATE", DbTypeAttr =DbType.DateTime)]
		public DateTime PUBLICATIONDATE
		{
			get { return _pUBLICATIONDATE; }
			
			set { _pUBLICATIONDATE = value; }
			
		}

		/// <summary>
        /// 版次
        /// </summary>
		[Colum(ColumName = "REVISISON", DbTypeAttr =DbType.String)]
		public string REVISISON
		{
			get { return _rEVISISON; }
			
			set { _rEVISISON = value; }
			
		}

		/// <summary>
        /// 页数
        /// </summary>
		[Colum(ColumName = "PAGES", DbTypeAttr =DbType.Int32)]
		public int PAGES
		{
			get { return _pAGES; }
			
			set { _pAGES = value; }
			
		}

		/// <summary>
        /// 印刷时间
        /// </summary>
		[Colum(ColumName = "PRINTING_DATE", DbTypeAttr =DbType.DateTime)]
		public DateTime PRINTINGDATE
		{
			get { return _pRINTINGDATE; }
			
			set { _pRINTINGDATE = value; }
			
		}

		/// <summary>
        /// 开本
        /// </summary>
		[Colum(ColumName = "BOOK_SIZE", DbTypeAttr =DbType.String)]
		public string BOOKSIZE
		{
			get { return _bOOKSIZE; }
			
			set { _bOOKSIZE = value; }
			
		}

		/// <summary>
        /// 纸张
        /// </summary>
		[Colum(ColumName = "PAPER", DbTypeAttr =DbType.String)]
		public string PAPER
		{
			get { return _pAPER; }
			
			set { _pAPER = value; }
			
		}

		/// <summary>
        /// 印次
        /// </summary>
		[Colum(ColumName = "PRINTED", DbTypeAttr =DbType.String)]
		public string PRINTED
		{
			get { return _pRINTED; }
			
			set { _pRINTED = value; }
			
		}

		/// <summary>
        /// ISBN
        /// </summary>
		[Colum(ColumName = "ISBN", DbTypeAttr =DbType.String)]
		public string ISBN
		{
			get { return _iSBN; }
			
			set { _iSBN = value; }
			
		}

		/// <summary>
        /// 包装
        /// </summary>
		[Colum(ColumName = "PACKAGES", DbTypeAttr =DbType.String)]
		public string PACKAGES
		{
			get { return _pACKAGES; }
			
			set { _pACKAGES = value; }
			
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
        /// 单价
        /// </summary>
		[Colum(ColumName = "PRICE", DbTypeAttr =DbType.Double)]
		public double PRICE
		{
			get { return _pRICE; }
			
			set { _pRICE = value; }
			
		}

		/// <summary>
        /// 本书规格
        /// </summary>
		[Colum(ColumName = "SPEC", DbTypeAttr =DbType.String)]
		public string SPEC
		{
			get { return _sPEC; }
			
			set { _sPEC = value; }
			
		}

	}


}
