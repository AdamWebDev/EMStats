﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18046
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMStats
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EMStats")]
	public partial class emsDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCallTypes(CallTypes instance);
    partial void UpdateCallTypes(CallTypes instance);
    partial void DeleteCallTypes(CallTypes instance);
    partial void InsertVSAs(VSAs instance);
    partial void UpdateVSAs(VSAs instance);
    partial void DeleteVSAs(VSAs instance);
    partial void InsertCTASs(CTASs instance);
    partial void UpdateCTASs(CTASs instance);
    partial void DeleteCTASs(CTASs instance);
    partial void InsertEntry(Entry instance);
    partial void UpdateEntry(Entry instance);
    partial void DeleteEntry(Entry instance);
    partial void InsertIVAttempts(IVAttempts instance);
    partial void UpdateIVAttempts(IVAttempts instance);
    partial void DeleteIVAttempts(IVAttempts instance);
    partial void InsertSymptomReliefs(SymptomReliefs instance);
    partial void UpdateSymptomReliefs(SymptomReliefs instance);
    partial void DeleteSymptomReliefs(SymptomReliefs instance);
    #endregion
		
		public emsDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ncemsConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public emsDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public emsDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public emsDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public emsDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CallTypes> CallTypes
		{
			get
			{
				return this.GetTable<CallTypes>();
			}
		}
		
		public System.Data.Linq.Table<VSAs> VSAs
		{
			get
			{
				return this.GetTable<VSAs>();
			}
		}
		
		public System.Data.Linq.Table<CTASs> CTASses
		{
			get
			{
				return this.GetTable<CTASs>();
			}
		}
		
		public System.Data.Linq.Table<Entry> Entries
		{
			get
			{
				return this.GetTable<Entry>();
			}
		}
		
		public System.Data.Linq.Table<IVAttempts> IVAttempts
		{
			get
			{
				return this.GetTable<IVAttempts>();
			}
		}
		
		public System.Data.Linq.Table<SymptomReliefs> SymptomReliefs
		{
			get
			{
				return this.GetTable<SymptomReliefs>();
			}
		}
		
		public System.Data.Linq.Table<EntryDetail> EntryDetails
		{
			get
			{
				return this.GetTable<EntryDetail>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CallTypes")]
	public partial class CallTypes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Value;
		
		private bool _Active;
		
		private EntitySet<Entry> _Entries;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnValueChanging(string value);
    partial void OnValueChanged();
    partial void OnActiveChanging(bool value);
    partial void OnActiveChanged();
    #endregion
		
		public CallTypes()
		{
			this._Entries = new EntitySet<Entry>(new Action<Entry>(this.attach_Entries), new Action<Entry>(this.detach_Entries));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._Value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit NOT NULL")]
		public bool Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CallTypes_Entry", Storage="_Entries", ThisKey="ID", OtherKey="CallType")]
		public EntitySet<Entry> Entries
		{
			get
			{
				return this._Entries;
			}
			set
			{
				this._Entries.Assign(value);
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
		
		private void attach_Entries(Entry entity)
		{
			this.SendPropertyChanging();
			entity.CallTypes = this;
		}
		
		private void detach_Entries(Entry entity)
		{
			this.SendPropertyChanging();
			entity.CallTypes = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.VSAs")]
	public partial class VSAs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Value;
		
		private bool _Active;
		
		private EntitySet<Entry> _Entries;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnValueChanging(string value);
    partial void OnValueChanged();
    partial void OnActiveChanging(bool value);
    partial void OnActiveChanged();
    #endregion
		
		public VSAs()
		{
			this._Entries = new EntitySet<Entry>(new Action<Entry>(this.attach_Entries), new Action<Entry>(this.detach_Entries));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._Value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit NOT NULL")]
		public bool Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="VSAs_Entry", Storage="_Entries", ThisKey="ID", OtherKey="VSA")]
		public EntitySet<Entry> Entries
		{
			get
			{
				return this._Entries;
			}
			set
			{
				this._Entries.Assign(value);
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
		
		private void attach_Entries(Entry entity)
		{
			this.SendPropertyChanging();
			entity.VSAs = this;
		}
		
		private void detach_Entries(Entry entity)
		{
			this.SendPropertyChanging();
			entity.VSAs = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CTASs")]
	public partial class CTASs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Value;
		
		private bool _Active;
		
		private EntitySet<Entry> _Entries;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnValueChanging(string value);
    partial void OnValueChanged();
    partial void OnActiveChanging(bool value);
    partial void OnActiveChanged();
    #endregion
		
		public CTASs()
		{
			this._Entries = new EntitySet<Entry>(new Action<Entry>(this.attach_Entries), new Action<Entry>(this.detach_Entries));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="NVarChar(12) NOT NULL", CanBeNull=false)]
		public string Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._Value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit NOT NULL")]
		public bool Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CTASs_Entry", Storage="_Entries", ThisKey="ID", OtherKey="CTAS")]
		public EntitySet<Entry> Entries
		{
			get
			{
				return this._Entries;
			}
			set
			{
				this._Entries.Assign(value);
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
		
		private void attach_Entries(Entry entity)
		{
			this.SendPropertyChanging();
			entity.CTASs = this;
		}
		
		private void detach_Entries(Entry entity)
		{
			this.SendPropertyChanging();
			entity.CTASs = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Entries")]
	public partial class Entry : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.DateTime _Date;
		
		private string _CallNumber;
		
		private System.TimeSpan _T2;
		
		private System.TimeSpan _T3;
		
		private System.TimeSpan _T4;
		
		private int _CTAS;
		
		private int _CallType;
		
		private int _VSA;
		
		private int _SymptomRelief;
		
		private int _IVAttempt;
		
		private System.DateTime _DateEntered;
		
		private string _EnteredBy;
		
		private EntityRef<CallTypes> _CallTypes;
		
		private EntityRef<CTASs> _CTASs;
		
		private EntityRef<VSAs> _VSAs;
		
		private EntityRef<IVAttempts> _IVAttempts;
		
		private EntityRef<SymptomReliefs> _SymptomReliefs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnCallNumberChanging(string value);
    partial void OnCallNumberChanged();
    partial void OnT2Changing(System.TimeSpan value);
    partial void OnT2Changed();
    partial void OnT3Changing(System.TimeSpan value);
    partial void OnT3Changed();
    partial void OnT4Changing(System.TimeSpan value);
    partial void OnT4Changed();
    partial void OnCTASChanging(int value);
    partial void OnCTASChanged();
    partial void OnCallTypeChanging(int value);
    partial void OnCallTypeChanged();
    partial void OnVSAChanging(int value);
    partial void OnVSAChanged();
    partial void OnSymptomReliefChanging(int value);
    partial void OnSymptomReliefChanged();
    partial void OnIVAttemptChanging(int value);
    partial void OnIVAttemptChanged();
    partial void OnDateEnteredChanging(System.DateTime value);
    partial void OnDateEnteredChanged();
    partial void OnEnteredByChanging(string value);
    partial void OnEnteredByChanged();
    #endregion
		
		public Entry()
		{
			this._CallTypes = default(EntityRef<CallTypes>);
			this._CTASs = default(EntityRef<CTASs>);
			this._VSAs = default(EntityRef<VSAs>);
			this._IVAttempts = default(EntityRef<IVAttempts>);
			this._SymptomReliefs = default(EntityRef<SymptomReliefs>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CallNumber", DbType="NVarChar(8) NOT NULL", CanBeNull=false)]
		public string CallNumber
		{
			get
			{
				return this._CallNumber;
			}
			set
			{
				if ((this._CallNumber != value))
				{
					this.OnCallNumberChanging(value);
					this.SendPropertyChanging();
					this._CallNumber = value;
					this.SendPropertyChanged("CallNumber");
					this.OnCallNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_T2", DbType="Time NOT NULL")]
		public System.TimeSpan T2
		{
			get
			{
				return this._T2;
			}
			set
			{
				if ((this._T2 != value))
				{
					this.OnT2Changing(value);
					this.SendPropertyChanging();
					this._T2 = value;
					this.SendPropertyChanged("T2");
					this.OnT2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_T3", DbType="Time NOT NULL")]
		public System.TimeSpan T3
		{
			get
			{
				return this._T3;
			}
			set
			{
				if ((this._T3 != value))
				{
					this.OnT3Changing(value);
					this.SendPropertyChanging();
					this._T3 = value;
					this.SendPropertyChanged("T3");
					this.OnT3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_T4", DbType="Time NOT NULL")]
		public System.TimeSpan T4
		{
			get
			{
				return this._T4;
			}
			set
			{
				if ((this._T4 != value))
				{
					this.OnT4Changing(value);
					this.SendPropertyChanging();
					this._T4 = value;
					this.SendPropertyChanged("T4");
					this.OnT4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTAS", DbType="Int NOT NULL")]
		public int CTAS
		{
			get
			{
				return this._CTAS;
			}
			set
			{
				if ((this._CTAS != value))
				{
					if (this._CTASs.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCTASChanging(value);
					this.SendPropertyChanging();
					this._CTAS = value;
					this.SendPropertyChanged("CTAS");
					this.OnCTASChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CallType", DbType="Int NOT NULL")]
		public int CallType
		{
			get
			{
				return this._CallType;
			}
			set
			{
				if ((this._CallType != value))
				{
					if (this._CallTypes.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCallTypeChanging(value);
					this.SendPropertyChanging();
					this._CallType = value;
					this.SendPropertyChanged("CallType");
					this.OnCallTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VSA", DbType="Int NOT NULL")]
		public int VSA
		{
			get
			{
				return this._VSA;
			}
			set
			{
				if ((this._VSA != value))
				{
					if (this._VSAs.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnVSAChanging(value);
					this.SendPropertyChanging();
					this._VSA = value;
					this.SendPropertyChanged("VSA");
					this.OnVSAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SymptomRelief", DbType="Int NOT NULL")]
		public int SymptomRelief
		{
			get
			{
				return this._SymptomRelief;
			}
			set
			{
				if ((this._SymptomRelief != value))
				{
					if (this._SymptomReliefs.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSymptomReliefChanging(value);
					this.SendPropertyChanging();
					this._SymptomRelief = value;
					this.SendPropertyChanged("SymptomRelief");
					this.OnSymptomReliefChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IVAttempt", DbType="Int NOT NULL")]
		public int IVAttempt
		{
			get
			{
				return this._IVAttempt;
			}
			set
			{
				if ((this._IVAttempt != value))
				{
					if (this._IVAttempts.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIVAttemptChanging(value);
					this.SendPropertyChanging();
					this._IVAttempt = value;
					this.SendPropertyChanged("IVAttempt");
					this.OnIVAttemptChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateEntered", DbType="DateTime NOT NULL")]
		public System.DateTime DateEntered
		{
			get
			{
				return this._DateEntered;
			}
			set
			{
				if ((this._DateEntered != value))
				{
					this.OnDateEnteredChanging(value);
					this.SendPropertyChanging();
					this._DateEntered = value;
					this.SendPropertyChanged("DateEntered");
					this.OnDateEnteredChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EnteredBy", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string EnteredBy
		{
			get
			{
				return this._EnteredBy;
			}
			set
			{
				if ((this._EnteredBy != value))
				{
					this.OnEnteredByChanging(value);
					this.SendPropertyChanging();
					this._EnteredBy = value;
					this.SendPropertyChanged("EnteredBy");
					this.OnEnteredByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CallTypes_Entry", Storage="_CallTypes", ThisKey="CallType", OtherKey="ID", IsForeignKey=true)]
		public CallTypes CallTypes
		{
			get
			{
				return this._CallTypes.Entity;
			}
			set
			{
				CallTypes previousValue = this._CallTypes.Entity;
				if (((previousValue != value) 
							|| (this._CallTypes.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CallTypes.Entity = null;
						previousValue.Entries.Remove(this);
					}
					this._CallTypes.Entity = value;
					if ((value != null))
					{
						value.Entries.Add(this);
						this._CallType = value.ID;
					}
					else
					{
						this._CallType = default(int);
					}
					this.SendPropertyChanged("CallTypes");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CTASs_Entry", Storage="_CTASs", ThisKey="CTAS", OtherKey="ID", IsForeignKey=true)]
		public CTASs CTASs
		{
			get
			{
				return this._CTASs.Entity;
			}
			set
			{
				CTASs previousValue = this._CTASs.Entity;
				if (((previousValue != value) 
							|| (this._CTASs.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CTASs.Entity = null;
						previousValue.Entries.Remove(this);
					}
					this._CTASs.Entity = value;
					if ((value != null))
					{
						value.Entries.Add(this);
						this._CTAS = value.ID;
					}
					else
					{
						this._CTAS = default(int);
					}
					this.SendPropertyChanged("CTASs");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="VSAs_Entry", Storage="_VSAs", ThisKey="VSA", OtherKey="ID", IsForeignKey=true)]
		public VSAs VSAs
		{
			get
			{
				return this._VSAs.Entity;
			}
			set
			{
				VSAs previousValue = this._VSAs.Entity;
				if (((previousValue != value) 
							|| (this._VSAs.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._VSAs.Entity = null;
						previousValue.Entries.Remove(this);
					}
					this._VSAs.Entity = value;
					if ((value != null))
					{
						value.Entries.Add(this);
						this._VSA = value.ID;
					}
					else
					{
						this._VSA = default(int);
					}
					this.SendPropertyChanged("VSAs");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="IVAttempts_Entry", Storage="_IVAttempts", ThisKey="IVAttempt", OtherKey="ID", IsForeignKey=true)]
		public IVAttempts IVAttempts
		{
			get
			{
				return this._IVAttempts.Entity;
			}
			set
			{
				IVAttempts previousValue = this._IVAttempts.Entity;
				if (((previousValue != value) 
							|| (this._IVAttempts.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._IVAttempts.Entity = null;
						previousValue.Entries.Remove(this);
					}
					this._IVAttempts.Entity = value;
					if ((value != null))
					{
						value.Entries.Add(this);
						this._IVAttempt = value.ID;
					}
					else
					{
						this._IVAttempt = default(int);
					}
					this.SendPropertyChanged("IVAttempts");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SymptomReliefs_Entry", Storage="_SymptomReliefs", ThisKey="SymptomRelief", OtherKey="ID", IsForeignKey=true)]
		public SymptomReliefs SymptomReliefs
		{
			get
			{
				return this._SymptomReliefs.Entity;
			}
			set
			{
				SymptomReliefs previousValue = this._SymptomReliefs.Entity;
				if (((previousValue != value) 
							|| (this._SymptomReliefs.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SymptomReliefs.Entity = null;
						previousValue.Entries.Remove(this);
					}
					this._SymptomReliefs.Entity = value;
					if ((value != null))
					{
						value.Entries.Add(this);
						this._SymptomRelief = value.ID;
					}
					else
					{
						this._SymptomRelief = default(int);
					}
					this.SendPropertyChanged("SymptomReliefs");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.IVAttempts")]
	public partial class IVAttempts : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Value;
		
		private bool _Active;
		
		private EntitySet<Entry> _Entries;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnValueChanging(string value);
    partial void OnValueChanged();
    partial void OnActiveChanging(bool value);
    partial void OnActiveChanged();
    #endregion
		
		public IVAttempts()
		{
			this._Entries = new EntitySet<Entry>(new Action<Entry>(this.attach_Entries), new Action<Entry>(this.detach_Entries));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._Value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit NOT NULL")]
		public bool Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="IVAttempts_Entry", Storage="_Entries", ThisKey="ID", OtherKey="IVAttempt")]
		public EntitySet<Entry> Entries
		{
			get
			{
				return this._Entries;
			}
			set
			{
				this._Entries.Assign(value);
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
		
		private void attach_Entries(Entry entity)
		{
			this.SendPropertyChanging();
			entity.IVAttempts = this;
		}
		
		private void detach_Entries(Entry entity)
		{
			this.SendPropertyChanging();
			entity.IVAttempts = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SymptomReliefs")]
	public partial class SymptomReliefs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Value;
		
		private bool _Active;
		
		private EntitySet<Entry> _Entries;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnValueChanging(string value);
    partial void OnValueChanged();
    partial void OnActiveChanging(bool value);
    partial void OnActiveChanged();
    #endregion
		
		public SymptomReliefs()
		{
			this._Entries = new EntitySet<Entry>(new Action<Entry>(this.attach_Entries), new Action<Entry>(this.detach_Entries));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._Value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit NOT NULL")]
		public bool Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SymptomReliefs_Entry", Storage="_Entries", ThisKey="ID", OtherKey="SymptomRelief")]
		public EntitySet<Entry> Entries
		{
			get
			{
				return this._Entries;
			}
			set
			{
				this._Entries.Assign(value);
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
		
		private void attach_Entries(Entry entity)
		{
			this.SendPropertyChanging();
			entity.SymptomReliefs = this;
		}
		
		private void detach_Entries(Entry entity)
		{
			this.SendPropertyChanging();
			entity.SymptomReliefs = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EntryDetails")]
	public partial class EntryDetail
	{
		
		private int _ID;
		
		private System.DateTime _Date;
		
		private string _CallNumber;
		
		private System.TimeSpan _T2;
		
		private System.TimeSpan _T3;
		
		private System.TimeSpan _T4;
		
		private string _CTAS;
		
		private string _CallType;
		
		private string _VSA;
		
		private string _SymptomRelief;
		
		private string _IVAttempt;
		
		private System.DateTime _DateEntered;
		
		private string _EnteredBy;
		
		private System.Nullable<int> _TDiff;
		
		private int _CTAS_raw;
		
		private int _VSA_raw;
		
		public EntryDetail()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this._Date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CallNumber", DbType="NVarChar(8) NOT NULL", CanBeNull=false)]
		public string CallNumber
		{
			get
			{
				return this._CallNumber;
			}
			set
			{
				if ((this._CallNumber != value))
				{
					this._CallNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_T2", DbType="Time NOT NULL")]
		public System.TimeSpan T2
		{
			get
			{
				return this._T2;
			}
			set
			{
				if ((this._T2 != value))
				{
					this._T2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_T3", DbType="Time NOT NULL")]
		public System.TimeSpan T3
		{
			get
			{
				return this._T3;
			}
			set
			{
				if ((this._T3 != value))
				{
					this._T3 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_T4", DbType="Time NOT NULL")]
		public System.TimeSpan T4
		{
			get
			{
				return this._T4;
			}
			set
			{
				if ((this._T4 != value))
				{
					this._T4 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTAS", DbType="NVarChar(12)")]
		public string CTAS
		{
			get
			{
				return this._CTAS;
			}
			set
			{
				if ((this._CTAS != value))
				{
					this._CTAS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CallType", DbType="NVarChar(50)")]
		public string CallType
		{
			get
			{
				return this._CallType;
			}
			set
			{
				if ((this._CallType != value))
				{
					this._CallType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VSA", DbType="NVarChar(25)")]
		public string VSA
		{
			get
			{
				return this._VSA;
			}
			set
			{
				if ((this._VSA != value))
				{
					this._VSA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SymptomRelief", DbType="NVarChar(50)")]
		public string SymptomRelief
		{
			get
			{
				return this._SymptomRelief;
			}
			set
			{
				if ((this._SymptomRelief != value))
				{
					this._SymptomRelief = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IVAttempt", DbType="NVarChar(25)")]
		public string IVAttempt
		{
			get
			{
				return this._IVAttempt;
			}
			set
			{
				if ((this._IVAttempt != value))
				{
					this._IVAttempt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateEntered", DbType="DateTime NOT NULL")]
		public System.DateTime DateEntered
		{
			get
			{
				return this._DateEntered;
			}
			set
			{
				if ((this._DateEntered != value))
				{
					this._DateEntered = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EnteredBy", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string EnteredBy
		{
			get
			{
				return this._EnteredBy;
			}
			set
			{
				if ((this._EnteredBy != value))
				{
					this._EnteredBy = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TDiff", DbType="Int")]
		public System.Nullable<int> TDiff
		{
			get
			{
				return this._TDiff;
			}
			set
			{
				if ((this._TDiff != value))
				{
					this._TDiff = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTAS_raw", DbType="Int NOT NULL")]
		public int CTAS_raw
		{
			get
			{
				return this._CTAS_raw;
			}
			set
			{
				if ((this._CTAS_raw != value))
				{
					this._CTAS_raw = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VSA_raw", DbType="Int NOT NULL")]
		public int VSA_raw
		{
			get
			{
				return this._VSA_raw;
			}
			set
			{
				if ((this._VSA_raw != value))
				{
					this._VSA_raw = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
