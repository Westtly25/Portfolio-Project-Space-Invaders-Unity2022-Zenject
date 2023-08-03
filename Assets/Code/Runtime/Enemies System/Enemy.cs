using System;
using UnityEngine;
using Assets.Code.Runtime.Save_System;
using Assets.Code.Scripts.Runtime.Pause;

namespace Assets.Code.Runtime.Enemies_System
{
    [RequireComponent(typeof(UniqueId))]
    public class Enemy : MonoBehaviour
    {
        [SerializeField]
        private EnemyDifficulty enemyDifficulty;

        private IPauseHandler pauseHandler;

        public void Constructor(IPauseHandler pauseHandler) =>
            this.pauseHandler = pauseHandler;

        private void Update()
        {
            if (pauseHandler != null &
                pauseHandler.IsPaused)
                return;


        }
    }
}