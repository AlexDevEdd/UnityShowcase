using System;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public struct PatrolData
    {
        public bool Enabled;
        public int Index;
        public Transform[] Points;

        public Vector3 CurrentPosition => Points[Index].position;

        public void MoveNext()
        {
            Index = (Index + 1) % Points.Length;
        }
        
        public override string ToString()
        {
            return $"{nameof(Enabled)}: {Enabled}, {nameof(Index)}: {Index}, {nameof(Points)}: {Points}";
        }
    }
}