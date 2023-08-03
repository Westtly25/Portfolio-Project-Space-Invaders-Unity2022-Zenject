using System;
using UnityEngine;
using UnityEngine.Pool;
using Assets.Code.Runtime.Enemies_System;
using System.Buffers;
using Zenject;

namespace Assets.Code.Runtime.Combat_System
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

    public class ProjectilesPool : MemoryPool<Vector3, Projectile>
    {
    }
}