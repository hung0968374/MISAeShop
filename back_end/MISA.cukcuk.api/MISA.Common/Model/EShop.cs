using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Model
{
    public class EShop
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid eShopId { get; set; }
        /// <summary>
        /// Mã shop
        /// </summary>
        public string eShopCode { get; set; }
        /// <summary>
        /// Tên shop
        /// </summary>
        public string eShopName { get; set; }
        /// <summary>
        /// số điện thoại của shop
        /// </summary>
        public string eShopPhoneNumber { get; set; }
        /// <summary>
        /// mã số thuế của shop
        /// </summary>
        public string eShopTaxCode { get; set; }
        /// <summary>
        /// quốc gia mà shop ở
        /// </summary>
        public string eShopNationality { get; set; }
        /// <summary>
        /// Thánh phố, tình shop thuộc về
        /// </summary>
        public string eShopProvince { get; set; }
        /// <summary>
        /// quận/huyện shop thuộc về
        /// </summary>
        public string eShopDistrict { get; set; }
        /// <summary>
        /// Làng, xóm
        /// </summary>
        public string eShopVillage { get; set; }
        /// <summary>
        /// tên đường
        /// </summary>
        public string eShopRoad { get; set; }
        /// <summary>
        /// địa chỉ chính xác của shop
        /// </summary>
        public string eShopAddress { get; set; }
        /// <summary>
        /// trạng thái của shop hiện tại, vd: đang hoạt động
        /// </summary>
        public string eShopStatus { get; set; }
    }
}
