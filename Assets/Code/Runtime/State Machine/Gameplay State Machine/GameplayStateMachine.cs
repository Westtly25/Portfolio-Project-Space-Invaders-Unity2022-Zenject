﻿using Zenject;
using Assets.Code.Scripts.Runtime.Data;
using Assets.Code.Scripts.Runtime.Pause;
using Assets.Code.Scripts.Runtime.Save_System;

namespace Assets.Code.Scripts.Runtime.State_Machine.Gameplay_State_Machine
{
    public class GameplayStateMachine : StateMachine, IPauseListener
    {
        private bool isPaused = false;

        [Inject]
        public GameplayStateMachine()
        {
            State[] states =
            {
                
            };

            AddStates(states);
        }

        public override void Run()
        {
            if (isPaused)
                return;

            base.Run();
        }

        public void Pause(bool isPaused) =>
            this.isPaused = isPaused;
    }
}