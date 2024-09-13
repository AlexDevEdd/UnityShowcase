using System;
using UnityEngine;

namespace GamePlay
{
    public interface IInput : IMoveInput, IAimInput, IFireInput { }
    
    public interface IMoveInput
    {
        public event Action<Vector2> OnMoveEvent;
    }
    
    public interface IAimInput
    {
        public event Action<Vector2> OnAimEvent;
    }
    
    public interface IFireInput
    {
        public event Action OnFireEvent;
    }
    
}