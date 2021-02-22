using MISA.Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Service.Interfaces
{
    public interface IBaseService<MISAEntity>
    {
        ServiceResult GetData();
        ServiceResult Insert(MISAEntity entity);
        ServiceResult Put(MISAEntity entity, string objectId);
        ServiceResult Delete(MISAEntity entity, string Code);
        ServiceResult DeleteEShopCode(MISAEntity entity, string Code);
        ServiceResult GetByFilteringShopCode(string filterString);
        ServiceResult GetByFilteringShopName(string filterString);
        ServiceResult GetByFilteringShopAddress(string filterString);
        ServiceResult GetByFilteringShopPhoneNumber(string filterString);
        ServiceResult GetByFilteringShopStt(string filterString);
    }
}
