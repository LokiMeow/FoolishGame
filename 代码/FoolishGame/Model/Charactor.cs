using System.Collections.Generic;

namespace Model
{
    public class Charactor : Model.BaseProperty
    {
        /// <summary>
        /// 所持武器
        /// </summary>
        /// <value>The weapon.</value>
        public Weapon Weapon { get; set; }

        /// <summary>
        /// Buff列表
        /// </summary>
        /// <value>The buff list.</value>
        public List<Buff> BuffList { get; set; }

        /// <summary>
        /// 身上药剂列表
        /// </summary>
        /// <value>The medicine list.</value>
        public List<Medicine> MedicineList { get; set; }

        /// <summary>
        /// 攻击目标列表
        /// </summary>
        /// <value>The target charactor list.</value>
        public List<Charactor> TargetCharactorList { get; set; }
    }
}