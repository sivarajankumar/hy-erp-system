using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 新订购单 
	/// </summary>
	[Serializable, Table(TableName = "BOOKORDER")]
	public class BOOKORDER : MapperEntity
		{
		private  int _iD = 0;
		private  int _oRGANIZATIONID = 0;
		private  int _bOOKSAGENTSID = 0;
		private  int _bOOKSID = 0;
		private  int _pRESSID = 0;
		private  int _eNTERYEAR = 0;
		private  int _cATEGORIESID = 0;
		private  string _nO1 = string.Empty;
		private  string _nO2 = string.Empty;
		private  double _sHIYANG = 0;
		private  double _mAYANG = 0;
		private  double _pRICE = 0;
		private  double _dISCOUNT = 0;
		private  string _rEMARK = string.Empty;
		private  int _cOUNT = 0;
		private  string _tYPE = string.Empty;
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
        /// 学校标识
        /// </summary>
		[Colum(ColumName = "ORGANIZATION_ID", DbTypeAttr =DbType.Int32)]
		public int ORGANIZATIONID
		{
			get { return _oRGANIZATIONID; }
			
			set { _oRGANIZATIONID = value; }
			
		}

		/// <summary>
        /// 供应商标识
        /// </summary>
		[Colum(ColumName = "BOOKS_AGENTS_ID", DbTypeAttr =DbType.Int32)]
		public int BOOKSAGENTSID
		{
			get { return _bOOKSAGENTSID; }
			
			set { _bOOKSAGENTSID = value; }
			
		}

		/// <summary>
        /// 书籍标识
        /// </summary>
		[Colum(ColumName = "BOOKS_ID", DbTypeAttr =DbType.Int32)]
		public int BOOKSID
		{
			get { return _bOOKSID; }
			
			set { _bOOKSID = value; }
			
		}

		/// <summary>
        /// 出版社标识
        /// </summary>
		[Colum(ColumName = "PRESS_ID", DbTypeAttr =DbType.Int32)]
		public int PRESSID
		{
			get { return _pRESSID; }
			
			set { _pRESSID = value; }
			
		}

		/// <summary>
        /// 入学年份
        /// </summary>
		[Colum(ColumName = "ENTERYEAR", DbTypeAttr =DbType.Int32)]
		public int ENTERYEAR
		{
			get { return _eNTERYEAR; }
			
			set { _eNTERYEAR = value; }
			
		}

		/// <summary>
        /// 科目标识
        /// </summary>
		[Colum(ColumName = "CATEGORIES_ID", DbTypeAttr =DbType.Int32)]
		public int CATEGORIESID
		{
			get { return _cATEGORIESID; }
			
			set { _cATEGORIESID = value; }
			
		}

		/// <summary>
        /// 包装号1
        /// </summary>
		[Colum(ColumName = "NO1", DbTypeAttr =DbType.String)]
		public string NO1
		{
			get { return _nO1; }
			
			set { _nO1 = value; }
			
		}

		/// <summary>
        /// 包装号2
        /// </summary>
		[Colum(ColumName = "NO2", DbTypeAttr =DbType.String)]
		public string NO2
		{
			get { return _nO2; }
			
			set { _nO2 = value; }
			
		}

		/// <summary>
        /// 实洋
        /// </summary>
		[Colum(ColumName = "SHIYANG", DbTypeAttr =DbType.Double)]
		public double SHIYANG
		{
			get { return _sHIYANG; }
			
			set { _sHIYANG = value; }
			
		}

		/// <summary>
        /// 码洋
        /// </summary>
		[Colum(ColumName = "MAYANG", DbTypeAttr =DbType.Double)]
		public double MAYANG
		{
			get { return _mAYANG; }
			
			set { _mAYANG = value; }
			
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
        /// 折扣
        /// </summary>
		[Colum(ColumName = "DISCOUNT", DbTypeAttr =DbType.Double)]
		public double DISCOUNT
		{
			get { return _dISCOUNT; }
			
			set { _dISCOUNT = value; }
			
		}

		/// <summary>
        /// 备注
        /// </summary>
		[Colum(ColumName = "REMARK", DbTypeAttr =DbType.String)]
		public string REMARK
		{
			get { return _rEMARK; }
			
			set { _rEMARK = value; }
			
		}

		/// <summary>
        /// 购书数量
        /// </summary>
		[Colum(ColumName = "COUNT", DbTypeAttr =DbType.Int32)]
		public int COUNT
		{
			get { return _cOUNT; }
			
			set { _cOUNT = value; }
			
		}

		/// <summary>
        /// 类型
        /// </summary>
		[Colum(ColumName = "TYPE", DbTypeAttr =DbType.String)]
		public string TYPE
		{
			get { return _tYPE; }
			
			set { _tYPE = value; }
			
		}

	}


}
