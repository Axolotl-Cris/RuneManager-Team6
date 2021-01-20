﻿using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class RunePurchase : MonoBehaviour
{
    /* MARC SAID: You somehow need to be provided a Collection of all possible Runes.
       Whoever is responsible to do that.
       Maybe, you have a ScriptableObject that links all Runes?
       And then, you can do Random.Range(0, allRunes.Length) and pick that rune and increase it by one:
       allRunes[Random.Range(0, allRunes.Length)].Added();
       That should be all*/
    
    public Button purchaseButton;
    public RuneScriptObjects[] allRunes;
    private int maxAmountofCommonRunes = 4;
    public void PurchaseRune()
    {
        for (var i = 0; i < maxAmountofCommonRunes; i++)
        {
            allRunes[Random.Range(0, allRunes.Length)].Added();
            Debug.Log("You got the runes named: " + allRunes[Random.Range(0, allRunes.Length)]);
        }
    }

    private void Start()
    {
        purchaseButton.onClick.AddListener(PurchaseRune);
    }
}