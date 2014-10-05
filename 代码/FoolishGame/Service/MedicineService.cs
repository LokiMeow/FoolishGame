using System.Collections.Generic;
using Model;

namespace Service
{
    public static class MedicineService
    {
        #region 角色药剂初始化方法
        public static Charactor UpdateMedicine(Charactor charactor) {
            foreach (var item in charactor.MedicineList) {
                charactor = PropertyService.UpdateProperty(charactor, item, item.NumericalType);
            }
            return charactor;
        }

        public static List<Charactor> UpdateMedicine(List<Charactor> charactorList) {
            var result = new List<Charactor>();
            foreach (var item in charactorList) {
                result.Add(UpdateMedicine(item));
            }
            return result;
        }
        #endregion
    }
}
