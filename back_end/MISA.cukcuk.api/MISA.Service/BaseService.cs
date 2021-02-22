using MISA.Common.Model;
using MISA.DataLayer;
using MISA.DataLayer.Interfaces;
using MISA.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Service
{
    public class BaseService<MISAEntity>:IBaseService<MISAEntity>
    {
        protected IBaseData<MISAEntity> _dbContext;
        /// <summary>
        /// Khởi tạo đường dẫn đến dataLayer
        /// </summary>
        /// <param name="dbContext"></param>
        public BaseService(IBaseData<MISAEntity> dbContext)
        {
            _dbContext = dbContext;
        }
        public virtual ServiceResult GetData()
        {
            var serviceResult = new ServiceResult();
            serviceResult.Data = _dbContext.GetAll();
            return serviceResult;
        }
        public virtual ServiceResult GetByFilteringShopCode(string filterString)
        {
            var serviceResult = new ServiceResult();
            serviceResult.Data = _dbContext.GetByFilteringShopCode(filterString);
            return serviceResult;
        }
        public virtual ServiceResult GetByFilteringShopName(string filterString)
        {
            var serviceResult = new ServiceResult();
            serviceResult.Data = _dbContext.GetByFilteringShopName(filterString);
            return serviceResult;
        }
        public virtual ServiceResult GetByFilteringShopAddress(string filterString)
        {
            var serviceResult = new ServiceResult();
            serviceResult.Data = _dbContext.GetByFilteringShopAddress(filterString);
            return serviceResult;
        }
        public virtual ServiceResult GetByFilteringShopPhoneNumber(string filterString)
        {
            var serviceResult = new ServiceResult();
            serviceResult.Data = _dbContext.GetByFilteringShopPhoneNumber(filterString);
            return serviceResult;
        }
        public virtual ServiceResult GetByFilteringShopStt(string filterString)
        {
            var serviceResult = new ServiceResult();
            serviceResult.Data = _dbContext.GetByFilteringShopStt(filterString);
            return serviceResult;
        }
        public virtual ServiceResult Delete(MISAEntity entity, string code)
        {
            var serviceResult = new ServiceResult();
            serviceResult.Data = _dbContext.Delete(entity, code);
            return serviceResult;
        }
        /// <summary>
        /// THêm mới dữ liệu
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Trả về kết quả ServiceResult</returns>
        public virtual ServiceResult Insert(MISAEntity entity)
        {
            var serviceResult = new ServiceResult();
            var errorMsg = new ErrorMsg(); 
            //Xử lý nghiệp vụ
            var isValid = ValidateData(entity, errorMsg);
            //Gửi lên dataLayer thêm mới vào database
            if (isValid == true)
            {
                var res = _dbContext.InsertObject(entity);
                if (res > 0)
                {
                    serviceResult.Success = true;
                    serviceResult.MISACode = 200;
                    serviceResult.Data = res;
                    return serviceResult;
                }
                else
                {
                    serviceResult.Success = true;
                    serviceResult.MISACode = 200;
                    serviceResult.Data = res;
                    return serviceResult;
                } 
            }
            else
            {
                serviceResult.Success = false;
                errorMsg.MISACode = 400;
                serviceResult.Data = errorMsg;
            }
            return serviceResult;
        }

        public virtual ServiceResult Put(MISAEntity entity, string objectId)
        {
            var serviceResult = new ServiceResult();
            var errorMsg = new ErrorMsg();
            //Xử lý nghiệp vụ
            var isValid = ValidateDataForPutMethod(entity, errorMsg, objectId);
            //Gửi lên dataLayer thêm mới vào database
            if (isValid == true)
            {
                var res = _dbContext.PutObject(entity, objectId);
                if (res > 0)
                {
                    serviceResult.Success = true;
                    serviceResult.MISACode = 200;
                    serviceResult.Data = res;
                    return serviceResult;
                }
                else
                {
                    serviceResult.Success = true;
                    serviceResult.MISACode = 200;
                    serviceResult.Data = res;
                    return serviceResult;
                }
            }
            else
            {
                serviceResult.Success = false;
                errorMsg.MISACode = 400;
                serviceResult.Data = errorMsg;
            }
            return serviceResult;
        }
        /// <summary>
        /// Validate dữ liệu
        /// </summary>
        /// <param name="entity">Đối tượng cần validate</param>
        /// <returns>true: dữ liệu hợp lệ, false: dữ liệu k hợp lệ</returns>
        protected virtual bool ValidateData(MISAEntity entity, ErrorMsg errorMsg = null)
        {
            return true;
        }
        protected virtual bool ValidateDataForPutMethod(MISAEntity entity, ErrorMsg errorMsg = null, string objectId = null)
        {
            return true;
        }
    }
}
