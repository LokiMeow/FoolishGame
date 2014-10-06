using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Service;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod() {
            //初始化a角色
            var a = new Charactor();
            a.HP = 100000;
            //初始化a的武器
            var aWeapon = new Weapon();
            aWeapon.AttackType = AttackType.近战;
            aWeapon.DamageType = DamageType.物理;
            aWeapon.PhysicalDmg = 10000;
            aWeapon.Speed = 10000;
            a.Weapon = aWeapon;
            //初始化a的药剂:
            var aMedicine = new Medicine();
            aMedicine.NumericalType = NumericalType.百分比;
            aMedicine.HP = 1;
            a.MedicineList = new System.Collections.Generic.List<Medicine>();
            a.MedicineList.Add(aMedicine);
            a = MainMethod.Initialize(a);
            a.BuffList = new System.Collections.Generic.List<Buff>();
            

            var b = new Charactor();
            b.HP = 100000;

            var bWeapon = new Weapon();
            bWeapon.AttackType = AttackType.远程;
            bWeapon.DamageType = DamageType.魔法;
            bWeapon.MagicDmg = 20000;
            bWeapon.Speed = 20000;
            b.Weapon = bWeapon;

            var bMedicine = new Medicine();
            bMedicine.NumericalType = NumericalType.百分比;
            bMedicine.MagicDmg = 1;
            b.MedicineList = new System.Collections.Generic.List<Medicine>();
            b.MedicineList.Add(bMedicine);
            b = MainMethod.Initialize(b);

            b.BuffList = new System.Collections.Generic.List<Buff>();

            //把对方加入攻击列表
            a.TargetCharactorList = new System.Collections.Generic.List<Charactor>();
            a.TargetCharactorList.Add(b);
            b.TargetCharactorList = new System.Collections.Generic.List<Charactor>();
            b.TargetCharactorList.Add(a);

            //攻击动作
            while (a.HP == 0 || b.HP == 0) {
                MainMethod.Attack(ref a, a.TargetCharactorList);
                MainMethod.Attack(ref b, b.TargetCharactorList);
            }
        }
    }
}
