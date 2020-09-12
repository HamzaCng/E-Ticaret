using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mersus.Core.Interfaces;
using Mersus.Entities.Enums;
using Mersus.Entities.Models;
using Mersus.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Mersus.WebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        IUserRepo _userRepository;

        public UserController(ILogger<UserController> logger, IUserRepo userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        [HttpPost]
        public IActionResult AddUser(UserViewModel model)
        {
         
            var user = new User();

            user.CreatedDate = DateTime.Now;
            user.Email = model.Email;
            user.Address = model.Address;
            user.Password = model.Password;
            user.Username = model.Username;
            user.UserStatus = Status.Active;

            _userRepository.Add(user);

            return View(model);
        }

        [HttpPost]
        public IActionResult EditeUser(UserViewModel model)
        {
            var userDetail = _userRepository.GetSingle(model.Id);
            if (userDetail != null)
            {
                userDetail.Id = model.Id;
                userDetail.Username = model.Username;             
                userDetail.Email = model.Email;
                userDetail.Password = model.Password;
                userDetail.UserStatus = Status.Active;
                userDetail.UpdatedDate = DateTime.Now;                
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var viewModel = new UserViewModel();
            var userDetail = _userRepository.GetSingle(id);

            if (userDetail != null)
            {
                viewModel.Id = id;
                viewModel.Username = userDetail.Username;
                viewModel.Password = userDetail.Password;
                viewModel.Email = userDetail.Email;
                viewModel.UserStatus = userDetail.UserStatus;
                viewModel.UpdatedDate = userDetail.UpdatedDate;
                viewModel.CreatedDate = userDetail.CreatedDate;

            }

            return View(viewModel);
        }


        public IActionResult DeleteUser(int id)
        {
            //Soft Delete
            var user = _userRepository.GetSingle(id);
            user.UserStatus = Status.Deleted;

            return RedirectToAction("Home","Index");
        }
    }
}
