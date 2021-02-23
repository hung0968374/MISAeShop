using MISA.Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Service.Interfaces
{
    public interface IBaseService<MISAEntity>
    {
        /// <summary>
        /// Lấy tất cả dữ liệu
        /// </summary>
        /// <returns></returns>
        ServiceResult GetData();
        /// <summary>
        /// thêm mới bản ghi
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ServiceResult Insert(MISAEntity entity);
        /// <summary>
        /// Sửa bản ghi
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="objectId"></param>
        /// <returns></returns>
        ServiceResult Put(MISAEntity entity, string objectId);
        /// <summary>
        /// Xóa bản ghi theo Guid id
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="Code"></param>
        /// <returns></returns>
        ServiceResult Delete(MISAEntity entity, string Code);
        /// <summary>
        /// xóa bản ghi theo mã code
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="Code"></param>
        /// <returns></returns>
        ServiceResult DeleteEShopCode(MISAEntity entity, string Code);
        /// <summary>
        /// lọc dữ liệu theo mã thực thể, ví dụ mã của shop: eShop4665
        /// </summary>
        /// <param name="filterString"></param>
        /// <returns></returns>
        ServiceResult GetByFilteringShopCode(string filterString);
        /// <summary>
        /// Lọc dữ liệu theo tên
        /// </summary>
        /// <param name="filterString"></param>
        /// <returns></returns>
        ServiceResult GetByFilteringShopName(string filterString);
        /// <summary>
        /// Lọc dữ liệu theo địa chỉ
        /// </summary>
        /// <param name="filterString"></param>
        /// <returns></returns>
        ServiceResult GetByFilteringShopAddress(string filterString);
        /// <summary>
        /// Lọc dữ liệu theo số điện thoại
        /// </summary>
        /// <param name="filterString"></param>
        /// <returns></returns>
        ServiceResult GetByFilteringShopPhoneNumber(string filterString);
        /// <summary>
        /// Lọc dữ liệu theo trạng thái của thực thể: ví dụ đã đóng cửa, đang hoạt động
        /// </summary>
        /// <param name="filterString"></param>
        /// <returns></returns>
        ServiceResult GetByFilteringShopStt(string filterString);
    }
}
