using Eternity1._0.Models;
using Eternity1._0.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eternity1._0.Controllers
{

    [Route("ananda/eternity/[controller]")]
    [ApiController]
    public class ItemController : Controller
    {
        string sessionId;
        LoginService service = new LoginService();

        [HttpGet]
        public IActionResult findItemByItemCodeTales(string itemCode)
        {
            var cliente = new RestClient("https://199.89.53.35:50000/b1s/v1/Items" + "('" + itemCode + "')");
            cliente.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Cookie", "B1SESSION=" + service.LoginSAP());
            var body = @"";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = cliente.Execute(request);
            var resultado = JsonConvert.DeserializeObject<ItemTales>(response.Content, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            ItemTales itemDevuelto = new ItemTales(resultado.BarCode, resultado.ItemCode, resultado.ItemName, resultado.ItemsGroupCode, resultado.ItemWarehouseInfoCollection, resultado.SalesUnitWeight, resultado.U_codigo, resultado.QuantityOnStock);
            if (itemDevuelto.ItemCode != null)
            {
                return StatusCode(StatusCodes.Status200OK, itemDevuelto);
            }
            else
            {
                itemDevuelto.ItemCode = "0";
                itemDevuelto.ItemName = "Nulo";
                return StatusCode(StatusCodes.Status200OK, itemDevuelto);
            }


        }
    }
}
