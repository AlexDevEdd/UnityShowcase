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
        public const int SwitchWeaponEvent = 24; // EventAction<int>
        public const int ReloadWeaponEvent = 28; // EventAction


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
        public static EventAction<int> GetSwitchWeaponEvent(this IEntity obj) => obj.GetValue<EventAction<int>>(SwitchWeaponEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetSwitchWeaponEvent(this IEntity obj, out EventAction<int> value) => obj.TryGetValue(SwitchWeaponEvent, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddSwitchWeaponEvent(this IEntity obj, EventAction<int> value) => obj.AddValue(SwitchWeaponEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasSwitchWeaponEvent(this IEntity obj) => obj.HasValue(SwitchWeaponEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelSwitchWeaponEvent(this IEntity obj) => obj.DelValue(SwitchWeaponEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetSwitchWeaponEvent(this IEntity obj, EventAction<int> value) => obj.SetValue(SwitchWeaponEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EventAction GetReloadWeaponEvent(this IEntity obj) => obj.GetValue<EventAction>(ReloadWeaponEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetReloadWeaponEvent(this IEntity obj, out EventAction value) => obj.TryGetValue(ReloadWeaponEvent, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddReloadWeaponEvent(this IEntity obj, EventAction value) => obj.AddValue(ReloadWeaponEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasReloadWeaponEvent(this IEntity obj) => obj.HasValue(ReloadWeaponEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelReloadWeaponEvent(this IEntity obj) => obj.DelValue(ReloadWeaponEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetReloadWeaponEvent(this IEntity obj, EventAction value) => obj.SetValue(ReloadWeaponEvent, value);
    }
}
