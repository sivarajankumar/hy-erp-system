using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 用户角色关联 
	/// </summary>
	[Serializable, Table(TableName = "USERROLE")]
	public class USERROLE : MapperEntity
		{
		private  int _iD = 0;
		private  int _uSERID = 0;
		private  int _rOLEID = 0;
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
        /// 用户
        /// </summary>
		[Colum(ColumName = "USER_ID", DbTypeAttr =DbType.Int32)]
		public int USERID
		{
			get { return _uSERID; }
			
			set { _uSERID = value; }
			
		}

		/// <summary>
        /// 角色
        /// </summary>
		[Colum(ColumName = "ROLE_ID", DbTypeAttr =DbType.Int32)]
		public int ROLEID
		{
			get { return _rOLEID; }
			
			set { _rOLEID = value; }
			
		}

	}


}
