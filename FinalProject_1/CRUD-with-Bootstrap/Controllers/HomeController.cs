using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_with_Bootstrap.Models;

namespace CRUD_with_Bootstrap.Controllers
{
	public class HomeController : Controller
	{
		ContactsDBEntities1 db = new ContactsDBEntities1();

		public ActionResult ContactData()
		{
			List<Contact> cct = db.Contacts.ToList();
			return View(cct);
		}

		[HttpGet]
		public ActionResult Create()
		{
			return PartialView("_Create");
		}

		[HttpPost]
		public ActionResult Create(Contact cntct)
		{
			try
			{
				if (cntct != null)
				{
					Contact contactData = new Contact();
					contactData.Name = cntct.Name;
					contactData.Email = cntct.Email;
					contactData.Phone = cntct.Phone;
					contactData.Title = cntct.Title;
					contactData.Created_date = DateTime.Now;

					db.Contacts.Add(contactData);
					db.SaveChanges();
				}
				return RedirectToAction("ContactData");
			}
			catch (Exception)
			{
				ViewBag.msg = "Some error occured.";
				return RedirectToAction("ContactData");
			}
		}

		[HttpGet]
		public ActionResult EditUpdate(int id)
		{
			try
			{
				if (id != 0)
				{
					Contact cct_data = db.Contacts.SingleOrDefault(x => x.Id == id);
					return PartialView("_EditUpdate", cct_data);
				}
				else
				{
					return RedirectToAction("ContactData");
				}
			}
			catch (Exception)
			{
				ViewBag.msg = "Some error occured.";
				return RedirectToAction("ContactData");
			}
		}
		[HttpPost]
		public ActionResult EditUpdate(Contact cct_modified)
		{
			try
			{
				if (cct_modified != null)
				{
					Contact cct_update = db.Contacts.SingleOrDefault(x => 
														x.Id == cct_modified.Id);
					cct_update.Name = cct_modified.Name;
					cct_update.Email = cct_modified.Email;
					cct_update.Phone = cct_modified.Phone;
					cct_update.Title = cct_modified.Title;
					db.SaveChanges();
				}
				return RedirectToAction("ContactData");
			}
			catch (Exception)
			{
				ViewBag.msg = "Some error occured.";
				return RedirectToAction("ContactData");
			}
		}


		[HttpPost]
		public ActionResult Delete(int id)
		{
			try
			{
				Contact cct_data = db.Contacts.SingleOrDefault(x => x.Id == id);
				if (cct_data != null)
				{
					db.Contacts.Remove(cct_data);
					db.SaveChanges();
				}
				return RedirectToAction("ContactData");
			}
			catch (Exception)
			{
				ViewBag.msg = "Some error occured.";
				return RedirectToAction("ContactData");
			}
		}
	}
}