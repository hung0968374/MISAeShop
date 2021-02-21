using MISA.Common.Model;
using MISA.Service;
using MISA.Service.Interfaces;

namespace MISA.cukcuk.api.Controllers
{
    public class EShopsController : BaseController<EShop>
    {
        public EShopsController(IEShopService eShopService) : base(eShopService) { 

        }
    }
}
