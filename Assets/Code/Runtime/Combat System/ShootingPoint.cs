 using UnityEngine;

namespace Assets.Code.Runtime.Combat_System
{
    public class ShootingPoint : MonoBehaviour
    {
        [SerializeField]
        private Transform pointTransform;

        public Transform PointTransform => pointTransform;

        private void OnEnable() =>
            pointTransform = transform;
    }
}