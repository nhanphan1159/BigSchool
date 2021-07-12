using BigSchool.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        private IEnumerable<Course> UpcommingCourses { set; get; }

        public bool ShowAction { set; get; }
    }
    public ActionResult Create()
    {
        var viewModel = new CourseViewModel
        {
            Categories = _dbContext.Categories.ToList(),
            Heading = "Add Course"
        };
        return View(viewModels);
    }
    public ActionResult Edit(int id)
    {
        var userId = User.Identity.GetUSerId();
        var course = _dbContext.Courses.Single(c => c.Id == id && c.LecturerId == userId);

        var viewModel = new CourseViewModel
        {
            Categories = _dbContext.Categories.ToList(),
            Date = course.DateTime.ToString("dd/mm/yyyy"),
            Time = course.DateTime.ToString("HH:mm"),
            Category = course.CategoryId,
            Place = course.Place,
            Heading = "Edit Course",
            Id = course.Id
        };
    }
    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Update(CourseViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            viewModel.Categories = _dbContext.Categories.Tolist();
            return ("Create", viewModel);
        }
        var userId = User.Identity.GetUserId();
        var course = _dbContext.Courses.Singgle(c => c.Id == viewModel.Id && c.LecturerId == userId);

        course.Place = viewModel.Place;
        course.DateTime = viewModel.GetDateTime();
        course.CategoryId = viewModel.Categories;
        _dbContext.SaveChanges();
        return RedirectToAction("Index","Home");
    }
}