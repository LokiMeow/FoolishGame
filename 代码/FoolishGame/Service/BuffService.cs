using System.Collections.Generic;
using Model;

namespace Service
{
    public static class BuffService
    {
        #region 角色Buff增加与移除方法
        public static Charactor UpdateBuff(Charactor charactor, Buff buff, bool isGood = true) {
            return PropertyService.UpdateProperty(charactor, buff, buff.NumericalType, isGood);
        }

        public static List<Charactor> UpdateBuff(List<Charactor> charactorList, Buff buff, bool isGood = true) {
            var result = new List<Charactor>();
            foreach (var item in charactorList) {
                result.Add(UpdateBuff(item, buff, isGood));
            }
            return result;
        }
        #endregion
    }
}
