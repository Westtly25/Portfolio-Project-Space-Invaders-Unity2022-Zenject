using System;
using UnityEngine;

namespace Assets.Code.Runtime.Hero_System
{
    [Serializable]
    public class MoveHandler : MonoBehaviour
    {
        [SerializeField]
        private readonly Transform parent;

        public MoveHandler(Transform parent) =>
            this.parent = parent;

        public void Move(Vector3 direction)
        {
            
        }
    }
}