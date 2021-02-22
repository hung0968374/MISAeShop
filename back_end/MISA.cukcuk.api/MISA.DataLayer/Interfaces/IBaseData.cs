using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.DataLayer.Interfaces
{
    public interface IBaseData<MISAEntity>
    {
        public IEnumerable<MISAEntity> GetAll();
        public int InsertObject(object entity);
        public int PutObject(object entity, string objectId);
        public int Delete(object entity, string code);
        public int DeleteEShopCode(object entity, string code);
        public IEnumerable<MISAEntity> GetByFilteringShopCode(string code);
        public IEnumerable<MISAEntity> GetByFilteringShopName(string code);
        public IEnumerable<MISAEntity> GetByFilteringShopAddress(string code);
        public IEnumerable<MISAEntity> GetByFilteringShopPhoneNumber(string code);
        public IEnumerable<MISAEntity> GetByFilteringShopStt(string code);
    }
}
