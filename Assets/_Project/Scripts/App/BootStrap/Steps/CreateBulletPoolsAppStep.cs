using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using GamePlay;
using JetBrains.Annotations;

namespace App
{
    [UsedImplicitly]
    public sealed class CreateBulletPoolsAppStep : AppStepBase, IDisposable
    {
        private readonly IBulletFactory _bulletFactory;
        private const int ID  = 2;
        
        private CancellationTokenSource _tokenSource;
        
        public CreateBulletPoolsAppStep(IBulletFactory bulletFactory, AppStepConfiguration stepConfiguration)
        {
            _bulletFactory = bulletFactory;
            var config = stepConfiguration.GetConfig(ID);
            Id = ID;
            Title = config.TitleText;
            Duration = config.Duration; 
        }
        
        public override async UniTask WaitOnCompleted()
        {
            _tokenSource = new CancellationTokenSource();
            
            var taskList = new List<UniTask>
            {
                 UniTask.Delay((int)(Duration * 1000)),
                 _bulletFactory.CreatePoolsAsync()
            };
            
            await UniTask.WhenAll(taskList).AttachExternalCancellation(_tokenSource.Token);
        }
        
        public void Dispose()
        {
            _tokenSource?.Cancel();
            _tokenSource?.Dispose();
        }
    }
}