using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Page : MonoBehaviour
{
    [SerializeField] GameObject firstSelectedButton = null;
    GameObject lastSelectedButton = null;
    private void Awake()
    {
        //have to be in awake as instance need to run functions in same frame
        gameObject.SetActive(false);
    }
    public void SelectFirstButton()
    {
        if (firstSelectedButton == null)
            return;
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(firstSelectedButton);
    }
    public void SelectLastButton()
    {
        if (lastSelectedButton == null)
            return;
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(lastSelectedButton);
    }
    public void InitPage()
    {
        SelectFirstButton();
    }
    public void SetLastSelectedButton(GameObject button)
    {
        lastSelectedButton = button;
    }
}
