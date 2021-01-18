using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runes
{
    [CreateAssetMenu]
    public class RuneScriptObjects : ScriptableObject
    {
        public Color color;
        public int rarity; // Might be need to made into sepret Tears of the Script Object.
        //WIP Move along
        
        public int ammount
        {
            get => PlayerPrefs.GetInt(this.name, 0);
            set
            {
                PlayerPrefs.SetInt(this.name, value);

            }
        }
        

    }
}