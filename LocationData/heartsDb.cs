// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from main on 2013-09-01 13:49:59Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//

using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Data.Linq.Mapping;
using DbLinq.Data.Linq;
using DbLinq.Schema;
using DbLinq.Vendor;

namespace LocationData
{
  public partial class Main : DataContext
  {

    #region Extensibility Method Declarations
    partial void OnCreated();
    #endregion


    public Main(string connectionString) :
      base(connectionString)
    {
      this.OnCreated();
    }

    public Main(string connection, MappingSource mappingSource) :
      base(connection, mappingSource)
    {
      this.OnCreated();
    }

    public Main(IDbConnection connection, MappingSource mappingSource) :
      base(connection, mappingSource)
    {
      this.OnCreated();
    }

    public Table<AEdLocation> AEdLocation
    {
      get
      {
        return this.GetTable<AEdLocation>();
      }
    }
  }

  #region Start MONO_STRICT
#if MONO_STRICT

public partial class Main
{
  
  public Main(IDbConnection connection) : 
      base(connection)
  {
    this.OnCreated();
  }
}
  #region End MONO_STRICT
#endregion
#else     // MONO_STRICT

  public partial class Main
  {

    public Main(IDbConnection connection) :
      base(connection, new DbLinq.Sqlite.SqliteVendor())
    {
      this.OnCreated();
    }

    public Main(IDbConnection connection, IVendor sqlDialect) :
      base(connection, sqlDialect)
    {
      this.OnCreated();
    }

    public Main(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) :
      base(connection, mappingSource, sqlDialect)
    {
      this.OnCreated();
    }
  }
  #region End Not MONO_STRICT
  #endregion
#endif     // MONO_STRICT
  #endregion

  [Table(Name = "main.AED_LOCATION")]
  public partial class AEdLocation : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
  {

    private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

    private string _address;

    private string _comments;

    private string _contact;

    private string _email;

    private string _firstName;

    private int _id;

    private string _lastName;

    private System.Nullable<float> _latitude;

    private System.Nullable<float> _longitude;

    private string _phone;

    private bool _publicAccess;

    #region Extensibility Method Declarations
    partial void OnCreated();

    partial void OnAddressChanged();

    partial void OnAddressChanging(string value);

    partial void OnCommentsChanged();

    partial void OnCommentsChanging(string value);

    partial void OnContactChanged();

    partial void OnContactChanging(string value);

    partial void OnEmailChanged();

    partial void OnEmailChanging(string value);

    partial void OnFirstNameChanged();

    partial void OnFirstNameChanging(string value);

    partial void OnIDChanged();

    partial void OnIDChanging(int value);

    partial void OnLastNameChanged();

    partial void OnLastNameChanging(string value);

    partial void OnLatitudeChanged();

    partial void OnLatitudeChanging(System.Nullable<float> value);

    partial void OnLongitudeChanged();

    partial void OnLongitudeChanging(System.Nullable<float> value);

    partial void OnPhoneChanged();

    partial void OnPhoneChanging(string value);

    partial void OnPublicAccessChanged();

    partial void OnPublicAccessChanging(bool value);
    #endregion


    public AEdLocation()
    {
      this.OnCreated();
    }

    public AEdLocation(NameValueCollection collection)
    {
      int id;
      float latitude;
      float longitude;

      this.OnCreated();
      if (!string.IsNullOrEmpty(collection["ID"]) && int.TryParse(collection["ID"], out id))
      {
        this.ID = id;
      }
      this.Address = collection["Address"];
      this.Comments = collection["Comments"];
      this.Contact = collection["Contact"];
      this.Email = collection["Email"];
      this.FirstName = collection["FirstName"];
      this.LastName = collection["LastName"];
      this.PublicAccess = collection["PublicAccess"].Contains("true");
      this.Phone = collection["Phone"];
      this.Latitude = float.TryParse(collection["Latitude"], out latitude) ? latitude : default(float?);
      this.Longitude = float.TryParse(collection["Longitude"], out longitude) ? longitude : default(float?);
    }

    [Column(Storage = "_address", Name = "ADDRESS", DbType = "VARCHAR(124)", AutoSync = AutoSync.Never)]
    [DebuggerNonUserCode()]
    public string Address
    {
      get
      {
        return this._address;
      }
      set
      {
        if (((_address == value)
             == false))
        {
          this.OnAddressChanging(value);
          this.SendPropertyChanging();
          this._address = value;
          this.SendPropertyChanged("Address");
          this.OnAddressChanged();
        }
      }
    }

    [Column(Storage = "_comments", Name = "COMMENTS", DbType = "TEXT", AutoSync = AutoSync.Never)]
    [DebuggerNonUserCode()]
    public string Comments
    {
      get
      {
        return this._comments;
      }
      set
      {
        if (((_comments == value)
             == false))
        {
          this.OnCommentsChanging(value);
          this.SendPropertyChanging();
          this._comments = value;
          this.SendPropertyChanged("Comments");
          this.OnCommentsChanged();
        }
      }
    }

    [Column(Storage = "_contact", Name = "CONTACT", DbType = "VARCHAR(124)", AutoSync = AutoSync.Never)]
    [DebuggerNonUserCode()]
    public string Contact
    {
      get
      {
        return this._contact;
      }
      set
      {
        if (((_contact == value)
             == false))
        {
          this.OnContactChanging(value);
          this.SendPropertyChanging();
          this._contact = value;
          this.SendPropertyChanged("Contact");
          this.OnContactChanged();
        }
      }
    }

    [Column(Storage = "_email", Name = "EMAIL", DbType = "VARCHAR(124)", AutoSync = AutoSync.Never)]
    [DebuggerNonUserCode()]
    public string Email
    {
      get
      {
        return this._email;
      }
      set
      {
        if (((_email == value)
             == false))
        {
          this.OnEmailChanging(value);
          this.SendPropertyChanging();
          this._email = value;
          this.SendPropertyChanged("Email");
          this.OnEmailChanged();
        }
      }
    }

    [Column(Storage = "_firstName", Name = "FIRST_NAME", DbType = "VARCHAR(60)", AutoSync = AutoSync.Never)]
    [DebuggerNonUserCode()]
    public string FirstName
    {
      get
      {
        return this._firstName;
      }
      set
      {
        if (((_firstName == value)
             == false))
        {
          this.OnFirstNameChanging(value);
          this.SendPropertyChanging();
          this._firstName = value;
          this.SendPropertyChanged("FirstName");
          this.OnFirstNameChanged();
        }
      }
    }

    [Column(Storage = "_id", Name = "id", DbType = "INTEGER", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
    [DebuggerNonUserCode()]
    public int ID
    {
      get
      {
        return this._id;
      }
      set
      {
        if ((_id != value))
        {
          this.OnIDChanging(value);
          this.SendPropertyChanging();
          this._id = value;
          this.SendPropertyChanged("ID");
          this.OnIDChanged();
        }
      }
    }

    [Column(Storage = "_lastName", Name = "LAST_NAME", DbType = "VARCHAR(80)", AutoSync = AutoSync.Never, CanBeNull = false)]
    [DebuggerNonUserCode()]
    public string LastName
    {
      get
      {
        return this._lastName;
      }
      set
      {
        if (((_lastName == value)
             == false))
        {
          this.OnLastNameChanging(value);
          this.SendPropertyChanging();
          this._lastName = value;
          this.SendPropertyChanged("LastName");
          this.OnLastNameChanged();
        }
      }
    }

    [Column(Storage = "_latitude", Name = "LATITUDE", DbType = "FLOAT", AutoSync = AutoSync.Never)]
    [DebuggerNonUserCode()]
    public System.Nullable<float> Latitude
    {
      get
      {
        return this._latitude;
      }
      set
      {
        if ((_latitude != value))
        {
          this.OnLatitudeChanging(value);
          this.SendPropertyChanging();
          this._latitude = value;
          this.SendPropertyChanged("Latitude");
          this.OnLatitudeChanged();
        }
      }
    }

    [Column(Storage = "_longitude", Name = "LONGITUDE", DbType = "FLOAT", AutoSync = AutoSync.Never)]
    [DebuggerNonUserCode()]
    public System.Nullable<float> Longitude
    {
      get
      {
        return this._longitude;
      }
      set
      {
        if ((_longitude != value))
        {
          this.OnLongitudeChanging(value);
          this.SendPropertyChanging();
          this._longitude = value;
          this.SendPropertyChanged("Longitude");
          this.OnLongitudeChanged();
        }
      }
    }

    [Column(Storage = "_phone", Name = "PHONE", DbType = "VARCHAR(14)", AutoSync = AutoSync.Never)]
    [DebuggerNonUserCode()]
    public string Phone
    {
      get
      {
        return this._phone;
      }
      set
      {
        if (((_phone == value)
             == false))
        {
          this.OnPhoneChanging(value);
          this.SendPropertyChanging();
          this._phone = value;
          this.SendPropertyChanged("Phone");
          this.OnPhoneChanged();
        }
      }
    }

    [Column(Storage = "_publicAccess", Name = "PUBLIC_ACCESS", DbType = "BOOLEAN", AutoSync = AutoSync.Never, CanBeNull = false)]
    [DebuggerNonUserCode()]
    public bool PublicAccess
    {
      get
      {
        return this._publicAccess;
      }
      set
      {
        if ((_publicAccess != value))
        {
          this.OnPublicAccessChanging(value);
          this.SendPropertyChanging();
          this._publicAccess = value;
          this.SendPropertyChanged("PublicAccess");
          this.OnPublicAccessChanged();
        }
      }
    }

    public string Name 
    {
      get { return (this.FirstName.Length > 0 ? this.FirstName + " " : "") + this.LastName; }
    }

    public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
      if ((h != null))
      {
        h(this, emptyChangingEventArgs);
      }
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
      if ((h != null))
      {
        h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
      }
    }
  }
}