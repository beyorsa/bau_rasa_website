﻿using bau_rasa.web.Entity;
using bau_rasa.web.Identity;
using bau_rasa.web.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bau_rasa.web.Controllers
{
    public class AccountController : Controller
    {
        private DataContext db = new DataContext();
        private UserManager<ApplicationUser> UserManager;
        private RoleManager<ApplicationRole> RoleManager;

        public AccountController()
        {
            var userStore = new UserStore<ApplicationUser>(new IdentityDataContext());
            UserManager = new UserManager<ApplicationUser>(userStore);

            var roleStore = new RoleStore<ApplicationRole>(new IdentityDataContext());
            RoleManager = new RoleManager<ApplicationRole>(roleStore);
        }

        [Authorize]
        public ActionResult Index()
        {
            var UserName = User.Identity.Name;
            var orders = db.Orders
                .Where(i => i.UserName == UserName)
                .Select(i => new UserOrderModel()
                {
                    Id = i.Id,
                    OrderNumber = i.OrderNumber,
                    OrderDate = i.OrderDate,
                    OrderState = i.OrderState,
                    Total = i.Total
                }).OrderByDescending(i => i.OrderDate).ToList();


            return View(orders);
        }
        [Authorize]
        public ActionResult Details(int id)
        {
            var entity = db.Orders.Where(i => i.Id == id)
                .Select(i => new OrderDetailsModel()
                {

                    OrderId = i.Id,
                    OrderNumber = i.OrderNumber,
                    Total = i.Total,
                    OrderDate = i.OrderDate,
                    OrderState = i.OrderState,
                    AdresBasligi = i.AdresBasligi,
                    Adres = i.Adres,
                    Sehir = i.Sehir,
                    Semt = i.Semt,
                    Mahalle = i.Mahalle,
                    PostaKodu = i.PostaKodu,
                    Orderlines = i.Orderlines.Select(a => new OrderLineModel()
                    {
                        ProductId = a.ProductId,
                        ProductName = a.Product.Name,
                        Image = a.Product.Image,
                        Qunatity = a.Qunatity,
                        Price = a.Price
                    }).ToList()

                }).FirstOrDefault();

            return View(entity);
        }


        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {

            if (ModelState.IsValid)
            {
                //Kayıt İşlemleri

                var user = new ApplicationUser();
                user.Name = model.Name;
                user.Surname = model.SurName;
                user.Email = model.Email;
                user.UserName = model.UserName;

                IdentityResult result = UserManager.Create(user, model.Password);

                if (result.Succeeded)
                {
                    // kullanıcı oluştu ve kullanıcıyı bir role atayabilirsiniz.

                    if (RoleManager.RoleExists("user"))
                    {
                        UserManager.AddToRole(user.Id, "user");
                    }
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("RegisterUserError", "Kullanıcı Oluşturma Hatası");
                }

            }
            return View(model);
        }


        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model, string ReturnUrl)
        {

            if (ModelState.IsValid)
            {
                //Login İşlemleri

                var user = UserManager.Find(model.UserName, model.Password);
                if (user != null)
                {
                    // varolan kullanıcıyı sisteme dahil et.
                    // ApplicationCookie oluşturup sisteme bırak.

                    var authManager = HttpContext.GetOwinContext().Authentication;
                    var identityclaims = UserManager.CreateIdentity(user, "ApplicationCookie");
                    var authProperties = new AuthenticationProperties();
                    authProperties.IsPersistent = model.RememberMe;
                    authManager.SignIn(authProperties, identityclaims);

                    if (!string.IsNullOrEmpty(ReturnUrl))
                    {
                        Redirect(ReturnUrl);
                    }

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("LoginUserError", "Kullanıcı bulunamadı");
                }

            }
            return View(model);
        }


        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();


            return RedirectToAction("Index", "Home");
        }
    }
}