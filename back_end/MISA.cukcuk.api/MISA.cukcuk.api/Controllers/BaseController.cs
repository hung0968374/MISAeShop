using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Common.Model;
using MISA.Service;
using MISA.Service.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.cukcuk.api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseController<MISAEntity> : ControllerBase
    {
        IBaseService<MISAEntity> _baseService;
        public BaseController(IBaseService<MISAEntity> baseService)
        {
            _baseService = baseService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var serviceResult = _baseService.GetData();
            var entities = serviceResult.Data as List<MISAEntity>;
            if (entities.Count == 0)
            {
                return StatusCode(204, serviceResult.Data);
            }
            else
            {
                return StatusCode(200, serviceResult.Data);
            }
        }
        [HttpGet("filterByCode")]
        public IActionResult GetByFilteringShopCode([FromQuery] string sortByShopCode)
        {
            var serviceResult = _baseService.GetByFilteringShopCode(sortByShopCode);
            var entities = serviceResult.Data as List<MISAEntity>;
            if (entities.Count == 0)
            {
                return StatusCode(204, serviceResult.Data);
            }
            else
            {
                return StatusCode(200, serviceResult.Data);
            }
        }
        [HttpGet("filterByName")]
        public IActionResult GetByShopName([FromQuery] string sortByShopName)
        {
            var serviceResult = _baseService.GetByFilteringShopName(sortByShopName);
            var entities = serviceResult.Data as List<MISAEntity>;
            if (entities.Count == 0)
            {
                return StatusCode(204, serviceResult.Data);
            }
            else
            {
                return StatusCode(200, serviceResult.Data);
            }
        }
        [HttpGet("filterByAddress")]
        public IActionResult GetByShopAddress([FromQuery] string filterString)
        {
            var serviceResult = _baseService.GetByFilteringShopAddress(filterString);
            var entities = serviceResult.Data as List<MISAEntity>;
            if (entities.Count == 0)
            {
                return StatusCode(204, serviceResult.Data);
            }
            else
            {
                return StatusCode(200, serviceResult.Data);
            }
        }
        [HttpGet("filterByShopStatus")]
        public IActionResult GetByShopStatus([FromQuery] string filterString)
        {
            var serviceResult = _baseService.GetByFilteringShopStt(filterString);
            var entities = serviceResult.Data as List<MISAEntity>;
            if (entities.Count == 0)
            {
                return StatusCode(204, serviceResult.Data);
            }
            else
            {
                return StatusCode(200, serviceResult.Data);
            }
        }
        [HttpGet("filterByPhoneNumber")]
        public IActionResult GetByShopPhoneNumber([FromQuery] string filterString)
        {
            var serviceResult = _baseService.GetByFilteringShopPhoneNumber(filterString);
            var entities = serviceResult.Data as List<MISAEntity>;
            if (entities.Count == 0)
            {
                return StatusCode(204, serviceResult.Data);
            }
            else
            {
                return StatusCode(200, serviceResult.Data);
            }
        }
        [HttpPost]
        public IActionResult Post(MISAEntity entity)
        {
            var res = _baseService.Insert(entity);
            if (res.Success == false)
            {
                return StatusCode(200, res.Data);
            }
            else if (res.Success == true && (int)res.Data > 0)
            {
                return StatusCode(201, res);
            }
            else
            {
                return StatusCode(200, res);
            }
        }
        [HttpPut("{eShopCode}")]
        public IActionResult Put(MISAEntity entity, Guid eShopCode)
        {
            var res = _baseService.Put(entity, eShopCode.ToString());
            if (res.Success == false)
            {
                return StatusCode(400, res.Data);
            }
            else if (res.Success == true && (int)res.Data > 0)
            {
                return StatusCode(201, res);
            }
            else
            {
                return StatusCode(200, res);
            }
        }

        //var res = _baseService.Delete(entity, code);
        //return Ok(res);


        [HttpDelete("{eShopId}")]
        public IActionResult Delete(MISAEntity entity,  Guid eShopId)
        {
            var res = _baseService.Delete(entity, eShopId.ToString());
            return Ok(res);
        }
        [HttpDelete("delete/{eShopCode}")]
        public IActionResult DeleteShopCode(MISAEntity entity, string eShopCode)
        {
            var res = _baseService.DeleteEShopCode(entity, eShopCode);
            return Ok(res);
        }
    }
}
