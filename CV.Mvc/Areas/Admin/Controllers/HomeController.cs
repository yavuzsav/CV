using System;
using AutoMapper;
using CV.Business.Interfaces;
using CV.DTO.DTOs.AppUserDtos;
using CV.Mvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CV.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    // [Authorize]
    public class HomeController : Controller
    {
        private readonly IAppUserService _userService;
        private readonly IMapper _mapper;

        public HomeController(IAppUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            // var userName = User.Identity?.Name ?? throw new UnauthorizedAccessException("User not logged in");
            var userName = "";
            var user = _userService.FindByUserName(userName);
            if (user == null)
            {
                return RedirectToAction("Login", "Auth", new {area = "Admin"});
            }
            var mappedData = _mapper.Map<AppUserForListDto, AppUserUpdateModel>(user);
            return View(mappedData);
        }
    }
}