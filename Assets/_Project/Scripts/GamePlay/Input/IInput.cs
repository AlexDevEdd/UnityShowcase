using System;
using UnityEngine;

namespace GamePlay
{
    public interface IInput : IMoveInput, IAimInput
    {
        
    }
    
    public interface IMoveInput
    {
        public event Action<Vector2> OnMoveEvent;
    }
    
    public interface IAimInput
    {
        public event Action<Vector2> OnAimEvent;
    }
    
}