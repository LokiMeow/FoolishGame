using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{

    //Physical = 1,
    //Magic = 2,

    public class BaseModel
    {
        public Guid ID { get; set; }
    }

    /// <summary>
    /// 角色属性基类
    /// </summary>
    public class BaseProperty : BaseModel
    {
        /// <summary>
        /// 物理伤害
        /// </summary>
        public int PhysicalDmg { get; set; }

        public int MagicDmg { get; set; }

        /// <summary>
        /// 物理防御
        /// </summary>
        public int PhysicalDef { get; set; }

        public int MagicDef { get; set; }

        public int HP { get; set; }

        /// <summary>
        /// 暴击
        /// </summary>
        public int Crit { get; set; }

        /// <summary>
        /// 闪避
        /// </summary>
        public int Dodge { get; set; }
    }

    /// <summary>
    /// 角色
    /// </summary>
    public class Charactor : BaseProperty
    {
        public Weapon Weapon { get; set; }
    }

    /// <summary>
    /// 武器
    /// </summary>
    public class Weapon
    {

        public AttackType AttackType { get; set; }
    }

    /// <summary>
    /// 技能
    /// </summary>
    public class Skill
    {
        public NumericalType NumericalType { get; set; }
    }

    /// <summary>
    /// 药剂
    /// </summary>
    public class Medicine { }

    /// <summary>
    /// 状态
    /// </summary>
    public class Buff
    {
        /// <summary>
        /// BUFF的剩余次数
        /// </summary>
        public int Times { get; set; }
    }

    /// <summary>
    /// 攻击类型
    /// </summary>
    public enum AttackType
    {
        近战 = 1,
        远程 = 2,
    }

    /// <summary>
    /// 数值类型
    /// </summary>
    public enum NumericalType
    {
        数值 = 1,
        百分比 = 2,
    }

    /// <summary>
    /// 伤害类型
    /// </summary>
    public enum DamageType
    {
        物理 = 1,
        魔法 = 2,
        /// <summary>
        /// 不受任何防御减免
        /// </summary>
        纯粹 = 4,
    }
}
