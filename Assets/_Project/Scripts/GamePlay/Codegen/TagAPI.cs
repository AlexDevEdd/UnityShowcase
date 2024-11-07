/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Entities;

namespace Atomic.Entities
{
    public static class TagAPI
    {
        ///Keys
        public const int Character = 1;
        public const int Weapon = 2;
        public const int Enemy = 3;


        ///Extensions
        public static bool HasCharacterTag(this IEntity obj) => obj.HasTag(Character);
        public static bool AddCharacterTag(this IEntity obj) => obj.AddTag(Character);
        public static bool DelCharacterTag(this IEntity obj) => obj.DelTag(Character);

        public static bool HasWeaponTag(this IEntity obj) => obj.HasTag(Weapon);
        public static bool AddWeaponTag(this IEntity obj) => obj.AddTag(Weapon);
        public static bool DelWeaponTag(this IEntity obj) => obj.DelTag(Weapon);

        public static bool HasEnemyTag(this IEntity obj) => obj.HasTag(Enemy);
        public static bool AddEnemyTag(this IEntity obj) => obj.AddTag(Enemy);
        public static bool DelEnemyTag(this IEntity obj) => obj.DelTag(Enemy);
    }
}
