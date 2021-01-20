using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "New Rune"/*Default name when creating a new SO */, menuName = "Scriptable Object: Runes")] 
// This is the Location of the SO if you press RMB in the Unity.
// Everytime you make a SO they will be diffrent. A example is think it as that think it as a Model Clay. 
// It has set properties and then you form it into what you want it to be. It still the same clay tho it is 2 different sculptures.

public class RuneScriptObjects : ScriptableObject
{
    public new string name; //This is name that you give to the SO. NOT the name of the File itself. 
    // For example:
    // The file can be named R001 shorten of "Rune number 001". 
    // But the name of the rune itself when it is displayed in the game is "Common Red Rune".
    // This is becaue of that you call "name" insted of the file name to display in the game.
    
    public Color color;
    // Choose the color that you want for the Rune then in the Game call this to have it pick what color it should use and display that.
    
    public int changeAmount = 1;
    // This is what you call if you want to change the amount of how many that should be added or subtracted.
    // Example:
    // I have selected 4 of the same runes to be merged then after they are merged I want to delete them.
    // So I first call this one to change the amount that I want to be subtracted to 4.
    // Then calling the ["Subtract()"] (See below on line) to to remove set a rune.

    public Sprite icon;
    // The selector in the inspector what sprite should be binded to this specific SO.
    
    public int rarity = 0;
    // Use the rarity tear list instead of the SO tear list.
    // This one is more to make it easier to read what rarity it is. You shouldn't need to edit or change this one.
    // Just call it if you want to know what rarity it has, not to blend or confuse yourself of what rune it is.

    public int amount
    // This is the amount for the set rune. So if you have a Blue, Red runes and they are named ["name"] to be Red and Blue.
    // They will be saved as two different "PlayerPrefs" (One of the save system Unity has). 
    // This lets you have two runes with two different amounts.
    {
        get => PlayerPrefs.GetInt(this.name, 0);
        set
        {
            PlayerPrefs.SetInt(this.name, value);
        }
    }

    public void Added() 
        //Call this funktion to Add to the amount of how many the player has of this rune.
    {
        this.amount += this.changeAmount;
    }
    public void Subtract() 
        //Or this this funktion to Subtract from amount of how many the player has of this rune.
    {
        this.amount -= this.changeAmount;
    }

    public void PrintTest()
        // This is just a test function call this one if you want to see in the console the Name and the Amount of the selected Rune.
    {
        Debug.Log("Name " + name);
        Debug.Log("Current Amount " + amount);
    }

    //public void DisplayRuneIcon()
    //{
    //    
    //}
    
}
