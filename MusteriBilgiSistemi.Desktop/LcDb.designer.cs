﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusteriBilgiSistemi.Desktop
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MusteriBilgiSistemi")]
	public partial class LcDbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public LcDbDataContext() : 
				base(global::MusteriBilgiSistemi.Desktop.Properties.Settings.Default.MusteriBilgiSistemiConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LcDbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LcDbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LcDbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LcDbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Licence> Licences
		{
			get
			{
				return this.GetTable<Licence>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Licence")]
	public partial class Licence
	{
		
		private System.Guid _ProductKey;
		
		public Licence()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductKey", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ProductKey
		{
			get
			{
				return this._ProductKey;
			}
			set
			{
				if ((this._ProductKey != value))
				{
					this._ProductKey = value;
				}
			}
		}
	}
}
#pragma warning restore 1591