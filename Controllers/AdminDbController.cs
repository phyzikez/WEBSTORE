using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Http;
using WebApplication117.Models;
using WebApplication117.Services;

namespace WebApplication117.Controllers
{
    public class AdminDbController : Controller
    {
        
        private readonly IMemoryCache memoryCache;
        public AppDbContext context;
        public AdminDbController(AppDbContext cont, IMemoryCache memoryCache)
        {
            context = cont;
            this.memoryCache = memoryCache;
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginModel user)
        {
            if (ModelState.IsValid)
            {
                if (Request.Cookies[Hasher.clogin] == null)
                {
                    var users = await context.users.ToListAsync();
                    if (user.UserLogin == users[0].Login && user.UserPassword == users[0].Password)
                    {
                        var prods = await context.products.ToListAsync();
                        return View(prods);
                    }
                    else
                    {
                        foreach (var usr in users)
                        {
                            if (usr.Login == user.UserLogin && usr.Password == user.UserPassword)
                            {
                                UserInfo userInfo = new UserInfo();
                                userInfo.User = usr;
                                var calls = await context.callbacks.ToListAsync();
                                userInfo.Callbacks = calls;

                                CookieOptions options = new CookieOptions();
                                options.Expires = DateTime.Now.AddMinutes(10);

                                // Should use some "enigma-mashine" to decode real login/pass or use Cash/TempData
                                Response.Cookies.Append(Hasher.clogin, usr.Login, options);
                                Response.Cookies.Append(Hasher.cpass, usr.Password, options);
                                ViewBag.clogin = Request.Cookies[Hasher.clogin];
                                ViewBag.cpass = Request.Cookies[Hasher.clogin];

                                return View("UserPage", userInfo);
                            }
                            else
                            {
                                ViewBag.Msg = "No access";
                            }
                        }
                    }
                }
                else
                {
                    ViewBag.Msg = "You need to exit before attempting loggining";
                }
            }
            else
            {
                ViewBag.Msg = "Bad inputs";
            }
            return View("Login");
        }


        public IActionResult UserPage()
        {
            ViewBag.clogin = Request.Cookies[Hasher.clogin];
            ViewBag.cpass = Request.Cookies[Hasher.clogin];
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductModel newProduct)
        {
            context.products.Add(newProduct);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound(); 
            }
            var product = await context.products.FirstOrDefaultAsync(pr => pr.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }



        [HttpPost]
        public async Task<IActionResult> Edit(int Id, ProductModel newProduct)
        {
            if (Id != newProduct.Id)
            {
                return NotFound();
            }

            context.products.Update(newProduct);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Delete(int? Id)
        {
           
            if (Id == null)
            {
                return NotFound(); 
            }

            var product = await context.products.FirstOrDefaultAsync(pr => pr.Id == Id);
            if (product == null) 
            {
                return NotFound(); 
            }

            return View(product);
        }

        [HttpPost]
        [ActionName("Delete")]
        
        public async Task<IActionResult> DeleteConfirm(int Id)
        {
            var product = await context.products.FindAsync(Id);
            context.products.Remove(product); 
            await context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Signin()
        {
            return View();
        }

        public IActionResult Exit()
        {
            if (Request.Cookies.Count != 0)
            {
                foreach (var cookieKey in Request.Cookies.Keys)
                {
                    if (cookieKey == Hasher.clogin)
                    {
                        Response.Cookies.Delete(Hasher.clogin);
                        Response.Cookies.Delete(Hasher.cpass);
                    }
                }
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Signin(SigninModel newUser)
        {
            if (ModelState.IsValid)
            {
                var res = await context.users.FirstOrDefaultAsync(us => (us.Email == newUser.Email ||
                                                                    us.Login == newUser.UserLogin));
                if (res == null)
                {
                    UserModel userModel = new UserModel()
                    {
                        Login = newUser.UserLogin,
                        Password = newUser.UserPassword,
                        Email = newUser.Email
                    };

                    UserInfo userInfo = new UserInfo()
                    {
                        User = new UserModel()
                        {
                            Login = userModel.Login,
                            Password = userModel.Password,
                            Email = userModel.Email
                        },
                        Callbacks = null
                    };

                    context.users.Add(userModel);
                    await context.SaveChangesAsync();

                    return View("UserPage", userInfo);
                }
                else
                {
                    ViewBag.Msg = "User is already exists!";
                }
            }
            else
            {
                ViewBag.Msg = "Bad input data!";
            }
            return View();
        }
    }
}