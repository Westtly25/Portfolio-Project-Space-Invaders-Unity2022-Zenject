using System;
using UnityEngine;

namespace Assets.Code.Runtime.Enemies_System
{
    [Serializable]
    public class EnemyConfig
    {
        [SerializeField, Range(int.MinValue, int.MaxValue)]
        private int id;
        [SerializeField]
        private float health;
        [SerializeField]
        private float armour;
        [SerializeField]
        private float baseDamage;
        [SerializeField]
        private float shootSpeed;

        [SerializeField]
        private Enemy shipPrefab;

        [SerializeField]
        private Projectile projectilePrefab;
    }
}