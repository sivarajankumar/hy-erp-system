using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 书籍代理商关联 
	/// </summary>
	[Serializable, Table(TableName = "BOOKSAGENTS")]
	public class BOOKSAGENTS : MapperEntity
		{
		private  int _iD = 0;
		private  int _bOOKSID = 0;
		private  int _aGENTSID = 0;
		private  double _dISCOUNT = 0;
		private  string _dESCRIPTION = string.Empty;
		private  int _iSDEFAULT = 0;
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
        /// 代理商
        /// </summary>
		[Colum(ColumName = "AGENTS_ID", DbTypeAttr =DbType.Int32)]
		public int AGENTSID
		{
			get { return _aGENTSID; }
			
			set { _aGENTSID = value; }
			
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
        /// 描述
        /// </summary>
		[Colum(ColumName = "DESCRIPTION", DbTypeAttr =DbType.String)]
		public string DESCRIPTION
		{
			get { return _dESCRIPTION; }
			
			set { _dESCRIPTION = value; }
			
		}

		/// <summary>
        /// 是否默认？
        /// </summary>
		[Colum(ColumName = "IS_DEFAULT", DbTypeAttr =DbType.Int32)]
		public int ISDEFAULT
		{
			get { return _iSDEFAULT; }
			
			set { _iSDEFAULT = value; }
			
		}

	}


}
