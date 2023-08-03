using System;
using UnityEngine;

namespace Assets.Code.Runtime.Save_System
{
    public sealed class UniqueId : MonoBehaviour
    {
        public string Id { get; private set; }

        public void GenerateId() =>
          Id = $"{gameObject.scene.name}_{Guid.NewGuid().ToString()}";
    }
}
