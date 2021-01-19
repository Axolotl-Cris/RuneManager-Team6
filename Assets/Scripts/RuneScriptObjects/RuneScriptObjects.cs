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
        public int changeAmount; //First change this one to how many of this Rune you want to Add or Subtract.
        public int amount
        {
            get => PlayerPrefs.GetInt(this.name, 0);
            set
            {
                PlayerPrefs.SetInt(this.name, value);

            }
        }
        public void Added() //Then call this funktion to Add
        {
            this.amount += this.changeAmount;
        }
        public void Consumed() //Or this this funktion to Subtract
        {
            this.amount += this.changeAmount;
        }
    }
}