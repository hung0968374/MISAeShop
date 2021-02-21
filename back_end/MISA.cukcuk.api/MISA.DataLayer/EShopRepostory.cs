using Dapper;
using MISA.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISA.DataLayer
{
    public class EShopRepostory : DbContext<EShop>
    {
        /// <summary>
        /// Kiểm tra mã cửa hàng đã tồn tại hay chưa
        /// </summary>
        /// <param name="shopCode">mã cần kiểm tra</param>
        /// <returns>true: mã đã tồn tại, false: chưa tồn tại</returns>
        public bool checkShopCodeExists(string shopCode)
        {
            var sql = $"SELECT eShopCode From EShop AS e where e.eShopCode = '{shopCode}'";
            var shopCodeExists = _dbConnection.Query<string>(sql).FirstOrDefault();
            if (shopCodeExists != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Kiểm tra số điện thoại của khách hàng xem đã tồn tại hay chưa
        /// </summary>
        /// <param name="customerCode">Số cần kiểm tra</param>
        /// <returns>true: đã tồn tại, false: chưa tồn tại</returns>
        public bool checkShopPhoneNumberExists(string phoneNumber)
        {
            var sqlSelectPhoneNumber = $"SELECT eShopPhoneNumber From EShop AS E where E.eShopPhoneNumber = '{phoneNumber}'";
            var phoneNumberExists = _dbConnection.Query<string>(sqlSelectPhoneNumber).FirstOrDefault();
            if (phoneNumberExists != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
