using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 角色 
	/// </summary>
	[Serializable, Table(TableName = "ROLE")]
	public class ROLE : MapperEntity
		{
		private  int _iD = 0;
		private  string _nAME = string.Empty;
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
        /// 名称
        /// </summary>
		[Colum(ColumName = "NAME", DbTypeAttr =DbType.String)]
		public string NAME
		{
			get { return _nAME; }
			
			set { _nAME = value; }
			
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
