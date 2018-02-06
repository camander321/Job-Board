using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using JobBoard.Models;

namespace JobBoard.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View(JobOpening.GetAll());
    }

    [HttpGet("/new-job")]
    public ActionResult JobForm()
    {
      return View();
    }

    [HttpPost("/confirm")]
    public ActionResult AddJob()
    {
      //int numJobs = JobOpening.GetAll().Count;
      JobOpening newJob = new JobOpening(
        Request.Form["title"],
        Request.Form["description"],
        Request.Form["company"],
        Request.Form["startDate"],
        Request.Form["salary"]
      );

      // if (numJobs == JobOpening.GetAll().Count)
      //   return View("TryAgain");
      // else
        return View("Confirmation", newJob);
    }

    [HttpGet("/jobs/{id}")]
    public ActionResult Detail(int id)
    {
      JobOpening job = JobOpening.Find(id);
      return View(job);
    }

  }
}
