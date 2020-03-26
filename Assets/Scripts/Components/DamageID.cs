using System;

namespace Game
{
    [Flags]
    public enum DamageID : int
    {
        None = 0,
        Enemy = 1,
        Hero = 2,
        Wall = 4,
        Obstacle = 8,
        HeroBullet = 16,
        EnemyBullet = 32,
    }
}
