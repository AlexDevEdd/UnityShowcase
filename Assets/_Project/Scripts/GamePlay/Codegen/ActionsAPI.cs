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
    public static class ActionsAPI
    {
        ///Keys
        public const int FireAction = 14; // EventAction
        public const int SwitchWeaponEvent = 24; // EventAction<int>
        public const int ReloadWeaponEvent = 28; // EventAction
        public const int DieAction = 34; // EventAction<IEntity>
        public const int ReloadWeaponRequest = 42; // EventAction
        public const int DamageRequest = 48; // EventAction<IEntity, Vector3, float>
        public const int DamageEvent = 49; // EventAction<IEntity, Vector3, float>


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EventAction GetFireAction(this IEntity obj) => obj.GetValue<EventAction>(FireAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetFireAction(this IEntity obj, out EventAction value) => obj.TryGetValue(FireAction, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddFireAction(this IEntity obj, EventAction value) => obj.AddValue(FireAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFireAction(this IEntity obj) => obj.HasValue(FireAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelFireAction(this IEntity obj) => obj.DelValue(FireAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetFireAction(this IEntity obj, EventAction value) => obj.SetValue(FireAction, value);

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EventAction<IEntity> GetDieAction(this IEntity obj) => obj.GetValue<EventAction<IEntity>>(DieAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetDieAction(this IEntity obj, out EventAction<IEntity> value) => obj.TryGetValue(DieAction, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddDieAction(this IEntity obj, EventAction<IEntity> value) => obj.AddValue(DieAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasDieAction(this IEntity obj) => obj.HasValue(DieAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelDieAction(this IEntity obj) => obj.DelValue(DieAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetDieAction(this IEntity obj, EventAction<IEntity> value) => obj.SetValue(DieAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EventAction GetReloadWeaponRequest(this IEntity obj) => obj.GetValue<EventAction>(ReloadWeaponRequest);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetReloadWeaponRequest(this IEntity obj, out EventAction value) => obj.TryGetValue(ReloadWeaponRequest, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddReloadWeaponRequest(this IEntity obj, EventAction value) => obj.AddValue(ReloadWeaponRequest, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasReloadWeaponRequest(this IEntity obj) => obj.HasValue(ReloadWeaponRequest);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelReloadWeaponRequest(this IEntity obj) => obj.DelValue(ReloadWeaponRequest);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetReloadWeaponRequest(this IEntity obj, EventAction value) => obj.SetValue(ReloadWeaponRequest, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EventAction<IEntity, Vector3, float> GetDamageRequest(this IEntity obj) => obj.GetValue<EventAction<IEntity, Vector3, float>>(DamageRequest);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetDamageRequest(this IEntity obj, out EventAction<IEntity, Vector3, float> value) => obj.TryGetValue(DamageRequest, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddDamageRequest(this IEntity obj, EventAction<IEntity, Vector3, float> value) => obj.AddValue(DamageRequest, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasDamageRequest(this IEntity obj) => obj.HasValue(DamageRequest);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelDamageRequest(this IEntity obj) => obj.DelValue(DamageRequest);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetDamageRequest(this IEntity obj, EventAction<IEntity, Vector3, float> value) => obj.SetValue(DamageRequest, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EventAction<IEntity, Vector3, float> GetDamageEvent(this IEntity obj) => obj.GetValue<EventAction<IEntity, Vector3, float>>(DamageEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetDamageEvent(this IEntity obj, out EventAction<IEntity, Vector3, float> value) => obj.TryGetValue(DamageEvent, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddDamageEvent(this IEntity obj, EventAction<IEntity, Vector3, float> value) => obj.AddValue(DamageEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasDamageEvent(this IEntity obj) => obj.HasValue(DamageEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelDamageEvent(this IEntity obj) => obj.DelValue(DamageEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetDamageEvent(this IEntity obj, EventAction<IEntity, Vector3, float> value) => obj.SetValue(DamageEvent, value);
    }
}
