using MISA.Common.Model;
using MISA.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Service
{
    public class EShopService : BaseService<EShop>
    {
        public EShopService(IBaseData<EShop> DbContext) : base(DbContext)
        {

        }
    }
}
