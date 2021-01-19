using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    [CreateAssetMenu(fileName = "New Rune", menuName = "Scriptable Object: Runes")]
    public class RuneScriptObjects : ScriptableObject
    {
        //public int rarity; 
        // Not in use until I can be sure that the same SO can have different of the same thing (Which I highly think is likeble).
        // Use the rarity tear list instead of the SO tear list.
        // You can find it under "Raritys"

        // WIP Move along
        public new string name;
        public Color color;
        public int changeAmount; //First change this one to how many of this Rune you want to Add or Subtract.
        public Image sprite;
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
        public void Subtract() //Or this this funktion to Subtract
        {
            this.amount -= this.changeAmount;
        }
        public void PrintTest()
        {
            Debug.Log("Name " + name);
            Debug.Log("Current Amount " + amount);
            Debug.Log("Colour " + color);
        }
    }
