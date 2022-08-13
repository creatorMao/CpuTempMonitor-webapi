using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace CpuTempMonitor.Controllers
{
    public class CPUController : ApiController
    { 
        [HttpGet]
        [HttpPost]
        public HttpResponseMessage temp() {
            List<CpuTemp> result= CpuTempMonitor.GetCpuTemps();

            string json = JsonConvert.SerializeObject(new {
                result
            });

            return new HttpResponseMessage() {
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };
        }
    }
}
