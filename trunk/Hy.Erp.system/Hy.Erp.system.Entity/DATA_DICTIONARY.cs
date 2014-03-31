using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 数据细项 
	/// </summary>
	[Serializable, Table(TableName = "DATADICTIONARY")]
	public class DATADICTIONARY : MapperEntity
		{
		private  int _iD = 0;
		private  int _pOSITION = 0;
		private  string _tYPE = string.Empty;
		private  string _dATAVALUE = string.Empty;
		private  string _dATAKEY = string.Empty;
		private  int _sTATUS = 0;
		private  string _dESCRIPTION = string.Empty;
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
        /// 位置
        /// </summary>
		[Colum(ColumName = "POSITION", DbTypeAttr =DbType.Int32)]
		public int POSITION
		{
			get { return _pOSITION; }
			
			set { _pOSITION = value; }
			
		}

		/// <summary>
        /// 类别
        /// </summary>
		[Colum(ColumName = "TYPE", DbTypeAttr =DbType.String)]
		public string TYPE
		{
			get { return _tYPE; }
			
			set { _tYPE = value; }
			
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
        /// 键
        /// </summary>
		[Colum(ColumName = "DATA_KEY", DbTypeAttr =DbType.String)]
		public string DATAKEY
		{
			get { return _dATAKEY; }
			
			set { _dATAKEY = value; }
			
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
        /// 描述
        /// </summary>
		[Colum(ColumName = "DESCRIPTION", DbTypeAttr =DbType.String)]
		public string DESCRIPTION
		{
			get { return _dESCRIPTION; }
			
			set { _dESCRIPTION = value; }
			
		}

	}


}
