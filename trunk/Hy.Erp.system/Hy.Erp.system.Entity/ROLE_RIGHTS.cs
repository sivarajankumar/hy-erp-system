using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 角色权限关联 
	/// </summary>
	[Serializable, Table(TableName = "ROLERIGHTS")]
	public class ROLERIGHTS : MapperEntity
		{
		private  int _iD = 0;
		private  int _rOLEID = 0;
		private  int _rIGHTSID = 0;
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
        /// 角色
        /// </summary>
		[Colum(ColumName = "ROLE_ID", DbTypeAttr =DbType.Int32)]
		public int ROLEID
		{
			get { return _rOLEID; }
			
			set { _rOLEID = value; }
			
		}

		/// <summary>
        /// 权限
        /// </summary>
		[Colum(ColumName = "RIGHTS_ID", DbTypeAttr =DbType.Int32)]
		public int RIGHTSID
		{
			get { return _rIGHTSID; }
			
			set { _rIGHTSID = value; }
			
		}

	}


}
