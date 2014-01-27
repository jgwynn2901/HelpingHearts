using System.Web.Mvc;
using HelpingHeartsService;
using HelpingHeartsService.Models;

namespace HelpingHearts.Controllers
{
  public class LocationController : Controller
  {
    //
    // GET: /Location/

    public ActionResult Index()
    {
      var model = AedRepository.GetList();

      return View(model);
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
        return Create();
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
