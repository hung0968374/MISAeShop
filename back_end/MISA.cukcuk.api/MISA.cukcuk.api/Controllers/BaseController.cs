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
        /// <summary>
        /// Hàm lấy dữ liệu
        /// </summary>
        /// <returns>trả về list danh sách</returns>
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
        /// <summary>
        /// Hàm lấy dữ liệu theo code
        /// </summary>
        /// <param name="sortByShopCode">mã cần lấy về</param>
        /// <returns></returns>
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
        /// <summary>
        /// Hàm lấy dữ liệu theo tên
        /// </summary>
        /// <param name="sortByShopName">tên cần lấy</param>
        /// <returns></returns>
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
        /// <summary>
        /// Hàm lấy dữ liệu theo địa chỉ
        /// </summary>
        /// <param name="filterString">địa chỉ cần lấy</param>
        /// <returns></returns>
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
        /// <summary>
        /// Hàm lấy dữ liệu theo trạng thái object
        /// </summary>
        /// <param name="filterString">trạng thái cần lấy</param>
        /// <returns></returns>
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
        /// <summary>
        /// Hàm lấy dữ liệu theo sdt
        /// </summary>
        /// <param name="filterString">sdt cần lấy</param>
        /// <returns></returns>
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
        /// <summary>
        /// Hàm thêm dữ liệu
        /// </summary>
        /// <param name="entity">object cần truyền vào để thêm dữ liệu</param>
        /// <returns></returns>
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
        /// <summary>
        /// Hàm sửa dữ liệu
        /// </summary>
        /// <param name="entity">tên object cần sửa</param>
        /// <param name="eShopCode">mã của object cần sửa</param>
        /// <returns></returns>
        [HttpPut("{eShopCode}")]
        public IActionResult Put(MISAEntity entity, Guid eShopCode)
        {
            var res = _baseService.Put(entity, eShopCode.ToString());
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
        /// <summary>
        /// Hàm xóa dữ liệu
        /// </summary>
        /// <param name="entity">tên object cần xóa</param>
        /// <param name="eShopId">id của object cần xóa</param>
        /// <returns></returns>
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
