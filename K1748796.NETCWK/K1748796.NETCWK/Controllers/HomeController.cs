

using K1748796.NETCWK.Models;
using K1748796.NETCWK.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K1748796.NETCWK.Controllers
{
    public class HomeController : Controller 
    {
        private readonly IUserRepository _userRepository;

        public HomeController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
           
        }
        public ViewResult Index()
        {

            return View();
        }
        public ViewResult List()
        {
           var model= _userRepository.GetAllUsers();
            return View(model);
        }
        public ViewResult About()
        {
            
            return View();
        }

        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                User = _userRepository.GetUser(id ?? 1),
                PageTitle = "User Details"
            };
            return View(homeDetailsViewModel); 
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            User user = _userRepository.GetUser(id);
            UserEditViewModel userEditViewModel = new UserEditViewModel
            {
                id = user.id,
                Name = user.Name,
                Address = user.Address,
                Postcode = user.Postcode,
                Email = user.Email,
                Phone = user.Phone,
                Gender = user.Gender,
                Biography = user.Biography,
                Skills = user.Skills,
                Sport = user.Sport

            };
            return View(userEditViewModel);
        }
        [HttpPost]
        public IActionResult Edit(UserEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = _userRepository.GetUser(model.id);
                user.Name = model.Name;
                user.Address = model.Address;
                user.Postcode = model.Postcode;
                user.Email = model.Email;
                user.Gender = model.Gender;
                user.Biography = model.Biography;
                user.Phone = model.Phone;
                user.Skills = model.Skills;
                user.Sport = model.Sport;
                _userRepository.Update(user);
                return RedirectToAction("list");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                User newUser = _userRepository.Add(user);
                return RedirectToAction("details", new { id = newUser.id });
            }
            return View();
        }

    }
}
