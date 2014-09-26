using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    /// <summary>
    /// 
    /// </summary>
    public class Person
    {
        public List<Buff> Buffs { get; set; }
    }

    public class Buff
    {
    }

    /// <summary>
    /// 伤害类型
    /// </summary>
    public enum XXType
    {
        Physical = 1,
        Magic = 2,
        /// <summary>
        /// 纯粹伤害，不受减免
        /// </summary>
        Pure =4,
    }

    public class aaa
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="AttPerson">攻击发起者</param>
        /// <param name="DefPerson">被攻击者</param>
        /// <param name="type">伤害类型</param>
        public void NormalAttack(Person AttPerson, Person DefPerson, XXType type) {
        }

        ///// <summary>
        ///// 大招攻击方法
        ///// </summary>
        //public void SuperAttack(Person AttPerson, Person DefPerson, XXType type) {
        //}

        /// <summary>
        /// 
        /// </summary>
        public void XXXBuff() {
        }
    }
}
