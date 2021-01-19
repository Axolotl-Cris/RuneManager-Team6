using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
namespace Runes
{
*/
    public class RuneMerger : MonoBehaviour
    {
        //Runes selected ´ro be merged
        public List<RuneScriptObjects> SelectedObjects = new List<RuneScriptObjects>();

        public void Merge()
        {
            int RandomNumber = Random.Range(1, 100);

            //TODO: Check selected objetc amount
            //Check if runes are of same rarity
            //Check if number is within Merge Range
            //Return random rune

        }
    }
//}