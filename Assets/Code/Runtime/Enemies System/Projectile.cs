using Zenject;
using UnityEngine;
using Assets.Code.Runtime.Hero_System;

namespace Assets.Code.Runtime.Enemies_System
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField]
        private Hero hero;

        private IMovement movement;

        [Inject]
        public void Constructor(Hero hero) =>
            this.hero = hero;


        private void Update() =>
            movement.Move();
    }

    public interface IMovement
    {
        void Move();
    }

    public class ChaseMovement : IMovement
    {
        public void Move()
        {
        }
    }

    public class DirectionMovement : IMovement
    {
        public void Move()
        {
        }
    }

    public class PositionMovement : IMovement
    {
        public void Move()
        {
        }
    }
}
