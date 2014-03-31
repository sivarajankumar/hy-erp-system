using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 购买 
	/// </summary>
	[Serializable, Table(TableName = "PURCHASE")]
	public class PURCHASE : MapperEntity
		{
		private  int _iD = 0;
		private  int _bUNDLE = 0;
		private  int _sTUDENTSID = 0;
		private  string _qUARTER = string.Empty;
		private  int _tYPE = 0;
		private  double _pAID = 0;
		private  double _mEET = 0;
		private  DateTime _dATE = DateTime.Now;
		private  string _dESCRIPTION = string.Empty;
		private  int _sTATUS = 0;
		private  int _iSALLSHARE = 0;
		private  DateTime _oRDERTIME = DateTime.Now;
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
        /// 学生编号
        /// </summary>
		[Colum(ColumName = "STUDENTS_ID", DbTypeAttr =DbType.Int32)]
		public int STUDENTSID
		{
			get { return _sTUDENTSID; }
			
			set { _sTUDENTSID = value; }
			
		}

		/// <summary>
        /// 购飞的季度（春季，秋季等）
        /// </summary>
		[Colum(ColumName = "QUARTER", DbTypeAttr =DbType.String)]
		public string QUARTER
		{
			get { return _qUARTER; }
			
			set { _qUARTER = value; }
			
		}

		/// <summary>
        /// 类型(0收费、1免费)
        /// </summary>
		[Colum(ColumName = "TYPE", DbTypeAttr =DbType.Int32)]
		public int TYPE
		{
			get { return _tYPE; }
			
			set { _tYPE = value; }
			
		}

		/// <summary>
        /// 实收
        /// </summary>
		[Colum(ColumName = "PAID", DbTypeAttr =DbType.Double)]
		public double PAID
		{
			get { return _pAID; }
			
			set { _pAID = value; }
			
		}

		/// <summary>
        /// 应付
        /// </summary>
		[Colum(ColumName = "MEET", DbTypeAttr =DbType.Double)]
		public double MEET
		{
			get { return _mEET; }
			
			set { _mEET = value; }
			
		}

		/// <summary>
        /// 创建日期
        /// </summary>
		[Colum(ColumName = "DATE", DbTypeAttr =DbType.DateTime)]
		public DateTime DATE
		{
			get { return _dATE; }
			
			set { _dATE = value; }
			
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
        /// 状态(0未定，1已定，2已发货)补单状态为 0未定 
        /// </summary>
		[Colum(ColumName = "STATUS", DbTypeAttr =DbType.Int32)]
		public int STATUS
		{
			get { return _sTATUS; }
			
			set { _sTATUS = value; }
			
		}

		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "ISALLSHARE", DbTypeAttr =DbType.Int32)]
		public int ISALLSHARE
		{
			get { return _iSALLSHARE; }
			
			set { _iSALLSHARE = value; }
			
		}

		/// <summary>
        /// 下单时间
        /// </summary>
		[Colum(ColumName = "ORDERTIME", DbTypeAttr =DbType.DateTime)]
		public DateTime ORDERTIME
		{
			get { return _oRDERTIME; }
			
			set { _oRDERTIME = value; }
			
		}

	}


}
