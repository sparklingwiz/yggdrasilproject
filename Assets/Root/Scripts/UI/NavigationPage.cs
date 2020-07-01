using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NavigationPage
{
    Stack<Page> uiStack = new Stack<Page>();
    public int GetPageCount()
    {
        return uiStack.Count;
    }
    public void PushPage(Page page)
    {
        //current page set last selected button
        //push new page
        if (uiStack.Count > 0)
        {
            Page currPage = uiStack.Peek();
            GameObject lastSelectedButton = EventSystem.current.currentSelectedGameObject;
            currPage.SetLastSelectedButton(lastSelectedButton);
        }
        
        uiStack.Push(page);
        page.gameObject.SetActive(true);
        page.InitPage();
    }
    public void PopPage()
    {
        //disable popped page
        //current page select last selected button
        Page page = uiStack.Pop();
        page.gameObject.SetActive(false);

        Page currPage = uiStack.Peek();
        currPage.SelectLastButton();
    }
    public void PopAllPage()
    {
        while(uiStack.Count > 0)
        {
            Page page = uiStack.Pop();
            page.gameObject.SetActive(false);
        }
    }
}
