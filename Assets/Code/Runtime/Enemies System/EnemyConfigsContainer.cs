using UnityEngine;

namespace Assets.Code.Runtime.Enemies_System
{
    [CreateAssetMenu(fileName = "Enemy Configs Container", menuName = "Game / Configs / Enemy Configs Container", order = 1)]
    public class EnemyConfigsContainer : ScriptableObject
    {
        [SerializeField]
        public EnemyConfig[] EnemyConfig;
    }
}