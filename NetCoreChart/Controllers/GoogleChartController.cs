using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// Tutorial: https://www.c-sharpcorner.com/article/creating-charts-with-asp-net-core-mvc-using-google-chart-api-part-two/

namespace NetCoreChart.Controllers
{
    public class GoogleChartController : Controller
    {
        public class PopulationModel
        {
            public string CityName { get; set; }
            public int PopulationYear2020 { get; set; }
            public int PopulationYear2010 { get; set; }
            public int PopulationYear2000 { get; set; }
        }

        private List<PopulationModel> GetCityPopulationList()
        {
            var list = new List<PopulationModel>();
            list.Add(new PopulationModel { CityName = "PURI", PopulationYear2020 = 28000, PopulationYear2010 = 45000, PopulationYear2000 = 30000});
            list.Add(new PopulationModel { CityName = "Bhubaneswar", PopulationYear2020 = 30000, PopulationYear2010 = 49000, PopulationYear2000 = 40000 });
            list.Add(new PopulationModel { CityName = "Cuttack", PopulationYear2020 = 35000, PopulationYear2010 = 56000, PopulationYear2000 = 25000 });
            list.Add(new PopulationModel { CityName = "Berhampur", PopulationYear2020 = 37000, PopulationYear2010 = 44000, PopulationYear2000 = 42000 });
            list.Add(new PopulationModel { CityName = "Odisha", PopulationYear2020 = 40000, PopulationYear2010 = 38000, PopulationYear2000 = 41000 });

            return list;
        }

        public ActionResult ColumnChart() => View();

        [HttpGet]
        public JsonResult PopulationData()
        {
            var populationList = GetCityPopulationList();
            return Json(populationList);
        }
    }
}
