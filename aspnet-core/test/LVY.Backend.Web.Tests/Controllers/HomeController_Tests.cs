﻿using LVY.Backend.Models.TokenAuth;
using LVY.Backend.Web.Controllers;
using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace LVY.Backend.Web.Tests.Controllers;

public class HomeController_Tests : BackendWebTestBase
{
    [Fact]
    public async Task Index_Test()
    {
        await AuthenticateAsync(null, new AuthenticateModel
        {
            UserNameOrEmailAddress = "admin",
            Password = "123qwe"
        });

        //Act
        var response = await GetResponseAsStringAsync(
            GetUrl<HomeController>(nameof(HomeController.Index))
        );

        //Assert
        response.ShouldNotBeNullOrEmpty();
    }
}