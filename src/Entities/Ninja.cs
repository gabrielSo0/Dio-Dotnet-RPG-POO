namespace POO.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType, int hp, int mp) : base(name, level, heroType, hp, mp)
        {
        }

        public override string Attack()
        {
            return $"{this.Name} attacked with a shuriken";
        }

        public override string Defense()
        {
            return $"{this.Name} defended with the exchange jutsu";
        }
    }
}