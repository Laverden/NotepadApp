using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(IOController))]
public class TabGroup : MonoBehaviour
{
    public IOController iOController;
    public List<TabButton> tabButtons;
    public List<GameObject> pagesToSwap;
    public float tabIdle;
    public float tabActive;
    public Color tabHover;
    public TabButton selectedTab;

    public void Start()
    {
        if (selectedTab != null)
        {
            OnTabSelected(selectedTab);
        }
        else
        {
            OnTabSelected(tabButtons[0]);
        }

    }

    public void Subscribe(TabButton button)
    {
        if (tabButtons == null)
        {
            tabButtons = new List<TabButton>();
        }

        tabButtons.Add(button);

        int index = button.transform.GetSiblingIndex();
        iOController.LoadNote(index);
    }

    public void OnTabEnter(TabButton button)
    {
        //ResetTabs();
        //button.background.color = tabHover;
    }

    public void OnTabExit(TabButton button)
    {
        ResetTabs();
    }

    public void OnTabSelected(TabButton button)
    {
        selectedTab = button;

        ResetTabs();

        Color buttonColor = button.defaultColor;
        buttonColor.a = tabActive;
        button.background.color = buttonColor;

        int index = button.transform.GetSiblingIndex();
        for (int i=0; i < pagesToSwap.Count; i++)
        {
            if (i == index)
            {
                pagesToSwap[i].SetActive(true);
            }
            else
            {
                pagesToSwap[i].SetActive(false);
            }
        }

    }

    public void ResetTabs()
    {
        foreach(TabButton button in tabButtons)
        {
            if (selectedTab != null && button == selectedTab) { continue;  }

            Color buttonColor = button.defaultColor;
            buttonColor.a = tabIdle;
            button.background.color = buttonColor;
        }
    }

    public TabButton GetSelectedTab()
    {
        return selectedTab;
    }
}
