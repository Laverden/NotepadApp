using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Sealtag", menuName = "Seal")]
public class SealTag : ScriptableObject
{
    public string sealName;

    public Color sealColor;
    public Sprite sealCategory;
}
