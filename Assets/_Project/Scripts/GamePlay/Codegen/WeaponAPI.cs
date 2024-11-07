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
    public static class WeaponAPI
    {
        ///Keys
        public const int WeaponType = 17; // WeaponType
        public const int TotalCapacity = 19; // ReactiveInt
        public const int RechargeDelay = 20; // ReactiveFloat
        public const int CurrentAmmo = 21; // ReactiveInt
        public const int ProjectileType = 22; // ProjectileType
        public const int Damage = 23; // ReactiveFloat
        public const int AnimLayerIndex = 27; // int
        public const int FirePoint = 32; // Transform
        public const int LifeTimer = 31; // Countdown
        public const int LifeTime = 33; // float
        public const int FireEffect = 35; // ParticleSystem
        public const int TotalAmmo = 39; // ReactiveInt
        public const int MagazineCapacity = 40; // ReactiveInt


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
        public static ReactiveInt GetTotalCapacity(this IEntity obj) => obj.GetValue<ReactiveInt>(TotalCapacity);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetTotalCapacity(this IEntity obj, out ReactiveInt value) => obj.TryGetValue(TotalCapacity, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddTotalCapacity(this IEntity obj, ReactiveInt value) => obj.AddValue(TotalCapacity, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasTotalCapacity(this IEntity obj) => obj.HasValue(TotalCapacity);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelTotalCapacity(this IEntity obj) => obj.DelValue(TotalCapacity);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetTotalCapacity(this IEntity obj, ReactiveInt value) => obj.SetValue(TotalCapacity, value);

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
        public static ReactiveInt GetCurrentAmmo(this IEntity obj) => obj.GetValue<ReactiveInt>(CurrentAmmo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCurrentAmmo(this IEntity obj, out ReactiveInt value) => obj.TryGetValue(CurrentAmmo, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCurrentAmmo(this IEntity obj, ReactiveInt value) => obj.AddValue(CurrentAmmo, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCurrentAmmo(this IEntity obj) => obj.HasValue(CurrentAmmo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCurrentAmmo(this IEntity obj) => obj.DelValue(CurrentAmmo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCurrentAmmo(this IEntity obj, ReactiveInt value) => obj.SetValue(CurrentAmmo, value);

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetAnimLayerIndex(this IEntity obj) => obj.GetValue<int>(AnimLayerIndex);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetAnimLayerIndex(this IEntity obj, out int value) => obj.TryGetValue(AnimLayerIndex, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddAnimLayerIndex(this IEntity obj, int value) => obj.AddValue(AnimLayerIndex, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasAnimLayerIndex(this IEntity obj) => obj.HasValue(AnimLayerIndex);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelAnimLayerIndex(this IEntity obj) => obj.DelValue(AnimLayerIndex);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetAnimLayerIndex(this IEntity obj, int value) => obj.SetValue(AnimLayerIndex, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Transform GetFirePoint(this IEntity obj) => obj.GetValue<Transform>(FirePoint);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetFirePoint(this IEntity obj, out Transform value) => obj.TryGetValue(FirePoint, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddFirePoint(this IEntity obj, Transform value) => obj.AddValue(FirePoint, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFirePoint(this IEntity obj) => obj.HasValue(FirePoint);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelFirePoint(this IEntity obj) => obj.DelValue(FirePoint);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetFirePoint(this IEntity obj, Transform value) => obj.SetValue(FirePoint, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Countdown GetLifeTimer(this IEntity obj) => obj.GetValue<Countdown>(LifeTimer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetLifeTimer(this IEntity obj, out Countdown value) => obj.TryGetValue(LifeTimer, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddLifeTimer(this IEntity obj, Countdown value) => obj.AddValue(LifeTimer, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasLifeTimer(this IEntity obj) => obj.HasValue(LifeTimer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelLifeTimer(this IEntity obj) => obj.DelValue(LifeTimer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetLifeTimer(this IEntity obj, Countdown value) => obj.SetValue(LifeTimer, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float GetLifeTime(this IEntity obj) => obj.GetValue<float>(LifeTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetLifeTime(this IEntity obj, out float value) => obj.TryGetValue(LifeTime, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddLifeTime(this IEntity obj, float value) => obj.AddValue(LifeTime, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasLifeTime(this IEntity obj) => obj.HasValue(LifeTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelLifeTime(this IEntity obj) => obj.DelValue(LifeTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetLifeTime(this IEntity obj, float value) => obj.SetValue(LifeTime, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem GetFireEffect(this IEntity obj) => obj.GetValue<ParticleSystem>(FireEffect);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetFireEffect(this IEntity obj, out ParticleSystem value) => obj.TryGetValue(FireEffect, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddFireEffect(this IEntity obj, ParticleSystem value) => obj.AddValue(FireEffect, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFireEffect(this IEntity obj) => obj.HasValue(FireEffect);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelFireEffect(this IEntity obj) => obj.DelValue(FireEffect);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetFireEffect(this IEntity obj, ParticleSystem value) => obj.SetValue(FireEffect, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveInt GetTotalAmmo(this IEntity obj) => obj.GetValue<ReactiveInt>(TotalAmmo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetTotalAmmo(this IEntity obj, out ReactiveInt value) => obj.TryGetValue(TotalAmmo, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddTotalAmmo(this IEntity obj, ReactiveInt value) => obj.AddValue(TotalAmmo, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasTotalAmmo(this IEntity obj) => obj.HasValue(TotalAmmo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelTotalAmmo(this IEntity obj) => obj.DelValue(TotalAmmo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetTotalAmmo(this IEntity obj, ReactiveInt value) => obj.SetValue(TotalAmmo, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveInt GetMagazineCapacity(this IEntity obj) => obj.GetValue<ReactiveInt>(MagazineCapacity);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMagazineCapacity(this IEntity obj, out ReactiveInt value) => obj.TryGetValue(MagazineCapacity, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddMagazineCapacity(this IEntity obj, ReactiveInt value) => obj.AddValue(MagazineCapacity, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasMagazineCapacity(this IEntity obj) => obj.HasValue(MagazineCapacity);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelMagazineCapacity(this IEntity obj) => obj.DelValue(MagazineCapacity);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetMagazineCapacity(this IEntity obj, ReactiveInt value) => obj.SetValue(MagazineCapacity, value);
    }
}
