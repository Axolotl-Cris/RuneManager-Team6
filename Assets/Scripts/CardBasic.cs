using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Rune", menuName = "Common/Uncommon/Rare/Epic/Legendary Rune")]
public class Rune : ScriptableObject
{
    public new string Name;
    public string Icon;
    public Sprite Artwork;
    public string Rarity;


}

