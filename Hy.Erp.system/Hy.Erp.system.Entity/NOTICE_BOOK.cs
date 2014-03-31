using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 团购书籍关联 
	/// </summary>
	[Serializable, Table(TableName = "NOTICEBOOK")]
	public class NOTICEBOOK : MapperEntity
		{
		private  int _iD = 0;
		private  int _bOOKID = 0;
		private  int _nOTICEID = 0;
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
		[Colum(ColumName = "BOOK_ID", DbTypeAttr =DbType.Int32)]
		public int BOOKID
		{
			get { return _bOOKID; }
			
			set { _bOOKID = value; }
			
		}

		/// <summary>
        /// 团购通知
        /// </summary>
		[Colum(ColumName = "NOTICE_ID", DbTypeAttr =DbType.Int32)]
		public int NOTICEID
		{
			get { return _nOTICEID; }
			
			set { _nOTICEID = value; }
			
		}

	}


}
