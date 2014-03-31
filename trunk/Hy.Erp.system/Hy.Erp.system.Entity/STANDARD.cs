using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 包装规格 
	/// </summary>
	[Serializable, Table(TableName = "STANDARD")]
	public class STANDARD : MapperEntity
		{
		private  int _iD = 0;
		private  int _bOOKSID = 0;
		private  string _nAME = string.Empty;
		private  string _gRADE = string.Empty;
		private  string _dESCRIPTION = string.Empty;
		private  double _pRICE = 0;
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
        /// 书籍
        /// </summary>
		[Colum(ColumName = "BOOKS_ID", DbTypeAttr =DbType.Int32)]
		public int BOOKSID
		{
			get { return _bOOKSID; }
			
			set { _bOOKSID = value; }
			
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
        /// 年级
        /// </summary>
		[Colum(ColumName = "GRADE", DbTypeAttr =DbType.String)]
		public string GRADE
		{
			get { return _gRADE; }
			
			set { _gRADE = value; }
			
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
        /// 单价
        /// </summary>
		[Colum(ColumName = "PRICE", DbTypeAttr =DbType.Double)]
		public double PRICE
		{
			get { return _pRICE; }
			
			set { _pRICE = value; }
			
		}

	}


}
