using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 学生 
	/// </summary>
	[Serializable, Table(TableName = "STUDENTS")]
	public class STUDENTS : MapperEntity
		{
		private  int _iD = 0;
		private  int _dEPT = 0;
		private  string _nUM = string.Empty;
		private  string _nAME = string.Empty;
		private  string _parents = string.Empty;
		private  string _aDDRESS = string.Empty;
		private  string _tELEPHONE = string.Empty;
		private  int _iSFREE = 0;
		private  string _tYPE = string.Empty;
		private  string _hOMEPHONE = string.Empty;
		private  string _sEMESTERSYEAR = string.Empty;
		private  int _iSBUY = 0;
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
		[Colum(ColumName = "DEPT", DbTypeAttr =DbType.Int32)]
		public int DEPT
		{
			get { return _dEPT; }
			
			set { _dEPT = value; }
			
		}

		/// <summary>
        /// 学号
        /// </summary>
		[Colum(ColumName = "NUM", DbTypeAttr =DbType.String)]
		public string NUM
		{
			get { return _nUM; }
			
			set { _nUM = value; }
			
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
        /// 家长
        /// </summary>
		[Colum(ColumName = "Parents", DbTypeAttr =DbType.String)]
		public string Parents
		{
			get { return _parents; }
			
			set { _parents = value; }
			
		}

		/// <summary>
        /// 家庭地址
        /// </summary>
		[Colum(ColumName = "ADDRESS", DbTypeAttr =DbType.String)]
		public string ADDRESS
		{
			get { return _aDDRESS; }
			
			set { _aDDRESS = value; }
			
		}

		/// <summary>
        /// 家长电话
        /// </summary>
		[Colum(ColumName = "TELEPHONE", DbTypeAttr =DbType.String)]
		public string TELEPHONE
		{
			get { return _tELEPHONE; }
			
			set { _tELEPHONE = value; }
			
		}

		/// <summary>
        /// 是否免费？
        /// </summary>
		[Colum(ColumName = "IS_FREE", DbTypeAttr =DbType.Int32)]
		public int ISFREE
		{
			get { return _iSFREE; }
			
			set { _iSFREE = value; }
			
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

		/// <summary>
        /// 家庭电话
        /// </summary>
		[Colum(ColumName = "HOME_PHONE", DbTypeAttr =DbType.String)]
		public string HOMEPHONE
		{
			get { return _hOMEPHONE; }
			
			set { _hOMEPHONE = value; }
			
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
		[Colum(ColumName = "IS_BUY", DbTypeAttr =DbType.Int32)]
		public int ISBUY
		{
			get { return _iSBUY; }
			
			set { _iSBUY = value; }
			
		}

	}


}
