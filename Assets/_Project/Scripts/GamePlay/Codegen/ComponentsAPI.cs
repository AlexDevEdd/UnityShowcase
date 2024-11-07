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
    }
}
