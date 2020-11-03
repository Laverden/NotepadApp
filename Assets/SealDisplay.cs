using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SealDisplay : MonoBehaviour
{
    public SealTag sealTag;

    public Text sealName;
    public Image sealCategoryIcon;
    public Image sealTemplate;
    // Start is called before the first frame update
    void Start()
    {
        sealName.text = sealTag.sealName;
        sealCategoryIcon.sprite = sealTag.sealCategory;
        sealTemplate.color = sealTag.sealColor;
    }

}
