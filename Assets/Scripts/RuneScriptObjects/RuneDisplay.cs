using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RuneDisplay : MonoBehaviour
{
    // Place this in an Emptyobject then place the Rune you want to check in the RuneSO slot.
    public RuneScriptObjects runeSO;
    void Start()
    {
        runeSO.PrintTest();
    // It will on start call this function (See RuneScriptObjects.cs) and give the name + the amount of the selected rune that is in the runeSO slot.
    }
}
