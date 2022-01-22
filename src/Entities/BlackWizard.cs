namespace POO.src.Entities
{
    public class BlackWizard : Wizard
    {
        public BlackWizard(string name, int level, string heroType, int hp, int mp) : base(name, level, heroType, hp, mp)
        {
        }
        public override string Attack()
        {
            return $"{this.Name} casted a black spell";
        }
        public override string Defense()
        {
            return $"{this.Name} defended the attack";
        }
    }
}