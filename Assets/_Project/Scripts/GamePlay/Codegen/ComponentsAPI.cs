/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Entities;
using System.Runtime.CompilerServices;
using Atomic.Elements;
using Atomic.Extensions;
using Unity.Mathematics;
using UnityEngine.Animations.Rigging;
using GamePlay;
using UnityEngine.AI;

namespace Atomic.Entities
{
    public static class ComponentsAPI
    {
        ///Keys
        public const int Agent = 45; // NavMeshAgent
        public const int Laser = 46; // LineRenderer


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NavMeshAgent GetAgent(this IEntity obj) => obj.GetValue<NavMeshAgent>(Agent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetAgent(this IEntity obj, out NavMeshAgent value) => obj.TryGetValue(Agent, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddAgent(this IEntity obj, NavMeshAgent value) => obj.AddValue(Agent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasAgent(this IEntity obj) => obj.HasValue(Agent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelAgent(this IEntity obj) => obj.DelValue(Agent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetAgent(this IEntity obj, NavMeshAgent value) => obj.SetValue(Agent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LineRenderer GetLaser(this IEntity obj) => obj.GetValue<LineRenderer>(Laser);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetLaser(this IEntity obj, out LineRenderer value) => obj.TryGetValue(Laser, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddLaser(this IEntity obj, LineRenderer value) => obj.AddValue(Laser, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasLaser(this IEntity obj) => obj.HasValue(Laser);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelLaser(this IEntity obj) => obj.DelValue(Laser);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetLaser(this IEntity obj, LineRenderer value) => obj.SetValue(Laser, value);
    }
}
