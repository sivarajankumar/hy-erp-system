using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 权限 
	/// </summary>
	[Serializable, Table(TableName = "RIGHTS")]
	public class RIGHTS : MapperEntity
		{
		private  int _iD = 0;
		private  int _pARENT = 0;
		private  string _nAME = string.Empty;
		private  string _uRLADDRESS = string.Empty;
		private  int _lEVEL = 0;
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
        /// 名称
        /// </summary>
		[Colum(ColumName = "NAME", DbTypeAttr =DbType.String)]
		public string NAME
		{
			get { return _nAME; }
			
			set { _nAME = value; }
			
		}

		/// <summary>
        /// 地址
        /// </summary>
		[Colum(ColumName = "URL_ADDRESS", DbTypeAttr =DbType.String)]
		public string URLADDRESS
		{
			get { return _uRLADDRESS; }
			
			set { _uRLADDRESS = value; }
			
		}

		/// <summary>
        /// 等级
        /// </summary>
		[Colum(ColumName = "LEVEL", DbTypeAttr =DbType.Int32)]
		public int LEVEL
		{
			get { return _lEVEL; }
			
			set { _lEVEL = value; }
			
		}

	}


}
