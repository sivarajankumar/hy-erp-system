using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 团购通知单 
	/// </summary>
	[Serializable, Table(TableName = "NOTICE")]
	public class NOTICE : MapperEntity
		{
		private  int _iD = 0;
		private  string _nAME = string.Empty;
		private  string _rEVERED = string.Empty;
		private  string _pREFACE = string.Empty;
		private  string _sTEPS = string.Empty;
		private  string _nOTE = string.Empty;
		private  string _rEMARKS = string.Empty;
		private  string _tHANKS = string.Empty;
		private  string _sITES = string.Empty;
		private  string _cONTACT = string.Empty;
		private  string _fEEDBACKLINE = string.Empty;
		private  string _fEEDBACKNAME = string.Empty;
		private  string _oRGANIZATIONNAME = string.Empty;
		private  int _oRGANIZATION = 0;
		private  string _gRADE = string.Empty;
		private  int _sTATUS = 0;
		private  string _tITLE = string.Empty;
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
        /// 尊称
        /// </summary>
		[Colum(ColumName = "REVERED", DbTypeAttr =DbType.String)]
		public string REVERED
		{
			get { return _rEVERED; }
			
			set { _rEVERED = value; }
			
		}

		/// <summary>
        /// 前言
        /// </summary>
		[Colum(ColumName = "PREFACE", DbTypeAttr =DbType.String)]
		public string PREFACE
		{
			get { return _pREFACE; }
			
			set { _pREFACE = value; }
			
		}

		/// <summary>
        /// 步骤(其中步骤用'[㊣BCM㊣]')
        /// </summary>
		[Colum(ColumName = "STEPS", DbTypeAttr =DbType.String)]
		public string STEPS
		{
			get { return _sTEPS; }
			
			set { _sTEPS = value; }
			
		}

		/// <summary>
        /// 注意
        /// </summary>
		[Colum(ColumName = "NOTE", DbTypeAttr =DbType.String)]
		public string NOTE
		{
			get { return _nOTE; }
			
			set { _nOTE = value; }
			
		}

		/// <summary>
        /// 备注
        /// </summary>
		[Colum(ColumName = "REMARKS", DbTypeAttr =DbType.String)]
		public string REMARKS
		{
			get { return _rEMARKS; }
			
			set { _rEMARKS = value; }
			
		}

		/// <summary>
        /// 感谢语
        /// </summary>
		[Colum(ColumName = "THANKS", DbTypeAttr =DbType.String)]
		public string THANKS
		{
			get { return _tHANKS; }
			
			set { _tHANKS = value; }
			
		}

		/// <summary>
        /// 网站
        /// </summary>
		[Colum(ColumName = "SITES", DbTypeAttr =DbType.String)]
		public string SITES
		{
			get { return _sITES; }
			
			set { _sITES = value; }
			
		}

		/// <summary>
        /// 联系方式
        /// </summary>
		[Colum(ColumName = "CONTACT", DbTypeAttr =DbType.String)]
		public string CONTACT
		{
			get { return _cONTACT; }
			
			set { _cONTACT = value; }
			
		}

		/// <summary>
        /// 反馈表分线
        /// </summary>
		[Colum(ColumName = "FEEDBACK_LINE", DbTypeAttr =DbType.String)]
		public string FEEDBACKLINE
		{
			get { return _fEEDBACKLINE; }
			
			set { _fEEDBACKLINE = value; }
			
		}

		/// <summary>
        /// 反馈表名称
        /// </summary>
		[Colum(ColumName = "FEEDBACK_NAME", DbTypeAttr =DbType.String)]
		public string FEEDBACKNAME
		{
			get { return _fEEDBACKNAME; }
			
			set { _fEEDBACKNAME = value; }
			
		}

		/// <summary>
        /// 订购学校名称
        /// </summary>
		[Colum(ColumName = "ORGANIZATION_NAME", DbTypeAttr =DbType.String)]
		public string ORGANIZATIONNAME
		{
			get { return _oRGANIZATIONNAME; }
			
			set { _oRGANIZATIONNAME = value; }
			
		}

		/// <summary>
        /// 订购学校
        /// </summary>
		[Colum(ColumName = "ORGANIZATION", DbTypeAttr =DbType.Int32)]
		public int ORGANIZATION
		{
			get { return _oRGANIZATION; }
			
			set { _oRGANIZATION = value; }
			
		}

		/// <summary>
        /// 订购年级
        /// </summary>
		[Colum(ColumName = "GRADE", DbTypeAttr =DbType.String)]
		public string GRADE
		{
			get { return _gRADE; }
			
			set { _gRADE = value; }
			
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
        /// 标题
        /// </summary>
		[Colum(ColumName = "TITLE", DbTypeAttr =DbType.String)]
		public string TITLE
		{
			get { return _tITLE; }
			
			set { _tITLE = value; }
			
		}

	}


}
