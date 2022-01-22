namespace POO.src.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, string heroType, int hp, int mp)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.HP = hp;
            this.MP = mp;
            
            HeroCount++;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int XP { get; set; }
        private static int HeroCount;

        public override string ToString()
        {
            return $@"
            Name: {this.Name} | Level: {this.Level}
            Class: {this.HeroType}
            HP: {this.HP} | MP: {this.MP}
            XP: {this.XP}
            Numbers of heros: {this.returnHerosCount()}";
        }
        public abstract string Attack();
        public abstract string Defense();
        public int returnHerosCount()
        {
            return HeroCount;
        }


        // public virtual string Attack(int bonus)
        // {
        //     return this.Name = " Atacou com sua espada e com bonus de ataque de " + bonus;
        // }

    }

}