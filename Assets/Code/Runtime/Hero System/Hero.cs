using UnityEngine;
using Assets.Code.Runtime.Combat_System;
using Assets.Code.Scripts.Runtime.Input_System;

namespace Assets.Code.Runtime.Hero_System
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class Hero : MonoBehaviour
    {
        private MoveHandler moveHandler;

        [SerializeField]
        private ShootHandler shootHandler;

        [SerializeField]
        private Transform cachedTransform;

        private InputService inputService;

        public Transform CachedTransform => cachedTransform;

        public void Initialize(InputService inputService)
        {
            this.inputService = inputService;
        }

        private void OnEnable() =>
            cachedTransform = transform;

        private void Update()
        {
            //moveHandler.Move();
        }
    }
}