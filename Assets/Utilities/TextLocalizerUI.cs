using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextLocalizerUI : MonoBehaviour
{
    Text textField;

    public string key;

    // Start is called before the first frame update
    void Start()
    {
        textField = GetComponent<Text>();
        string value = LocalizationSystem.GetLocalizedValue(key);
        textField.text = value;
    }
}
