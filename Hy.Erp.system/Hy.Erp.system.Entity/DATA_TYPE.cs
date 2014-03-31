using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 数据种类 
	/// </summary>
	[Serializable, Table(TableName = "DATATYPE")]
	public class DATATYPE : MapperEntity
		{
		private  int _iD = 0;
		private  string _dATAKEY = string.Empty;
		private  string _dATAVALUE = string.Empty;
		private  int _sTATUS = 0;
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
        /// 键
        /// </summary>
		[Colum(ColumName = "DATA_KEY", DbTypeAttr =DbType.String)]
		public string DATAKEY
		{
			get { return _dATAKEY; }
			
			set { _dATAKEY = value; }
			
		}

		/// <summary>
        /// 值
        /// </summary>
		[Colum(ColumName = "DATA_VALUE", DbTypeAttr =DbType.String)]
		public string DATAVALUE
		{
			get { return _dATAVALUE; }
			
			set { _dATAVALUE = value; }
			
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

	}


}
