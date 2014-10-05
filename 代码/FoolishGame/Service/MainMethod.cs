using Model;
using System.Collections.Generic;

namespace Service
{
	public class MainMethod
	{
		#region 攻击方法
		/// <summary>
		/// 常规数值攻击
		/// </summary>
		public void Attack (ref Charactor attacker, ref Charactor underAttacker, DamageType type)
		{
			switch (type) {
			case  DamageType.物理:
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
		}

		public void Attack (ref Charactor attacker, ref List<Charactor> underAttackerList)
		{
			//先对所有目标执行攻击动作
			foreach (var underAttacker in underAttackerList) {
				Attack (attacker, underAttacker);
			}
			//后更新Buff的持续回合数
			foreach (var buff in attacker.BuffList) {
				buff.Times--;
				if (buff.Times == 0) {
					RemoveBuff(attacker,buff);
				}
			}
		}
	
		#endregion

		#region 更新属性方法
		/// <summary>
		/// 将后者的属性增加到前者上
		/// </summary>
		/// <param name="t">T</param>
		/// <param name="t1">T1.</param>
		/// <param name="type">数值增加类型：百分比增加还是按值增加</param>
		/// <param name="isGood">增加还是减少,True为增加,反之为减少.默认为增加</param>
		public void UpdateProperty<T,T1> (ref T t, T1 t1, NumericalType type, bool isGood=true)
			where T:BaseProperty
				where T1:BaseProperty
		{
			switch (type) {
			case NumericalType.数值:
				UpdatePropertyValue (t, t1, isGood);
				break;
			case NumericalType.百分比:
				UpdatePropertyPercent (t, t1, isGood);
				break;
			}

		}

		public void UpdatePropertyValue<T,T1> (ref T t, T1 t1, bool isGood)
			where T:BaseProperty
				where T1:BaseProperty
		{
			if (isGood) {
				t.PhysicalDmg += t1.PhysicalDmg;
				t.PhysicalDef += t1.PhysicalDef;

				t.MagicDmg += t1.MagicDmg;
				t.MagicDef += t1.MagicDef;

				t.HP += t1.HP;
				t.Speed += t1.Speed;

				t.Crit += t1.Crit;
				t.Dodge += t1.Dodge;
			} else {
				t.PhysicalDmg -= t1.PhysicalDmg;
				t.PhysicalDef -= t1.PhysicalDef;
				
				t.MagicDmg -= t1.MagicDmg;
				t.MagicDef -= t1.MagicDef;
				
				t.HP -= t1.HP;
				t.Speed -= t1.Speed;
				
				t.Crit -= t1.Crit;
				t.Dodge -= t1.Dodge;
			}

		}

		public void UpdatePropertyPercent<T,T1> (ref T t, T1 t1, bool isGood)
			where T:BaseProperty
				where T1:BaseProperty
		{
			if (isGood) {
				t.PhysicalDmg *= t1.PhysicalDmg;
				t.PhysicalDef *= t1.PhysicalDef;
			
				t.MagicDmg *= t1.MagicDmg;
				t.MagicDef *= t1.MagicDef;
			
				t.HP *= t1.HP;
				t.Speed *= t1.Speed;
			
				t.Crit *= t1.Crit;
				t.Dodge *= t1.Dodge;
			} else {
				t.PhysicalDmg /= t1.PhysicalDmg;
				t.PhysicalDef /= t1.PhysicalDef;
				
				t.MagicDmg /= t1.MagicDmg;
				t.MagicDef /= t1.MagicDef;
				
				t.HP /= t1.HP;
				t.Speed /= t1.Speed;
				
				t.Crit /= t1.Crit;
				t.Dodge /= t1.Dodge;
			}
		}
		#endregion

		#region 角色武器初始化方法
		public void UpdateWeapon (ref Charactor charactor)
		{
			UpdateProperty (charactor, charactor.Weapon, NumericalType.数值);
		}

		public void UpdateWeapon (ref List<Charactor>  charactorList)
		{
			foreach (var item in charactorList) {
				UpdateWeapon (item);
			}
		}
		#endregion

		#region 角色药剂初始化方法
		public void UpdateMedicine (ref Charactor charactor)
		{
			foreach (var item in charactor.MedicineList) {
				UpdateProperty (charactor, item, item.NumericalType);
			}
		}
		
		public void UpdateMedicine (ref List<Charactor>  charactorList)
		{
			foreach (var item in charactorList) {
				UpdateMedicine (item);
			}
		}
		#endregion

		#region 角色Buff增加与移除方法
		public void AddBuff (ref Charactor charactor, Buff buff)
		{
			UpdateProperty (charactor, buff, buff.NumericalType);
		}
		
		public void AddBuff (ref List<Charactor>  charactorList, Buff buff)
		{
			foreach (var item in charactorList) {
				AddBuff (item, buff);
			}
		}

		public void RemoveBuff (ref Charactor charactor, Buff buff)
		{
			UpdateProperty (charactor, buff, buff.NumericalType, false);
		}

		public void RemoveBuff (ref List<Charactor>  charactorList, Buff buff)
		{
			foreach (var item in charactorList) {
				RemoveBuff (item, buff);
			}
		}
		#endregion
		
	}
}

