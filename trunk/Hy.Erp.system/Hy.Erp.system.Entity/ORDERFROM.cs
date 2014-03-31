using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 物流包装规格 
	/// </summary>
	[Serializable, Table(TableName = "ORDERFROM")]
	public class ORDERFROM : MapperEntity
		{
		private  int _iD = 0;
		private  string _nO1 = string.Empty;
		private  string _nO2 = string.Empty;
		private  int _bSID = 0;
		private  int _cID = 0;
		private  int _bOID = 0;
		private  string _gRADE = string.Empty;
		private  int _aID = 0;
		private  double _pRICE = 0;
		private  int _bUYCOUNT = 0;
		private  double _dISCOUNT = 0;
		private  double _sHIYANG = 0;
		private  double _mAYANG = 0;
		private  int _oRDERSTATUS = 0;
		private  DateTime _oRDERTIME = DateTime.Now;
		private  string _qUARTER = string.Empty;
		private  string _rEMARK = string.Empty;
		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "ID", DbTypeAttr =DbType.Int32,IsPrimaryKey = true, IsIdentity = true)]
		public int ID
		{
			get {return _iD;}
			set {_iD = value;}
		}

		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "NO1", DbTypeAttr =DbType.String)]
		public string NO1
		{
			get { return _nO1; }
			
			set { _nO1 = value; }
			
		}

		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "NO2", DbTypeAttr =DbType.String)]
		public string NO2
		{
			get { return _nO2; }
			
			set { _nO2 = value; }
			
		}

		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "BSID", DbTypeAttr =DbType.Int32)]
		public int BSID
		{
			get { return _bSID; }
			
			set { _bSID = value; }
			
		}

		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "CID", DbTypeAttr =DbType.Int32)]
		public int CID
		{
			get { return _cID; }
			
			set { _cID = value; }
			
		}

		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "BOID", DbTypeAttr =DbType.Int32)]
		public int BOID
		{
			get { return _bOID; }
			
			set { _bOID = value; }
			
		}

		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "GRADE", DbTypeAttr =DbType.String)]
		public string GRADE
		{
			get { return _gRADE; }
			
			set { _gRADE = value; }
			
		}

		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "AID", DbTypeAttr =DbType.Int32)]
		public int AID
		{
			get { return _aID; }
			
			set { _aID = value; }
			
		}

		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "PRICE", DbTypeAttr =DbType.Double)]
		public double PRICE
		{
			get { return _pRICE; }
			
			set { _pRICE = value; }
			
		}

		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "BUYCOUNT", DbTypeAttr =DbType.Int32)]
		public int BUYCOUNT
		{
			get { return _bUYCOUNT; }
			
			set { _bUYCOUNT = value; }
			
		}

		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "DISCOUNT", DbTypeAttr =DbType.Double)]
		public double DISCOUNT
		{
			get { return _dISCOUNT; }
			
			set { _dISCOUNT = value; }
			
		}

		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "SHIYANG", DbTypeAttr =DbType.Double)]
		public double SHIYANG
		{
			get { return _sHIYANG; }
			
			set { _sHIYANG = value; }
			
		}

		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "MAYANG", DbTypeAttr =DbType.Double)]
		public double MAYANG
		{
			get { return _mAYANG; }
			
			set { _mAYANG = value; }
			
		}

		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "ORDERSTATUS", DbTypeAttr =DbType.Int32)]
		public int ORDERSTATUS
		{
			get { return _oRDERSTATUS; }
			
			set { _oRDERSTATUS = value; }
			
		}

		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "ORDERTIME", DbTypeAttr =DbType.DateTime)]
		public DateTime ORDERTIME
		{
			get { return _oRDERTIME; }
			
			set { _oRDERTIME = value; }
			
		}

		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "QUARTER", DbTypeAttr =DbType.String)]
		public string QUARTER
		{
			get { return _qUARTER; }
			
			set { _qUARTER = value; }
			
		}

		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "REMARK", DbTypeAttr =DbType.String)]
		public string REMARK
		{
			get { return _rEMARK; }
			
			set { _rEMARK = value; }
			
		}

	}


}
