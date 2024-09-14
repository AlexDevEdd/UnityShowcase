using System;
using UnityEngine;

namespace GamePlay
{
    public interface IInput : IMoveInput, IAimInput, IFireInput, IRunInput, ISwitchWeaponInput { }
    
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
    
    public interface IRunInput
    { 
        public event Action<bool> OnRunEvent;
    }
    
    public interface ISwitchWeaponInput
    { 
        public event Action<int> OnWeaponChanged;
    }
    
}