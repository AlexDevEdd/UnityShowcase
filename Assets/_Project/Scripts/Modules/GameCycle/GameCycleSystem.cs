using System.Linq;
using JetBrains.Annotations;

namespace GameCycle
{
    [UsedImplicitly]
    public class GameCycleSystem
    {
        private readonly IGameStart[] _startListeners;
        private readonly IGamePause[] _pauseListener;
        private readonly IGameResume[] _resumeListeners;
        private readonly IGameFinish[] _finishListeners;

        //private readonly ITick[] _updates;
       // private readonly IFixedTick[] _fixedUpdates;
       
        public GameState GameState { get; private set; }
        
        public GameCycleSystem(IGameListener[] listeners) 
        {
            _startListeners = listeners.OfType<IGameStart>().ToArray();
            _pauseListener = listeners.OfType<IGamePause>().ToArray();
            _resumeListeners = listeners.OfType<IGameResume>().ToArray();
            _finishListeners = listeners.OfType<IGameFinish>().ToArray();
            //_updates = listeners.OfType<ITick>().ToArray();
            //_fixedUpdates = listeners.OfType<IFixedTick>().ToArray();
        }
        
        public void OnStartEvent()
        {
            if (GameState != GameState.None)
                return;

            ChangeState(GameState.Start);

            for (int i = 0; i < _startListeners.Length; i++)
                _startListeners[i].OnStart();

            ChangeState(GameState.GameLoop);
        }

        public void OnPauseEvent()
        {
            if (GameState != GameState.GameLoop)
                return;

            ChangeState(GameState.Pause);

            for (int i = 0; i < _pauseListener.Length; i++)
                _pauseListener[i].OnPause();
        }

        public void OnResumeEvent()
        {
            if (GameState != GameState.Pause)
                return;

            ChangeState(GameState.GameLoop);

            for (int i = 0; i < _resumeListeners.Length; i++)
                _resumeListeners[i].OnResume();
        }
        
        // public void Tick()
        // {
        //     if (IsPaused()) return;
        //     for (int i = 0; i < _updates.Length; i++)
        //         _updates[i].Tick(Time.deltaTime);
        // }
        //
        // public void FixedTick()
        // {
        //     if (IsPaused()) return;
        //     for (int i = 0; i < _fixedUpdates.Length; i++)
        //         _fixedUpdates[i].FixedTick(Time.fixedDeltaTime);
        // }
        
        public void OnFinish()
        {
            if (GameState is GameState.Finish or GameState.None or GameState.Start)
                return;

            ChangeState(GameState.Finish);
            foreach (var listener in _finishListeners)
                listener.OnFinish();
        }

        public bool IsPaused()
            => GameState != GameState.GameLoop;

        private void ChangeState(GameState state)
        {
            if (Equals(GameState, state)) return;
            GameState = state;
        }
        
        public void Dispose()
            => OnFinish();
    }
}