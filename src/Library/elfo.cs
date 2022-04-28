using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elfo
{
    using System;

    public class Character
    {
        public Character(string nickname, int lives, int damage, string power)
        {
            this.Nickname = nickname;
            this.Life = lives;
            this.Damage = damage;
            this.Power = power;
        }

        public string Nickname { get; }

        public int Life { get; private set; }

        public int Damage { get; }

        public string Power { get; }

        public void Attack(Character enemy)
        {
            enemy.Life = enemy.Life - this.Damage;
        }

        public bool Healthy()
        {
            return this.Life > 0;
        }
    }
}
