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
    public static class WeaponAPI
    {
        ///Keys
        public const int WeaponType = 17; // WeaponType
        public const int AmmoCapacity = 19; // ReactiveInt
        public const int RechargeDelay = 20; // ReactiveFloat
        public const int RemainingAmmo = 21; // ReactiveInt
        public const int ProjectileType = 22; // ProjectileType
        public const int Damage = 23; // ReactiveFloat


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WeaponType GetWeaponType(this IEntity obj) => obj.GetValue<WeaponType>(WeaponType);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetWeaponType(this IEntity obj, out WeaponType value) => obj.TryGetValue(WeaponType, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddWeaponType(this IEntity obj, WeaponType value) => obj.AddValue(WeaponType, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasWeaponType(this IEntity obj) => obj.HasValue(WeaponType);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelWeaponType(this IEntity obj) => obj.DelValue(WeaponType);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWeaponType(this IEntity obj, WeaponType value) => obj.SetValue(WeaponType, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveInt GetAmmoCapacity(this IEntity obj) => obj.GetValue<ReactiveInt>(AmmoCapacity);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetAmmoCapacity(this IEntity obj, out ReactiveInt value) => obj.TryGetValue(AmmoCapacity, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddAmmoCapacity(this IEntity obj, ReactiveInt value) => obj.AddValue(AmmoCapacity, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasAmmoCapacity(this IEntity obj) => obj.HasValue(AmmoCapacity);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelAmmoCapacity(this IEntity obj) => obj.DelValue(AmmoCapacity);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetAmmoCapacity(this IEntity obj, ReactiveInt value) => obj.SetValue(AmmoCapacity, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveFloat GetRechargeDelay(this IEntity obj) => obj.GetValue<ReactiveFloat>(RechargeDelay);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetRechargeDelay(this IEntity obj, out ReactiveFloat value) => obj.TryGetValue(RechargeDelay, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddRechargeDelay(this IEntity obj, ReactiveFloat value) => obj.AddValue(RechargeDelay, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasRechargeDelay(this IEntity obj) => obj.HasValue(RechargeDelay);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelRechargeDelay(this IEntity obj) => obj.DelValue(RechargeDelay);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetRechargeDelay(this IEntity obj, ReactiveFloat value) => obj.SetValue(RechargeDelay, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveInt GetRemainingAmmo(this IEntity obj) => obj.GetValue<ReactiveInt>(RemainingAmmo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetRemainingAmmo(this IEntity obj, out ReactiveInt value) => obj.TryGetValue(RemainingAmmo, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddRemainingAmmo(this IEntity obj, ReactiveInt value) => obj.AddValue(RemainingAmmo, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasRemainingAmmo(this IEntity obj) => obj.HasValue(RemainingAmmo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelRemainingAmmo(this IEntity obj) => obj.DelValue(RemainingAmmo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetRemainingAmmo(this IEntity obj, ReactiveInt value) => obj.SetValue(RemainingAmmo, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ProjectileType GetProjectileType(this IEntity obj) => obj.GetValue<ProjectileType>(ProjectileType);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetProjectileType(this IEntity obj, out ProjectileType value) => obj.TryGetValue(ProjectileType, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddProjectileType(this IEntity obj, ProjectileType value) => obj.AddValue(ProjectileType, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasProjectileType(this IEntity obj) => obj.HasValue(ProjectileType);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelProjectileType(this IEntity obj) => obj.DelValue(ProjectileType);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetProjectileType(this IEntity obj, ProjectileType value) => obj.SetValue(ProjectileType, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveFloat GetDamage(this IEntity obj) => obj.GetValue<ReactiveFloat>(Damage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetDamage(this IEntity obj, out ReactiveFloat value) => obj.TryGetValue(Damage, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddDamage(this IEntity obj, ReactiveFloat value) => obj.AddValue(Damage, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasDamage(this IEntity obj) => obj.HasValue(Damage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelDamage(this IEntity obj) => obj.DelValue(Damage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetDamage(this IEntity obj, ReactiveFloat value) => obj.SetValue(Damage, value);
    }
}
