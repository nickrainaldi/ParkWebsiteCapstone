using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Web.DAL;
using System.Transactions;

namespace Capstone.Web.Tests.DAL
{
    [TestClass]
    public class ParkSqlDALTest
    {
        private TransactionScope tran;
        private string connectionString = @"Data Source=.\SQLExpress;Initial Catalog=NationalParkService;User ID=te_student;Password=techelevator";

        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();
        }
        [TestMethod]
        public void TestGetAllParksMethod()
        {
            //         [TestMethod()]
            //    public void GetContinentNamesTest()
            //    {
            //        ParksSqlDAL countrySqlDal = new ParksSqlDAL(connectionString);
            //        List<string> names = countrySqlDal.GetContinentNames();

            //        Assert.IsNotNull(names);
            //        Assert.AreEqual(7, names.Count);
            //    }
            //}
            //}
        }
    }
}
