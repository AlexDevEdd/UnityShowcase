using Cysharp.Threading.Tasks;

namespace App
{
    public abstract class AppStepBase : IAppStep
    {
        public int Id { get; protected set; }
        public string Title { get; protected set; }
        public float Duration { get; protected set; }
        public abstract UniTask WaitOnCompleted();
    }
}