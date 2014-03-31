using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 书籍分类 
	/// </summary>
	[Serializable, Table(TableName = "CATEGORIES")]
	public class CATEGORIES : MapperEntity
		{
		private  int _iD = 0;
		private  int _pARENT = 0;
		private  int _pOSITION = 0;
		private  string _nAME = string.Empty;
		private  string _aLIAS = string.Empty;
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
        /// 父亲
        /// </summary>
		[Colum(ColumName = "PARENT", DbTypeAttr =DbType.Int32)]
		public int PARENT
		{
			get { return _pARENT; }
			
			set { _pARENT = value; }
			
		}

		/// <summary>
        /// 位置
        /// </summary>
		[Colum(ColumName = "POSITION", DbTypeAttr =DbType.Int32)]
		public int POSITION
		{
			get { return _pOSITION; }
			
			set { _pOSITION = value; }
			
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

	}


}
