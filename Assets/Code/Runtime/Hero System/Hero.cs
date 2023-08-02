using UnityEngine;
using UnityEngine.Pool;
using Assets.Code.Runtime.Enemies_System;

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