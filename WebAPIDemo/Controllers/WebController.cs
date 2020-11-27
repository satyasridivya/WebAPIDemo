 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebAPIDemo.DAL;
using WebAPIDemo.Models;
using System.Web.Mvc.Routing;


//// Interface with abstract method
public interface IMasterData
{
IEnumerable<Weather> WeatherType();

}

////Container Class
public class MasterData : IMasterData
{
    private Repository repository;
  
    public MasterData(Repository repository)
    {
        this.repository = repository;
    }

    public IEnumerable<Weather> WeatherType()
    {
        IEnumerable<Weather> masterList =
        this.repository.WeatherType();
        return masterList;
    }

/////API used Async and await calls-------------------------
 /// <summary>
 /// Fetch Weather Type Values
 /// </summary>
 /// <returns>returns Action Result of Facility Type Data</returns>
 //// [Route("api/pollution/v1/co/{0},{1}/{2}Z.json?appid={3}", Name = "openweathermap")]
    [System.Web.Http.HttpGet]
    public async Task<IHttpActionResult> Weathertypo()
    {
        IEnumerable<Weather> masterresult = null;
        IMasterData service = new MasterData(new Repository());
        ////masterresult = service.QueryMarketValue();
        await Task.Run(() => { masterresult = service.WeatherType(); });
        return this.Ok(masterresult);
    }

    private IHttpActionResult Ok(IEnumerable<Weather> masterresult)
    {
        throw new NotImplementedException();
    }
}

