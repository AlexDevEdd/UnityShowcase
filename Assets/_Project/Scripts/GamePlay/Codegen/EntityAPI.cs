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
    public static class EntityAPI
    {
        ///Keys
        public const int Transform = 1; // Transform
        public const int MoveSpeed = 2; // ReactiveFloat
        public const int MoveDirection = 3; // ReactiveVector3
        public const int Position = 4; // float3Reactive
        public const int Rotation = 5; // quaternionReactive
        public const int AngularSpeed = 6; // ReactiveFloat
        public const int CharacterController = 7; // CharacterController
        public const int LayerMask = 8; // LayerMask
        public const int Camera = 9; // Camera
        public const int RayHitInfo = 10; // ReactiveVector3
        public const int LookingDirection = 11; // ReactiveVector2
        public const int AimTransform = 12; // Transform


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Transform GetTransform(this IEntity obj) => obj.GetValue<Transform>(Transform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetTransform(this IEntity obj, out Transform value) => obj.TryGetValue(Transform, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddTransform(this IEntity obj, Transform value) => obj.AddValue(Transform, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasTransform(this IEntity obj) => obj.HasValue(Transform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelTransform(this IEntity obj) => obj.DelValue(Transform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetTransform(this IEntity obj, Transform value) => obj.SetValue(Transform, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveFloat GetMoveSpeed(this IEntity obj) => obj.GetValue<ReactiveFloat>(MoveSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMoveSpeed(this IEntity obj, out ReactiveFloat value) => obj.TryGetValue(MoveSpeed, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddMoveSpeed(this IEntity obj, ReactiveFloat value) => obj.AddValue(MoveSpeed, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasMoveSpeed(this IEntity obj) => obj.HasValue(MoveSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelMoveSpeed(this IEntity obj) => obj.DelValue(MoveSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetMoveSpeed(this IEntity obj, ReactiveFloat value) => obj.SetValue(MoveSpeed, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVector3 GetMoveDirection(this IEntity obj) => obj.GetValue<ReactiveVector3>(MoveDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMoveDirection(this IEntity obj, out ReactiveVector3 value) => obj.TryGetValue(MoveDirection, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddMoveDirection(this IEntity obj, ReactiveVector3 value) => obj.AddValue(MoveDirection, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasMoveDirection(this IEntity obj) => obj.HasValue(MoveDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelMoveDirection(this IEntity obj) => obj.DelValue(MoveDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetMoveDirection(this IEntity obj, ReactiveVector3 value) => obj.SetValue(MoveDirection, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3Reactive GetPosition(this IEntity obj) => obj.GetValue<float3Reactive>(Position);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetPosition(this IEntity obj, out float3Reactive value) => obj.TryGetValue(Position, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddPosition(this IEntity obj, float3Reactive value) => obj.AddValue(Position, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasPosition(this IEntity obj) => obj.HasValue(Position);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelPosition(this IEntity obj) => obj.DelValue(Position);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetPosition(this IEntity obj, float3Reactive value) => obj.SetValue(Position, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternionReactive GetRotation(this IEntity obj) => obj.GetValue<quaternionReactive>(Rotation);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetRotation(this IEntity obj, out quaternionReactive value) => obj.TryGetValue(Rotation, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddRotation(this IEntity obj, quaternionReactive value) => obj.AddValue(Rotation, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasRotation(this IEntity obj) => obj.HasValue(Rotation);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelRotation(this IEntity obj) => obj.DelValue(Rotation);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetRotation(this IEntity obj, quaternionReactive value) => obj.SetValue(Rotation, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveFloat GetAngularSpeed(this IEntity obj) => obj.GetValue<ReactiveFloat>(AngularSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetAngularSpeed(this IEntity obj, out ReactiveFloat value) => obj.TryGetValue(AngularSpeed, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddAngularSpeed(this IEntity obj, ReactiveFloat value) => obj.AddValue(AngularSpeed, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasAngularSpeed(this IEntity obj) => obj.HasValue(AngularSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelAngularSpeed(this IEntity obj) => obj.DelValue(AngularSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetAngularSpeed(this IEntity obj, ReactiveFloat value) => obj.SetValue(AngularSpeed, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CharacterController GetCharacterController(this IEntity obj) => obj.GetValue<CharacterController>(CharacterController);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCharacterController(this IEntity obj, out CharacterController value) => obj.TryGetValue(CharacterController, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCharacterController(this IEntity obj, CharacterController value) => obj.AddValue(CharacterController, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCharacterController(this IEntity obj) => obj.HasValue(CharacterController);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCharacterController(this IEntity obj) => obj.DelValue(CharacterController);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCharacterController(this IEntity obj, CharacterController value) => obj.SetValue(CharacterController, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LayerMask GetLayerMask(this IEntity obj) => obj.GetValue<LayerMask>(LayerMask);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetLayerMask(this IEntity obj, out LayerMask value) => obj.TryGetValue(LayerMask, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddLayerMask(this IEntity obj, LayerMask value) => obj.AddValue(LayerMask, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasLayerMask(this IEntity obj) => obj.HasValue(LayerMask);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelLayerMask(this IEntity obj) => obj.DelValue(LayerMask);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetLayerMask(this IEntity obj, LayerMask value) => obj.SetValue(LayerMask, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Camera GetCamera(this IEntity obj) => obj.GetValue<Camera>(Camera);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCamera(this IEntity obj, out Camera value) => obj.TryGetValue(Camera, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCamera(this IEntity obj, Camera value) => obj.AddValue(Camera, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCamera(this IEntity obj) => obj.HasValue(Camera);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCamera(this IEntity obj) => obj.DelValue(Camera);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCamera(this IEntity obj, Camera value) => obj.SetValue(Camera, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVector3 GetRayHitInfo(this IEntity obj) => obj.GetValue<ReactiveVector3>(RayHitInfo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetRayHitInfo(this IEntity obj, out ReactiveVector3 value) => obj.TryGetValue(RayHitInfo, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddRayHitInfo(this IEntity obj, ReactiveVector3 value) => obj.AddValue(RayHitInfo, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasRayHitInfo(this IEntity obj) => obj.HasValue(RayHitInfo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelRayHitInfo(this IEntity obj) => obj.DelValue(RayHitInfo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetRayHitInfo(this IEntity obj, ReactiveVector3 value) => obj.SetValue(RayHitInfo, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVector2 GetLookingDirection(this IEntity obj) => obj.GetValue<ReactiveVector2>(LookingDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetLookingDirection(this IEntity obj, out ReactiveVector2 value) => obj.TryGetValue(LookingDirection, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddLookingDirection(this IEntity obj, ReactiveVector2 value) => obj.AddValue(LookingDirection, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasLookingDirection(this IEntity obj) => obj.HasValue(LookingDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelLookingDirection(this IEntity obj) => obj.DelValue(LookingDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetLookingDirection(this IEntity obj, ReactiveVector2 value) => obj.SetValue(LookingDirection, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Transform GetAimTransform(this IEntity obj) => obj.GetValue<Transform>(AimTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetAimTransform(this IEntity obj, out Transform value) => obj.TryGetValue(AimTransform, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddAimTransform(this IEntity obj, Transform value) => obj.AddValue(AimTransform, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasAimTransform(this IEntity obj) => obj.HasValue(AimTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelAimTransform(this IEntity obj) => obj.DelValue(AimTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetAimTransform(this IEntity obj, Transform value) => obj.SetValue(AimTransform, value);
    }
}
