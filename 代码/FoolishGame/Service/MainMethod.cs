using Model;
using System.Collections.Generic;
using System;

namespace Service
{
    public class MainMethod
    {
        #region 攻击方法
        /// <summary>
        /// 常规数值攻击
        /// </summary>
        private Charactor Attack(Charactor attacker, Charactor underAttacker, DamageType type) {
            switch (type) {
                case DamageType.物理:
                    underAttacker.HP = attacker.PhysicalDmg - underAttacker.PhysicalDef;
                    break;
                case DamageType.魔法:
                    underAttacker.HP = attacker.MagicDmg - underAttacker.MagicDef;
                    break;
                case DamageType.纯粹:
                    underAttacker.HP -= attacker.RealDmg;
                    break;
                default:
                    break;
            }
            return underAttacker;
        }

        public List<Charactor> Attack(ref Charactor attacker, List<Charactor> underAttackerList) {
            //先对所有目标执行攻击动作
            var result = new List<Charactor>();
            foreach (var underAttacker in underAttackerList) {
               result.Add( Attack(attacker, underAttacker, attacker.Weapon.DamageType));
            }
            //后更新Buff的持续回合数
            foreach (var buff in attacker.BuffList) {
                buff.Times--;
                if (buff.Times == 0) {
                    BuffService.UpdateBuff(attacker, buff,false);
                }
            }

            return result;
        }

        #endregion

    }
}