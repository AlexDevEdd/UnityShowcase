using System;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public struct SphereSensorData
    {
        public Transform Center;
        public float Radius;
        public LayerMask LayerMask;
    }
}