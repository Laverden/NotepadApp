using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextLocalizerUI : MonoBehaviour
{
    Text textField;

    public LocalizedString localizedString;

    // Start is called before the first frame update
    void Start()
    {
        textField = GetComponent<Text>();
        textField.text = localizedString.value;
    }
}
