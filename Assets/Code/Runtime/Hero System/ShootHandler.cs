using System;
using UnityEngine;
using Assets.Code.Runtime.Combat_System;
using Assets.Code.Runtime.Enemies_System;
using UnityEngine.Pool;

namespace Assets.Code.Runtime.Hero_System
{
    [Serializable]
    public class ShootHandler
    {
        [SerializeField]
        private ShootingPoint[] shootingPoints;

        [SerializeField]
        private IObjectPool<Projectile> projectilePool;

        public ShootHandler(ShootingPoint[] shootingPoints) =>
            this.shootingPoints = shootingPoints;

        public void Shoot()
        {
            for (int i = 0; i < shootingPoints.Length; i++)
            {
                //shootingPoints[i].PointTransform;
            }
        }
    }
}