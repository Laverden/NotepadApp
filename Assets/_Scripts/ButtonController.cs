using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public GameObject textArea;
    public GameObject quitPanel;
    public AudioSource clearSound;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Initializing the ButtonController...");
    }

    // Clears the whole notepad input field.
    public void ClearText()
    {
        textArea.GetComponent<InputField>().text = "";
        clearSound.Play();
    }

    // Hides the Quit Panel.
    public void QuitPanelCancel()
    {
        quitPanel.SetActive(false);
    }

    // Shows the Quit Panel with before-close options.
    public void QuitPanelShow()
    {
        quitPanel.SetActive(true);
    }

    public void QuitApplication()
    {
        Debug.LogWarning("Quitting the app");
        Application.Quit();
    }
}
