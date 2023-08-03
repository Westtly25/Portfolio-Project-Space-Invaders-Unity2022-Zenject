using System;
using Zenject;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Code.Scripts.Runtime.Input_System
{
    public class InputService : IInitializable, IDisposable
    {
        public Vector3 Direction { get; private set; }

        private readonly GameInput inputActions;

        public InputService() =>
            this.inputActions = new GameInput();

        public void Initialize() =>
            InputSystem.onDeviceChange += InputSystem_onDeviceChange;

        public void Dispose() =>
            InputSystem.onDeviceChange -= InputSystem_onDeviceChange;

        private void InputSystem_onDeviceChange(InputDevice arg1, InputDeviceChange arg2)
        {
            switch (arg2)
            {
                case InputDeviceChange.Added:
                    break;
                case InputDeviceChange.Removed:
                    break;
                case InputDeviceChange.Disconnected:
                    break;
                case InputDeviceChange.Reconnected:
                    break;
                case InputDeviceChange.Enabled:
                    break;
                case InputDeviceChange.Disabled:
                    break;
                case InputDeviceChange.UsageChanged:
                    break;
                case InputDeviceChange.ConfigurationChanged:
                    break;
                case InputDeviceChange.SoftReset:
                    break;
                case InputDeviceChange.HardReset:
                    break;
                default:
                    break;
            }
        }
    }
}