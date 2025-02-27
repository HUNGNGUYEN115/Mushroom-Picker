using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="NewMushroom",menuName ="Mushroom/NewMushroom")]
public class MushroomData : ScriptableObject
{
    public string mushroomname;
    public string mushroominfor;
    public Sprite image; 
    public Type mushroomtype;
}
public enum Type { edible, poisonous }
