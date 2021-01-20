using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Rune", menuName = "Common/Uncommon/Rare/Epic/Legendary Rune")]
public class Rune : ScriptableObject
{
    public new string name;
    public string icon;
    public Sprite artwork;
    public string rarity;


}

