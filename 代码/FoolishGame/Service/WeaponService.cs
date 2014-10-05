using System.Collections.Generic;
using Model;

namespace Service
{
    public static class WeaponService
    {
        #region 角色武器初始化方法
        public static Charactor UpdateWeapon(Charactor charactor) {
            return PropertyService.UpdateProperty(charactor, charactor.Weapon, NumericalType.数值);
        }

        public static List<Charactor> UpdateWeapon(List<Charactor> charactorList) {
            var result = new List<Charactor>();
            foreach (var item in charactorList) {
                result.Add(UpdateWeapon(item));
            }
            return result;
        }
        #endregion
    }
}
