using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 购书捆绑包 
	/// </summary>
	[Serializable, Table(TableName = "BUNDLE")]
	public class BUNDLE : MapperEntity
		{
		private  int _iD = 0;
		private  int _oRGANIZATION = 0;
		private  string _oRGANIZATIONNAME = string.Empty;
		private  string _dEPTNAME = string.Empty;
		private  int _dEPT = 0;
		private  int _eNTERYEAR = 0;
		private  double _dISCOUNT = 0;
		private  DateTime _dATE = DateTime.Now;
		private  int _sTATUS = 0;
		private  string _nAME = string.Empty;
		private  int _iSNORE = 0;
		private  DateTime _cALLINDATE = DateTime.Now;
		private  DateTime _dEADLINEDATE = DateTime.Now;
		private  double _aDVANCE = 0;
		private  double _bOOKADVANCE = 0;
		private  string _sEMESTERSYEAR = string.Empty;
		private  double _pACHAGEFEE = 0;
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
        /// 组织
        /// </summary>
		[Colum(ColumName = "ORGANIZATION", DbTypeAttr =DbType.Int32)]
		public int ORGANIZATION
		{
			get { return _oRGANIZATION; }
			
			set { _oRGANIZATION = value; }
			
		}

		/// <summary>
        /// 组织名称
        /// </summary>
		[Colum(ColumName = "ORGANIZATION_NAME", DbTypeAttr =DbType.String)]
		public string ORGANIZATIONNAME
		{
			get { return _oRGANIZATIONNAME; }
			
			set { _oRGANIZATIONNAME = value; }
			
		}

		/// <summary>
        /// 班级名称
        /// </summary>
		[Colum(ColumName = "DEPT_NAME", DbTypeAttr =DbType.String)]
		public string DEPTNAME
		{
			get { return _dEPTNAME; }
			
			set { _dEPTNAME = value; }
			
		}

		/// <summary>
        /// 班级
        /// </summary>
		[Colum(ColumName = "DEPT", DbTypeAttr =DbType.Int32)]
		public int DEPT
		{
			get { return _dEPT; }
			
			set { _dEPT = value; }
			
		}

		/// <summary>
        /// 年级
        /// </summary>
		[Colum(ColumName = "ENTERYEAR", DbTypeAttr =DbType.Int32)]
		public int ENTERYEAR
		{
			get { return _eNTERYEAR; }
			
			set { _eNTERYEAR = value; }
			
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
        /// 创建日期
        /// </summary>
		[Colum(ColumName = "DATE", DbTypeAttr =DbType.DateTime)]
		public DateTime DATE
		{
			get { return _dATE; }
			
			set { _dATE = value; }
			
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
        /// 名称
        /// </summary>
		[Colum(ColumName = "NAME", DbTypeAttr =DbType.String)]
		public string NAME
		{
			get { return _nAME; }
			
			set { _nAME = value; }
			
		}

		/// <summary>
        /// 是否多选项？
        /// </summary>
		[Colum(ColumName = "IS_NORE", DbTypeAttr =DbType.Int32)]
		public int ISNORE
		{
			get { return _iSNORE; }
			
			set { _iSNORE = value; }
			
		}

		/// <summary>
        /// 回收日期
        /// </summary>
		[Colum(ColumName = "CALLIN_DATE", DbTypeAttr =DbType.DateTime)]
		public DateTime CALLINDATE
		{
			get { return _cALLINDATE; }
			
			set { _cALLINDATE = value; }
			
		}

		/// <summary>
        /// 截止日期
        /// </summary>
		[Colum(ColumName = "DEADLINE_DATE", DbTypeAttr =DbType.DateTime)]
		public DateTime DEADLINEDATE
		{
			get { return _dEADLINEDATE; }
			
			set { _dEADLINEDATE = value; }
			
		}

		/// <summary>
        /// 预收价
        /// </summary>
		[Colum(ColumName = "ADVANCE", DbTypeAttr =DbType.Double)]
		public double ADVANCE
		{
			get { return _aDVANCE; }
			
			set { _aDVANCE = value; }
			
		}

		/// <summary>
        /// 书籍预收价
        /// </summary>
		[Colum(ColumName = "BOOK_ADVANCE", DbTypeAttr =DbType.Double)]
		public double BOOKADVANCE
		{
			get { return _bOOKADVANCE; }
			
			set { _bOOKADVANCE = value; }
			
		}

		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "SEMESTERS_YEAR", DbTypeAttr =DbType.String)]
		public string SEMESTERSYEAR
		{
			get { return _sEMESTERSYEAR; }
			
			set { _sEMESTERSYEAR = value; }
			
		}

		/// <summary>
        /// 
        /// </summary>
		[Colum(ColumName = "PACHAGE_FEE", DbTypeAttr =DbType.Double)]
		public double PACHAGEFEE
		{
			get { return _pACHAGEFEE; }
			
			set { _pACHAGEFEE = value; }
			
		}

	}


}
