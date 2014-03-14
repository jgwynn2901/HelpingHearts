using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Configuration;
using System.Linq;


namespace LocationData
{
  public class AedRepository
  {
    /// <summary>
    /// Gets the location list.
    /// </summary>
    /// <returns></returns>
    static public IEnumerable<AEdLocation> GetList()
    {
      using (var db = GetContext())
      {
        return db.AEdLocation.Select(a => a).ToList();
      }
    }

    static private Main GetContext()
    {
      var connectionString = string.Empty;
      try
      {
        connectionString = ConfigurationManager.ConnectionStrings["Locations"].ConnectionString;
        var cnn = new SQLiteConnection(connectionString);
        return new Main(cnn);

      }
      catch (Exception )
      {
        if (string.IsNullOrEmpty(connectionString))
          throw;
        throw new ApplicationException(connectionString);
      }
    }

    static public AEdLocation Find(int id)
    {
      using (var db = GetContext())
      {
        return db.AEdLocation.FirstOrDefault(a => a.ID == id);
      }
    }

    static public bool Delete(int id)
    {
      using (var db = GetContext())
      {
        var record = db.AEdLocation.FirstOrDefault(a => a.ID == id);
        db.AEdLocation.DeleteOnSubmit(record);
        // Submit the change to the database.
        try
        {
          db.SubmitChanges();
        }
        catch (Exception)
        {
          return false;
        }
      }
      return true;
    }

    /// <summary>
    /// Inserts the specified location.
    /// </summary>
    /// <param name="location">The location.</param>
    /// <returns></returns>
    static public bool Insert(AEdLocation location)
    {
      using (var db = GetContext())
      {

        // Add the new object to the AEdLocation collection.
        db.AEdLocation.InsertOnSubmit(location);

        // Submit the change to the database.
        try
        {
          db.SubmitChanges();
        }
        catch (Exception)
        {
          return false;
        }
      }
      return true;
    }

    public static bool Update(AEdLocation rec)
    {
      using (var db = GetContext())
      {

        // Add the new object to the AEdLocation collection.
        var current = db.AEdLocation.FirstOrDefault(a => a.ID == rec.ID);
        if (current == null)
          return false;

        current.Contact = rec.Contact;
        current.Address = rec.Address;
        current.Comments = rec.Comments;
        current.Email = rec.Email;
        current.FirstName = rec.FirstName;
        current.LastName = rec.LastName;
        current.Phone = rec.Phone;
        current.Latitude = rec.Latitude;
        current.Longitude = rec.Longitude;
        current.PublicAccess = rec.PublicAccess;

        // Submit the change to the database.
        try
        {
          db.SubmitChanges();
        }
        catch (Exception)
        {
          return false;
        }
      }
      return true;
    }
  }
}
