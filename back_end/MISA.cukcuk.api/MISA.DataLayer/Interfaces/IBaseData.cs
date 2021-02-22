using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.DataLayer.Interfaces
{
    public interface IBaseData<MISAEntity>
    {
        public IEnumerable<MISAEntity> GetAll();
        public int InsertObject(object entity);
        public int Delete(object entity, string code);
        public IEnumerable<MISAEntity> GetByFilteringShopCode(string code);
    }
}
