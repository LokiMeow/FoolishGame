namespace Model
{
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