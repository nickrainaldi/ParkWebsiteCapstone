using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Web.DAL;
using Moq;
using Capstone.Web.Controllers;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Capstone.Web.Tests.Controllers
{
    [TestClass]
    public class WeatherControllerTests
    {
        [TestMethod]
        public void WeatherAction_returns_WeatherView()
        {
            {
                Mock<IWeatherDAL> mockDAL = new Mock<IWeatherDAL>();
                Models.Weather w = new Models.Weather();
                w.ParkName = "CVNP";
                List<Models.Weather> fakeList = new List<Models.Weather>();

                fakeList.Add(w);
                mockDAL.Setup(m => m.Get5DaysOfWeather("CVNP")).Returns(fakeList);

                WeatherController c = new WeatherController(mockDAL.Object);

                var result = c.Weather("CVNP");

                Assert.IsTrue(result is ViewResult);
                var view = result as ViewResult;
                Assert.AreEqual("Weather", view.ViewName);
                Assert.IsNotNull(view.Model);
            }
        }
    }
}
