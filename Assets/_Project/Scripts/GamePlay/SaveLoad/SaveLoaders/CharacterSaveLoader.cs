using Atomic.Entities;
using JetBrains.Annotations;
using SaveLoad;
using UnityEngine;

namespace GamePlay
{
    [UsedImplicitly]
    public sealed class CharacterSaveLoader : SaveLoader<CharacterData, IEntity>
    {
        public CharacterSaveLoader(GameDataStorage gameDataStorage, IEntity entity) 
            : base(gameDataStorage, entity) { }
    
        protected override CharacterData ConvertToData(IEntity entity)
        {
           var position = entity.GetTransform().position;
           var health = entity.GetHealth().Value;

           return new CharacterData(position.x, position.y, position.z, health);
        }
    
        protected override void SetUpData(CharacterData data, IEntity entity)
        {
            var position = new Vector3(data.PosX, data.PosY, data.PosZ);
            if(position == Vector3.zero)
                return;
            
            entity.GetTransform().position = position;
            entity.GetHealth().Value = data.Health;
        }
    }
}