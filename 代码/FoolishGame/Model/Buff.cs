namespace Model
{
    public class Buff : BaseProperty
    {
        public NumericalType NumericalType { get; set; }

        /// <summary>
        /// Buff的剩余次数,正值为暂时性Buff,负值为永久性Buff,Times为0的Buff会遭到清除
        /// </summary>
        /// <value>The times.</value>
        public int Times { get; set; }
    }
}