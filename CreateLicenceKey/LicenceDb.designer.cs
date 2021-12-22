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

namespace CreateLicenceKey
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LicenceDB")]
	public partial class LicenceDbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLicence(Licence instance);
    partial void UpdateLicence(Licence instance);
    partial void DeleteLicence(Licence instance);
    partial void InsertMac(Mac instance);
    partial void UpdateMac(Mac instance);
    partial void DeleteMac(Mac instance);
    #endregion
		
		public LicenceDbDataContext() : 
				base(global::CreateLicenceKey.Properties.Settings.Default.LicenceDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LicenceDbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LicenceDbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LicenceDbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LicenceDbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
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
		
		public System.Data.Linq.Table<Mac> Macs
		{
			get
			{
				return this.GetTable<Mac>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Licence")]
	public partial class Licence : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Guid _ProductKey;
		
		private string _HddNo;
		
		private bool _IsLocked;
		
		private EntitySet<Mac> _Macs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnProductKeyChanging(System.Guid value);
    partial void OnProductKeyChanged();
    partial void OnHddNoChanging(string value);
    partial void OnHddNoChanged();
    partial void OnIsLockedChanging(bool value);
    partial void OnIsLockedChanged();
    #endregion
		
		public Licence()
		{
			this._Macs = new EntitySet<Mac>(new Action<Mac>(this.attach_Macs), new Action<Mac>(this.detach_Macs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
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
					this.OnProductKeyChanging(value);
					this.SendPropertyChanging();
					this._ProductKey = value;
					this.SendPropertyChanged("ProductKey");
					this.OnProductKeyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HddNo", DbType="NVarChar(50)")]
		public string HddNo
		{
			get
			{
				return this._HddNo;
			}
			set
			{
				if ((this._HddNo != value))
				{
					this.OnHddNoChanging(value);
					this.SendPropertyChanging();
					this._HddNo = value;
					this.SendPropertyChanged("HddNo");
					this.OnHddNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsLocked", DbType="Bit NOT NULL")]
		public bool IsLocked
		{
			get
			{
				return this._IsLocked;
			}
			set
			{
				if ((this._IsLocked != value))
				{
					this.OnIsLockedChanging(value);
					this.SendPropertyChanging();
					this._IsLocked = value;
					this.SendPropertyChanged("IsLocked");
					this.OnIsLockedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Licence_Mac", Storage="_Macs", ThisKey="Id", OtherKey="LicenceID")]
		public EntitySet<Mac> Macs
		{
			get
			{
				return this._Macs;
			}
			set
			{
				this._Macs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Macs(Mac entity)
		{
			this.SendPropertyChanging();
			entity.Licence = this;
		}
		
		private void detach_Macs(Mac entity)
		{
			this.SendPropertyChanging();
			entity.Licence = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Mac")]
	public partial class Mac : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _LicenceID;
		
		private string _Address;
		
		private EntityRef<Licence> _Licence;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnLicenceIDChanging(int value);
    partial void OnLicenceIDChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    #endregion
		
		public Mac()
		{
			this._Licence = default(EntityRef<Licence>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LicenceID", DbType="Int NOT NULL")]
		public int LicenceID
		{
			get
			{
				return this._LicenceID;
			}
			set
			{
				if ((this._LicenceID != value))
				{
					if (this._Licence.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLicenceIDChanging(value);
					this.SendPropertyChanging();
					this._LicenceID = value;
					this.SendPropertyChanged("LicenceID");
					this.OnLicenceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Licence_Mac", Storage="_Licence", ThisKey="LicenceID", OtherKey="Id", IsForeignKey=true)]
		public Licence Licence
		{
			get
			{
				return this._Licence.Entity;
			}
			set
			{
				Licence previousValue = this._Licence.Entity;
				if (((previousValue != value) 
							|| (this._Licence.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Licence.Entity = null;
						previousValue.Macs.Remove(this);
					}
					this._Licence.Entity = value;
					if ((value != null))
					{
						value.Macs.Add(this);
						this._LicenceID = value.Id;
					}
					else
					{
						this._LicenceID = default(int);
					}
					this.SendPropertyChanged("Licence");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
