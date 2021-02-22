using MISA.Common.Model;
using MISA.DataLayer;
using MISA.DataLayer.Interfaces;
using MISA.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Service
{
    public class EShopService : BaseService<EShop>, IEShopService
    {
        public EShopService(IBaseData<EShop> DbContext) : base(DbContext)
        {

        }
        protected override bool ValidateData(EShop eShop, ErrorMsg errorMsg )
        {
            var dbContext = new EShopRepostory();
            var isValid = true;
            // validate ma cua hang
            if (eShop.eShopCode == null || eShop.eShopCode == string.Empty)
            {
                errorMsg.UserMsg.Add(MISA.Common.Properties.Resources.ErrorService_EmptyEShopCode);
                isValid = false;
            }
            if (eShop.eShopPhoneNumber == null || eShop.eShopPhoneNumber == string.Empty)
            {
                errorMsg.UserMsg.Add(MISA.Common.Properties.Resources.ErrorService_EmptyEShopPhone);
                isValid = false;
            }
            var shopCodeExisted = dbContext.checkShopCodeExists(eShop.eShopCode);
            if (shopCodeExisted == true)
            {
                errorMsg.UserMsg.Add(MISA.Common.Properties.Resources.ErrorService_DuplicateEShopCode);
                isValid = false;
            }
            //validate sdt
            var phoneExisted = dbContext.checkShopPhoneNumberExists(eShop.eShopPhoneNumber);
            if (phoneExisted == true)
            {
                errorMsg.UserMsg.Add(MISA.Common.Properties.Resources.ErrorService_DuplicateEShopPhone);
                isValid = false;
            }
            return isValid;
        }
        protected override bool ValidateDataForPutMethod(EShop eShop, ErrorMsg errorMsg = null, string objectId = null)
        {
            var dbContext = new EShopRepostory();
            var isValid = true;
            // validate ma cua hang
            if (eShop.eShopCode == null || eShop.eShopCode == string.Empty)
            {
                errorMsg.UserMsg.Add(MISA.Common.Properties.Resources.ErrorService_EmptyEShopCode);
                isValid = false;
            }
            if (eShop.eShopPhoneNumber == null || eShop.eShopPhoneNumber == string.Empty)
            {
                errorMsg.UserMsg.Add(MISA.Common.Properties.Resources.ErrorService_EmptyEShopPhone);
                isValid = false;
            }
            /// validate trung ma code cua hang
            var shopCodeExisted = dbContext.checkShopCodeExistedOrNot(eShop.eShopCode, objectId);
            if (shopCodeExisted == true)
            {
                errorMsg.UserMsg.Add(MISA.Common.Properties.Resources.ErrorService_DuplicateEShopCode);
                isValid = false;
            }
            //validate trung sdt
            var phoneExisted = dbContext.checkShopPhoneExistedOrNot(eShop.eShopPhoneNumber, objectId);
            if (phoneExisted == true)
            {
                errorMsg.UserMsg.Add(MISA.Common.Properties.Resources.ErrorService_DuplicateEShopPhone);
                isValid = false;
            }
            return isValid;
        }
    }
}
