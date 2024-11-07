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
    public static class StatsAPI
    {
        ///Keys
        public const int Health = 43; // ReactiveFloat
        public const int MaxHealth = 44; // ReactiveInt


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveFloat GetHealth(this IEntity obj) => obj.GetValue<ReactiveFloat>(Health);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetHealth(this IEntity obj, out ReactiveFloat value) => obj.TryGetValue(Health, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddHealth(this IEntity obj, ReactiveFloat value) => obj.AddValue(Health, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasHealth(this IEntity obj) => obj.HasValue(Health);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelHealth(this IEntity obj) => obj.DelValue(Health);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetHealth(this IEntity obj, ReactiveFloat value) => obj.SetValue(Health, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveInt GetMaxHealth(this IEntity obj) => obj.GetValue<ReactiveInt>(MaxHealth);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMaxHealth(this IEntity obj, out ReactiveInt value) => obj.TryGetValue(MaxHealth, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddMaxHealth(this IEntity obj, ReactiveInt value) => obj.AddValue(MaxHealth, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasMaxHealth(this IEntity obj) => obj.HasValue(MaxHealth);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelMaxHealth(this IEntity obj) => obj.DelValue(MaxHealth);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetMaxHealth(this IEntity obj, ReactiveInt value) => obj.SetValue(MaxHealth, value);
    }
}
