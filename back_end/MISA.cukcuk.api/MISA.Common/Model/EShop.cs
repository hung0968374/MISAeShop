using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Model
{
    public class EShop
    {
        public Guid eShopId { get; set; }
        public string eShopCode { get; set; }
        public string eShopName { get; set; }
        public string eShopPhoneNumber { get; set; }
        public string eShopTaxCode { get; set; }
        public string eShopNationality { get; set; }
        public string eShopProvince { get; set; }
        public string eShopDistrict { get; set; }
        public string eShopVillage { get; set; }
        public string eShopRoad { get; set; }
        public string eShopAddress { get; set; }
        public string eShopStatus { get; set; }
    }
}
