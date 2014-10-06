using System;
using Model;

namespace Service
{
    public static class PropertyService
    {
        #region 更新属性方法
        /// <summary>
        /// 将后者的属性增加到前者上
        /// </summary>
        /// <param name="t">T</param>
        /// <param name="t1">T1.</param>
        /// <param name="type">数值增加类型：百分比增加还是按值增加</param>
        /// <param name="isGood">增加还是减少,True为增加,反之为减少.默认为增加</param>
        public static T UpdateProperty<T, T1>(T t, T1 t1, NumericalType type, bool isGood = true)
            where T : BaseProperty
            where T1 : BaseProperty {
            switch (type) {
                case NumericalType.数值:
                    return UpdatePropertyValue(t, t1, isGood);
                case NumericalType.百分比:
                    return UpdatePropertyPercent(t, t1, isGood);
                default:
                    throw new Exception();
            }

        }

        public static T UpdatePropertyValue<T, T1>(T t, T1 t1, bool isGood)
            where T : BaseProperty
            where T1 : BaseProperty {
            if (isGood) {
                t.PhysicalDmg += t1.PhysicalDmg;
                t.PhysicalDef += t1.PhysicalDef;

                t.MagicDmg += t1.MagicDmg;
                t.MagicDef += t1.MagicDef;

                t.HP += t1.HP;
                t.Speed += t1.Speed;

                t.Crit += t1.Crit;
                t.Dodge += t1.Dodge;
            }
            else {
                t.PhysicalDmg -= t1.PhysicalDmg;
                t.PhysicalDef -= t1.PhysicalDef;

                t.MagicDmg -= t1.MagicDmg;
                t.MagicDef -= t1.MagicDef;

                t.HP -= t1.HP;
                t.Speed -= t1.Speed;

                t.Crit -= t1.Crit;
                t.Dodge -= t1.Dodge;
            }
            return t;
        }

        public static T UpdatePropertyPercent<T, T1>(T t, T1 t1, bool isGood)
            where T : BaseProperty
            where T1 : BaseProperty {
            if (isGood) {
                t.PhysicalDmg += t.PhysicalDmg * t1.PhysicalDmg;
                t.PhysicalDef += t.PhysicalDef * t1.PhysicalDef;

                t.MagicDmg += t.MagicDmg * t1.MagicDmg;
                t.MagicDef += t1.MagicDef;

                t.HP += t.HP * t1.HP;
                t.Speed += t.Speed * t1.Speed;

                t.Crit += t.Crit * t1.Crit;
                t.Dodge += t.Dodge * t1.Dodge;
            }
            else {
                t.PhysicalDmg -= t.PhysicalDmg * t1.PhysicalDmg;
                t.PhysicalDef -= t.PhysicalDef * t1.PhysicalDef;

                t.MagicDmg -= t.MagicDmg * t1.MagicDmg;
                t.MagicDef -= t1.MagicDef;

                t.HP -= t.HP * t1.HP;
                t.Speed -= t.Speed * t1.Speed;

                t.Crit -= t.Crit * t1.Crit;
                t.Dodge -= t.Dodge * t1.Dodge;
            }
            return t;
        }
        #endregion
    }
}
