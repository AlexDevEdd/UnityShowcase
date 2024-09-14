/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Entities;
using System.Runtime.CompilerServices;
using Atomic.Elements;
using Atomic.Extensions;
using Unity.Mathematics;
using GamePlay;

namespace Atomic.Entities
{
    public static class ActionsAPI
    {
        ///Keys
        public const int FireEvent = 14; // EventAction
        public const int WeaponIndex = 24; // EventAction<int>


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EventAction GetFireEvent(this IEntity obj) => obj.GetValue<EventAction>(FireEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetFireEvent(this IEntity obj, out EventAction value) => obj.TryGetValue(FireEvent, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddFireEvent(this IEntity obj, EventAction value) => obj.AddValue(FireEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFireEvent(this IEntity obj) => obj.HasValue(FireEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelFireEvent(this IEntity obj) => obj.DelValue(FireEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetFireEvent(this IEntity obj, EventAction value) => obj.SetValue(FireEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EventAction<int> GetWeaponIndex(this IEntity obj) => obj.GetValue<EventAction<int>>(WeaponIndex);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetWeaponIndex(this IEntity obj, out EventAction<int> value) => obj.TryGetValue(WeaponIndex, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddWeaponIndex(this IEntity obj, EventAction<int> value) => obj.AddValue(WeaponIndex, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasWeaponIndex(this IEntity obj) => obj.HasValue(WeaponIndex);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelWeaponIndex(this IEntity obj) => obj.DelValue(WeaponIndex);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWeaponIndex(this IEntity obj, EventAction<int> value) => obj.SetValue(WeaponIndex, value);
    }
}
