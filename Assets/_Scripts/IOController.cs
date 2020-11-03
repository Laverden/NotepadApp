using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IOController : MonoBehaviour
{
    public string textContent;
    public GameObject note;
    public GameObject textArea;
    public GameObject savedToastAnimation;
    public TabGroup tabGroup;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Initializing the IOController...");
    }

    public void SaveNote()
    {
        TabButton selectedTab = tabGroup.GetSelectedTab();
        int selectedIndex = selectedTab.transform.GetSiblingIndex();

        textContent = tabGroup.pagesToSwap[selectedIndex].GetComponentsInChildren<Text>()[1].text;

        PlayerPrefs.SetString("NoteContents" + selectedIndex, textContent);
        StartCoroutine(SaveNoteToast());
    }

    public void LoadNote(int index)
    {
        textContent = PlayerPrefs.GetString("NoteContents" + index);
        textArea = tabGroup.pagesToSwap[index];
        textArea.GetComponent<InputField>().text = textContent;
    }

    IEnumerator SaveNoteToast()
    {
        savedToastAnimation.GetComponent<Animator>().Play("SavedToast");
        yield return new WaitForSeconds(1);
        savedToastAnimation.GetComponent<Animator>().Play("Sleep");
    }

}
