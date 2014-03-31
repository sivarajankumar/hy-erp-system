using System;
using System.Data;
using HP.Mapper.Entity;


namespace  Hy.Erp.system.Entity
{
	/// <summary>
	/// 班级 
	/// </summary>
	[Serializable, Table(TableName = "DEPT")]
	public class DEPT : MapperEntity
		{
		private  int _iD = 0;
		private  int _oRGANIZATION = 0;
		private  string _nAME = string.Empty;
		private  string _aLIAS = string.Empty;
		private  string _dESCRIPTION = string.Empty;
		private  int _eNTERYEAR = 0;
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
        /// 组织
        /// </summary>
		[Colum(ColumName = "ORGANIZATION", DbTypeAttr =DbType.Int32)]
		public int ORGANIZATION
		{
			get { return _oRGANIZATION; }
			
			set { _oRGANIZATION = value; }
			
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
        /// 入学年份
        /// </summary>
		[Colum(ColumName = "ENTERYEAR", DbTypeAttr =DbType.Int32)]
		public int ENTERYEAR
		{
			get { return _eNTERYEAR; }
			
			set { _eNTERYEAR = value; }
			
		}

	}


}
