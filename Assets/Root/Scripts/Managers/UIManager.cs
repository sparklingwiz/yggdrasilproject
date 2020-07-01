using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class UIManager : MonoBehaviour
{
    [SerializeField] InventoryUI inventoryUIPrefab;
    InventoryUI currInventoryUI;
    private void Start()
    {
        Assert.IsNotNull(inventoryUIPrefab);
    }
    public void OpenInventory()
    {
        if(currInventoryUI == null)
        {
            currInventoryUI = Instantiate(inventoryUIPrefab);
        }
        currInventoryUI.ToggleInventory();
    }
}