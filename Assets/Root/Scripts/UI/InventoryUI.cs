using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] Page mainPage = null;
    NavigationPage navigationPage;

    public delegate void OnAllPagesPoppedHandler();
    public OnAllPagesPoppedHandler OnAllPagesPopped;
    private void Awake()
    {
        //have to be in awake as instance need to run functions in same frame
        navigationPage = new NavigationPage();

        Assert.IsNotNull(mainPage);
    }
    public void ToggleInventory()
    {
        if (navigationPage.GetPageCount() > 0)
        {
            navigationPage.PopAllPage();
            OnAllPagesPopped?.Invoke();
        }
        else
        {
            navigationPage.PushPage(mainPage);
        }
    }
    public void PopPage()
    {
        navigationPage.PopPage();
        if(navigationPage.GetPageCount() <= 0)
        {
            OnAllPagesPopped?.Invoke();
        }
    }
    public void PushPage(Page page)
    {
        navigationPage.PushPage(page);
    }
}