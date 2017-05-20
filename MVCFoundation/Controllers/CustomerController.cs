﻿using MVCFoundation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFoundation.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Customer/Details/5
        [Route("Customer/{id:int}")]
        [Route("Customer/Detail/{id:int}")]     
        public ActionResult Details(int id)
        {
            var customer = new CustomerModel
            {
                EmailAddress = "carlton@company.com",
                FirstName = "Carlton"
            };
            return View(customer);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Search()
        {
            return Content("Search Reached");
        }

        public ActionResult GetById(int id)
        {
            var customers = new List<CustomerModel>
            {
                new CustomerModel {Id =1, EmailAddress = "carl@company.com", FirstName="Carl"},
                new CustomerModel {Id=2, EmailAddress = "lisa@company.com", FirstName="Lisa"},
                new CustomerModel {Id=3, EmailAddress= "joanna@company.com", FirstName="Joanna"}
            };
            var customer = customers.FirstOrDefault<CustomerModel>(c => c.Id.Equals(id));
            return View("Details", customer);
        }
    }
}
