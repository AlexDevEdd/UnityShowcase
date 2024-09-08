using Cysharp.Threading.Tasks;

namespace App
{
    public interface IAppStep
    {
        public int Id { get; }
        public string Title { get; }
        public float Duration { get; }
        public UniTask WaitOnCompleted();
    }
}