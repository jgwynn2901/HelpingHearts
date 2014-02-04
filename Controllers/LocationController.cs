using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Web.Mvc;
using LocationData;

namespace HelpingHearts.Controllers
{
  public class LocationController : Controller
  {
    //
    // GET: /Location/

    public ActionResult Index()
    {
      try
      {
        var model = AedRepository.GetList();

        return View(model);
      }
      catch (Exception ex)
      {
        var path = Path.Combine(Environment.GetFolderPath(
          Environment.SpecialFolder.ApplicationData), "HelpingHearts.s3db");
        var list = new List<AEdLocation> { new AEdLocation { LastName = ex.Message, FirstName = ConfigurationManager.ConnectionStrings["Locations"].ConnectionString } };
        return View(list);
      }
      
    }

    //
    // GET: /Location/Details/5

    public ActionResult Details(int id)
    {
      return Index();
    }

    //
    // GET: /Location/Create

    public ActionResult Create()
    {
      return View();
    }

    //
    // POST: /Location/Create

    [HttpPost]
    public ActionResult Create(FormCollection collection)
    {
      try
      {
        // TODO: Add insert logic here
        AedRepository.Insert(new AEdLocation(collection));
        return RedirectToAction("Index");
      }
      catch
      {
        return View();
      }
    }

    //
    // GET: /Location/Edit/5

    public ActionResult Edit(int id)
    {
      var model = AedRepository.Find(id);
      return View(model);
    }

    //
    // POST: /Location/Edit/5

    [HttpPost]
    public ActionResult Edit(int id, FormCollection collection)
    {
      try
      {
        // TODO: Add update logic here
        AedRepository.Update(new AEdLocation(collection));
        return RedirectToAction("Index");
      }
      catch
      {
        return RedirectToAction("Error", "Error");
      }
    }

    //
    // GET: /Location/Delete/5

    //public ActionResult Delete(int id)
    //{
    //    return View();
    //}

    ////
    //// POST: /Location/Delete/5

    //[HttpPost]
    //public ActionResult Delete(int id, FormCollection collection)
    //{
    //    try
    //    {
    //        // TODO: Add delete logic here

    //        return RedirectToAction("Index");
    //    }
    //    catch
    //    {
    //        return View();
    //    }
    //}
  }
}
