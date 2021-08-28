using AutoMapper;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Service.Interfaces;
using InventoryManagement.Web.Controllers;
using InventoryManagement.Web.Models;
using InventoryMangement.Web.UnitTest.AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMangement.Web.UnitTest
{
    public class LoginControllerUnitTests
    {
        private IUserService _userService;
        private IMapper _mapper;

        [SetUp]
        public void Setup()
        {
            var _userServiceMoq = new Mock<IUserService>();
            _userService = _userServiceMoq.Object;

            var users = new List<User>()
            {
                new User{ Id = 1, Active = true, UserName = "Admin", Password = "123" , Name ="Administrator"},
                new User{ Id = 2, Active = false, UserName = "prathap", Password = "123" , Name ="Prathap"},
                new User{ Id = 3, Active = true, UserName = "saman", Password = "123" , Name ="Saman"},
                null
            };

            users[0].Role = new UserRole() { Id = 1, IsSuperUser = true, Name = "Adminstrator", Privileges = new List<RolePrivilege>() };

            _userServiceMoq.Setup(x => x.GetByUserName("Admin")).Returns(users[0]);
            _userServiceMoq.Setup(x => x.GetByUserName("prathap")).Returns(users[1]);
            _userServiceMoq.Setup(x => x.GetByUserName("nayomi")).Returns(users[3]);

            _userServiceMoq.Setup(x => x.GetByUserNameAndPassword("Admin", "123")).Returns(users[0]);
            _userServiceMoq.Setup(x => x.GetByUserNameAndPassword("prathap", "123")).Returns(users[1]);

            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new UserMappingProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
        }

        [Test]
        public void Login_IsNonExistingUser_ReturnsErrorResponseMessage()
        {
            //Arrange
            var loginViewModel = new LoginViewModel() { UserName = "nayomi", Password = "123" };

            var loginController = new LoginController(_userService, _mapper);

            //Act
            var res = loginController.Login(loginViewModel) as ViewResult;
            var resModel = res.Model as LoginViewModel;

            //Assert
            Assert.AreEqual("Index", res.ViewName);
            Assert.AreNotEqual(null, resModel.ErrorMessage);
            Assert.AreEqual("Invalid user name", resModel.ErrorMessage);

        }

        [Test]
        public void Login_IsInActiveUser_ReturnsErrorResponseMessage()
        {
            //Arrange
            var loginViewModel = new LoginViewModel() { UserName = "prathap", Password = "123" };

            var loginController = new LoginController(_userService, _mapper);

            //Act
            var res = loginController.Login(loginViewModel) as ViewResult;
            var resModel = res.Model as LoginViewModel;

            //Assert
            Assert.AreEqual("Index", res.ViewName);
            Assert.AreNotEqual(null, resModel.ErrorMessage);
            Assert.AreEqual("User not activated. Please contact the administrator", resModel.ErrorMessage);

        }

        [Test]
        public void Login_IsPasswordInvalidUser_ReturnsErrorResponseMessage()
        {
            //Arrange
            var loginViewModel = new LoginViewModel() { UserName = "prathap", Password = "12345" };

            var loginController = new LoginController(_userService, _mapper);

            //Act
            var res = loginController.Login(loginViewModel) as ViewResult;
            var resModel = res.Model as LoginViewModel;

            //Assert
            Assert.AreEqual("Index", res.ViewName);
            Assert.AreNotEqual(null, resModel.ErrorMessage);
            Assert.AreEqual("Invalid password", resModel.ErrorMessage);

        }

        [Test]
        public void Login_IsValidUser_ReturnsRedirectToActionReasponse()
        {
            //Arrange
            var loginViewModel = new LoginViewModel() { UserName = "Admin", Password = "123" };

            var loginController = new LoginController(_userService, _mapper);

            //Act
            var res = loginController.Login(loginViewModel) as ViewResult;
            var resModel = res.Model as LoginViewModel;

            //Assert
            Assert.AreEqual("Index", res.ViewName);

        }
    }
}
