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

namespace CrudOperation
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="VegetableData")]
	public partial class DbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertVegeData(VegeData instance);
    partial void UpdateVegeData(VegeData instance);
    partial void DeleteVegeData(VegeData instance);
    #endregion
		
		public DbDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["VegetableDataConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<VegeData> VegeDatas
		{
			get
			{
				return this.GetTable<VegeData>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.VegeDatas")]
	public partial class VegeData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Veg_id;
		
		private string _VegetableName;
		
		private string _VegetableType;
		
		private string _VegetablePrice;
		
		private string _FarmerName;
		
		private string _ProductionState;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnVeg_idChanging(int value);
    partial void OnVeg_idChanged();
    partial void OnVegetableNameChanging(string value);
    partial void OnVegetableNameChanged();
    partial void OnVegetableTypeChanging(string value);
    partial void OnVegetableTypeChanged();
    partial void OnVegetablePriceChanging(string value);
    partial void OnVegetablePriceChanged();
    partial void OnFarmerNameChanging(string value);
    partial void OnFarmerNameChanged();
    partial void OnProductionStateChanging(string value);
    partial void OnProductionStateChanged();
    #endregion
		
		public VegeData()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Veg_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Veg_id
		{
			get
			{
				return this._Veg_id;
			}
			set
			{
				if ((this._Veg_id != value))
				{
					this.OnVeg_idChanging(value);
					this.SendPropertyChanging();
					this._Veg_id = value;
					this.SendPropertyChanged("Veg_id");
					this.OnVeg_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VegetableName", DbType="VarChar(50)")]
		public string VegetableName
		{
			get
			{
				return this._VegetableName;
			}
			set
			{
				if ((this._VegetableName != value))
				{
					this.OnVegetableNameChanging(value);
					this.SendPropertyChanging();
					this._VegetableName = value;
					this.SendPropertyChanged("VegetableName");
					this.OnVegetableNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VegetableType", DbType="VarChar(50)")]
		public string VegetableType
		{
			get
			{
				return this._VegetableType;
			}
			set
			{
				if ((this._VegetableType != value))
				{
					this.OnVegetableTypeChanging(value);
					this.SendPropertyChanging();
					this._VegetableType = value;
					this.SendPropertyChanged("VegetableType");
					this.OnVegetableTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VegetablePrice", DbType="VarChar(50)")]
		public string VegetablePrice
		{
			get
			{
				return this._VegetablePrice;
			}
			set
			{
				if ((this._VegetablePrice != value))
				{
					this.OnVegetablePriceChanging(value);
					this.SendPropertyChanging();
					this._VegetablePrice = value;
					this.SendPropertyChanged("VegetablePrice");
					this.OnVegetablePriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FarmerName", DbType="VarChar(50)")]
		public string FarmerName
		{
			get
			{
				return this._FarmerName;
			}
			set
			{
				if ((this._FarmerName != value))
				{
					this.OnFarmerNameChanging(value);
					this.SendPropertyChanging();
					this._FarmerName = value;
					this.SendPropertyChanged("FarmerName");
					this.OnFarmerNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductionState", DbType="VarChar(50)")]
		public string ProductionState
		{
			get
			{
				return this._ProductionState;
			}
			set
			{
				if ((this._ProductionState != value))
				{
					this.OnProductionStateChanging(value);
					this.SendPropertyChanging();
					this._ProductionState = value;
					this.SendPropertyChanged("ProductionState");
					this.OnProductionStateChanged();
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
