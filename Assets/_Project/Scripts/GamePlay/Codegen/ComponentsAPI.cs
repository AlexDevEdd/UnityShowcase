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
        public const int Collider = 50; // Collider


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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Collider GetCollider(this IEntity obj) => obj.GetValue<Collider>(Collider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCollider(this IEntity obj, out Collider value) => obj.TryGetValue(Collider, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCollider(this IEntity obj, Collider value) => obj.AddValue(Collider, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCollider(this IEntity obj) => obj.HasValue(Collider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCollider(this IEntity obj) => obj.DelValue(Collider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCollider(this IEntity obj, Collider value) => obj.SetValue(Collider, value);
    }
}
