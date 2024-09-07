namespace Modules.GameCycle
{
    public interface IGameListener { }
    
    internal interface IGameFinish : IGameListener
    {
        void OnFinish();
    }
    
    internal interface IGamePause : IGameListener
    {
        void OnPause();
    }
    
    internal interface IGameResume : IGameListener
    {
        void OnResume();
    }
    
    internal interface IGameStart : IGameListener
    {
        void OnStart();
    }

    internal interface ITick : IGameListener
    {
        void Tick(float delta);
    }
    
    internal interface IFixedTick : IGameListener
    {
        void FixedTick(float fixedDelta);
    }
    
    internal interface ILateTick : IGameListener
    {
        void LateTick(float delta);
    }
}