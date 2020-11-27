using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.DAL;
using WebAPIDemo.Models;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test Method for Weather Type
        /// </summary>
        [TestMethod]
        public void Weather()
        {
            IEnumerable<Weather> masterList = null;
            IMasterData service = new MasterData(new Repository());
            ////await Task.Run(() => { masterresult = service.WeatherType(); });
            Assert.IsNotNull(masterList, "Invalid Weather Value");
            Assert.IsTrue(masterList.Count() > 0, "Invalid Weather Value");
        }
    }
}