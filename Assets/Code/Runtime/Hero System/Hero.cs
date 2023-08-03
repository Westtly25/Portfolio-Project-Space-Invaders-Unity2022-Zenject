using UnityEngine;
using Assets.Code.Runtime.Combat_System;

namespace Assets.Code.Runtime.Hero_System
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class Hero : MonoBehaviour
    {
        [SerializeField]
        private MoveHandler moveHandler;

        [SerializeField]
        private ShootHandler shootHandler;

        [SerializeField]
        private Transform cachedTransform;

        public Transform CachedTransform => cachedTransform;

        private void OnEnable() =>
            cachedTransform = transform;
    }
}