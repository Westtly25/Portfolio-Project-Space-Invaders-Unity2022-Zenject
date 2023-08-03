using System;
using UnityEngine;

namespace Assets.Code.Runtime.Enemies_System
{
    [Serializable]
    public class EnemyConfig
    {
        [SerializeField, Range(int.MinValue, int.MaxValue)]
        private int id;
        [SerializeField, Range(-1, 200)]
        private float health;
        [SerializeField, Range(-1, 200)]
        private float armour;
        [SerializeField, Range(-1, 200)]
        private float baseDamage;
        [SerializeField, Range(-1, 200)]
        private float shootSpeed;
        [SerializeField, Range(0, 5)]
        private float movementSpeed;
        [SerializeField]
        private EnemyDifficulty enemyDifficulty;

        [SerializeField]
        private Enemy shipPrefab;

        [SerializeField]
        private Projectile projectilePrefab;
    }
}