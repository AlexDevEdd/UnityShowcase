using Atomic.Entities;
using GameCycle;
using UnityEngine;

namespace GamePlay
{
    [AddComponentMenu("Atomic/Entities/Entity World Cycle")]
    [DefaultExecutionOrder(-1000)]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(SceneEntityWorld))]
    public class SceneEntityWorldCycle : MonoBehaviour, ITick, IFixedTick, ILateTick
    {
        private SceneEntityWorld _world;
        private bool _isStarted;
        
        private void Awake()
        {
            _world = GetComponent<SceneEntityWorld>();
        }

        private void OnEnable()
        {
            if (_isStarted) 
                _world.EnableEntities();
        }

        private void Start()
        {
            _world.InitEntities();
            _world.EnableEntities();
            _isStarted = true;
        }

        public void Tick(float delta)
        {
            _world.UpdateEntities(Time.deltaTime);
        }

        public void FixedTick(float fixedDelta)
        {
            _world.FixedUpdateEntities(Time.fixedDeltaTime);
        }

        public void LateTick(float delta)
        {
            _world.LateUpdateEntities(Time.fixedDeltaTime);
        }
        
        private void OnDisable()
        {
            if (_isStarted) 
                _world.DisableEntities();
        }

        private void OnDestroy()
        {
            if (_isStarted) 
                _world.DisposeEntities();
        }
    }
}