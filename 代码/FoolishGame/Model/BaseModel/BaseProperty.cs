namespace Model
{
	/// <summary>
	/// 属性基类
	/// 暴击闪避换算成概率要除以10000.如闪避为5000，其实闪避率为50%
	/// 攻击速度换算：除以1000之后为攻击间隔的秒数。比如说攻速4000，则为每4秒攻击一次
	/// </summary>
	public class BaseProperty: Model.BaseModel
	{
		/// <summary>
		/// 物理伤害
		/// </summary>
		public int PhysicalDmg { get; set; }

		/// <summary>
		/// 魔法攻击
		/// </summary>
		/// <value>The magic dmg.</value>
		public int MagicDmg { get; set; }
		
		/// <summary>
		/// 物理防御
		/// </summary>
		public int PhysicalDef { get; set; }

		/// <summary>
		/// 魔法防御
		/// </summary>
		/// <value>The magic def.</value>
		public int MagicDef { get; set; }

		/// <summary>
		/// 真实伤害
		/// </summary>
		/// <value>The real dmg.</value>
		public int RealDmg{ get; set; }
		
		public int HP { get; set; }
		
		/// <summary>
		/// 暴击
		/// </summary>
		public int Crit { get; set; }
		
		/// <summary>
		/// 闪避
		/// </summary>
		public int Dodge { get; set; }

		/// <summary>
		/// 攻击速度
		/// </summary>
		public int Speed{ get; set; }
	}
}