using System;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public readonly struct CharacterData
    {
        public readonly float PosX;
        public readonly float PosY;
        public readonly float PosZ;
        public readonly float Health;

        public CharacterData(float posX, float posY, float posZ, float health)
        {
            PosX = posX;
            PosY = posY;
            PosZ = posZ;
            Health = health;
        }
    }
}