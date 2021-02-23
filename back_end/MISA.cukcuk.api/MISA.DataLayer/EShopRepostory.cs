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
        /// <summary>
        /// check xem shopCOde đã tồn tại chưa
        /// </summary>
        /// <param name="shopCode">mã cần kiểm tra</param>
        /// <param name="id">id này để so sánh id tìm được theo shopcode với chính nó, nếu 2 id bằng nhau thì không trùng, ngược lại sẽ trả 
        /// lại kết quả trùng mã</param>
        /// <returns></returns>
        public bool checkShopCodeExistedOrNot(string shopCode, string id)
        {
            var sqlSelectShopCode = $"SELECT eShopId From EShop AS E where E.eShopCode = '{shopCode}'";
            Guid shopId = _dbConnection.Query<Guid>(sqlSelectShopCode).FirstOrDefault();
            if (shopId.ToString() == id || shopId == Guid.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// check sdt xem có trùng hay không
        /// </summary>
        /// <param name="shopPhone">sdt cần kiểm tra</param>
        /// <param name="id">id này để so sánh id tìm được theo shopcode với chính nó, nếu 2 id bằng nhau thì không trùng, ngược lại sẽ trả 
        /// lại kết quả trùng sdt</param>
        /// <returns></returns>
        public bool checkShopPhoneExistedOrNot(string shopPhone, string id)
        {
            var sqlSelectShopPhone = $"SELECT eShopId From EShop AS E where E.eShopPhoneNumber = '{shopPhone}'";
            Guid shopId = _dbConnection.Query<Guid>(sqlSelectShopPhone).FirstOrDefault();
            if (shopId.ToString() == id || shopId == Guid.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
