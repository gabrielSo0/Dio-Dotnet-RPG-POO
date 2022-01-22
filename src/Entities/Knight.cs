using System;

namespace POO.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType, int hp, int mp) : base(name, level, heroType, hp, mp)
        {
        }

        public override string Attack()
        {
            return $"{this.Name} attacked with the sword";
        }

        public override string Defense()
        {
            return $"{this.Name} defended the attack";
        }
    }
}