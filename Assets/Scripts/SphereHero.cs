using UnityEngine;

namespace Dota2
{
    public class SphereHero : CharacteristicsHero
    {
        public SphereHero()
        {
            Strenght = 20;
            Agility = 15;
            Intelligence = 10;
            HitPoint = (200 + (Strenght * 20));
            ManaPoint = (75 + (Intelligence * 11));
            HPRegen = (int)((1.5) * (1 + 0.007 * Strenght));
            MPRegen = (int)((0.01) * (1 + 0.002 * Intelligence));
            MoveSpeed = 300;
            Attack = (int)(10 * 0.2 * Agility);
        }
    }
}
