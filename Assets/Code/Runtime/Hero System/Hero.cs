using UnityEngine;

namespace Assets.Code.Runtime.Hero_System
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class Hero : MonoBehaviour
    {
        [SerializeField]
        private MoveHandler moveHandler;

        [SerializeField]
        private ShootHandler shootHandler;


    }
}