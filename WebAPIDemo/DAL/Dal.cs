using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIDemo.Models;

namespace WebAPIDemo.DAL
{
    public class Repository
    {
        /// <summary>
        /// Fetches the Weather Type Values
        /// </summary>
        /// <returns>List of Weather Values</returns>
        public IEnumerable<Weather> WeatherType()
        {
            List<Weather> masterList = new List<Weather>();
            masterList.Add(new Weather
            {
                ID = 1,
                Type = "ParsedLatitude",
               
            });
            masterList.Add(new Weather
            {
                ID = 2,
                Type = "parsedLongitude",
                
            });
         masterList.Add(new Weather
            {
                ID = 3,
                Type = "validDateTime",
                
            });
            return masterList;
        }
    }
}
