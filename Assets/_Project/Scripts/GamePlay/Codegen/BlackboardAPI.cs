/**
* Code generation. Don't modify! 
 */
using System.Runtime.CompilerServices;
using Atomic.AI;
using GamePlay;
using UnityEngine;
using Atomic.Entities;
using Unity.Mathematics;
namespace Atomic.AI
{
    public static class BlackboardAPI
    {
        public const int CollidersBuffer = 1; // BufferData<Collider> : struct
        public const int SphereSensorData = 2; // SphereSensorData : struct
        public const int Target = 3; // IEntity : class
        public const int MovePosition = 4; // float3
        public const int StoppingDistance = 5; // float
        public const int AttackData = 6; // AttackData : struct
        public const int PatrolData = 7; // PatrolData : struct
        public const int Self = 8; // IEntity : class


        ///Extensions
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCollidersBuffer(this IBlackboard obj) => obj.HasStruct(CollidersBuffer);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref BufferData<Collider>  GetCollidersBuffer(this IBlackboard obj) => ref obj.GetStruct<BufferData<Collider> >(CollidersBuffer);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCollidersBuffer(this IBlackboard obj, out Ref<BufferData<Collider> > value) => obj.TryGetStruct(CollidersBuffer, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCollidersBuffer(this IBlackboard obj, BufferData<Collider>  value) => obj.SetStruct(CollidersBuffer, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCollidersBuffer(this IBlackboard obj) => obj.DelObject(CollidersBuffer);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasSphereSensorData(this IBlackboard obj) => obj.HasStruct(SphereSensorData);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref SphereSensorData  GetSphereSensorData(this IBlackboard obj) => ref obj.GetStruct<SphereSensorData >(SphereSensorData);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetSphereSensorData(this IBlackboard obj, out Ref<SphereSensorData > value) => obj.TryGetStruct(SphereSensorData, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetSphereSensorData(this IBlackboard obj, SphereSensorData  value) => obj.SetStruct(SphereSensorData, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelSphereSensorData(this IBlackboard obj) => obj.DelObject(SphereSensorData);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTarget(this IBlackboard obj) => obj.HasObject(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEntity  GetTarget(this IBlackboard obj) => obj.GetObject<IEntity >(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTarget(this IBlackboard obj, out IEntity  value) => obj.TryGetObject(Target, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTarget(this IBlackboard obj, IEntity  value) => obj.SetObject(Target, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTarget(this IBlackboard obj) => obj.DelObject(Target);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMovePosition(this IBlackboard obj) => obj.HasFloat3(MovePosition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 GetMovePosition(this IBlackboard obj) => obj.GetFloat3(MovePosition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMovePosition(this IBlackboard obj, out float3 value) => obj.TryGetFloat3(MovePosition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMovePosition(this IBlackboard obj, float3 value) => obj.SetFloat3(MovePosition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMovePosition(this IBlackboard obj) => obj.DelFloat3(MovePosition);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasStoppingDistance(this IBlackboard obj) => obj.HasFloat(StoppingDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetStoppingDistance(this IBlackboard obj) => obj.GetFloat(StoppingDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetStoppingDistance(this IBlackboard obj, out float value) => obj.TryGetFloat(StoppingDistance, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetStoppingDistance(this IBlackboard obj, float value) => obj.SetFloat(StoppingDistance, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelStoppingDistance(this IBlackboard obj) => obj.DelFloat(StoppingDistance);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackData(this IBlackboard obj) => obj.HasStruct(AttackData);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref AttackData  GetAttackData(this IBlackboard obj) => ref obj.GetStruct<AttackData >(AttackData);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackData(this IBlackboard obj, out Ref<AttackData > value) => obj.TryGetStruct(AttackData, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackData(this IBlackboard obj, AttackData  value) => obj.SetStruct(AttackData, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackData(this IBlackboard obj) => obj.DelObject(AttackData);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPatrolData(this IBlackboard obj) => obj.HasStruct(PatrolData);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref PatrolData  GetPatrolData(this IBlackboard obj) => ref obj.GetStruct<PatrolData >(PatrolData);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPatrolData(this IBlackboard obj, out Ref<PatrolData > value) => obj.TryGetStruct(PatrolData, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPatrolData(this IBlackboard obj, PatrolData  value) => obj.SetStruct(PatrolData, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPatrolData(this IBlackboard obj) => obj.DelObject(PatrolData);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasSelf(this IBlackboard obj) => obj.HasObject(Self);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEntity  GetSelf(this IBlackboard obj) => obj.GetObject<IEntity >(Self);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetSelf(this IBlackboard obj, out IEntity  value) => obj.TryGetObject(Self, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetSelf(this IBlackboard obj, IEntity  value) => obj.SetObject(Self, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelSelf(this IBlackboard obj) => obj.DelObject(Self);

    }
}
