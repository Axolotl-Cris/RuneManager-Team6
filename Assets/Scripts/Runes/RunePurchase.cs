using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunePurchase : MonoBehaviour
{
    // Some ideas, still unsure on how to add the Purchase functionality to PurchaseButton...
    // When OnClick, 4 random scriptable objects -runes- should appear, don't know how to do it, yet.
    public RuneScriptObjects[] runeList = new RuneScriptObjects[15];
   
       public void PurchaseRune(RuneScriptObjects rune)
       {
           for (int i = 0; i < runeList.Length; i++)
           {
               if (runeList[i] == null)
               {
                   runeList[i] = rune;
                   return;
               }
           }
       }
}
