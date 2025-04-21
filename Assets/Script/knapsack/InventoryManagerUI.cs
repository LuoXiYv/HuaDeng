using System;
using System.Collections.Generic;
using UnityEngine;
using SKCell;

public class InventoryManagerUI : SKMonoSingleton<InventoryManagerUI>
{
    
    [SerializeField] GameObject itemFramePF;
    [SerializeField] Transform Grid;
    [SerializeField]  GameObject Knapsack;
    [SerializeField]   List<ItemFrame>IF;
    private ItemFrame selectedItemFrame;
    

    public void UpdateUIDisplay()
    {
        Grid.ClearChildren();
        IF.Clear();
        foreach (InventoryItem item in InventoryManager.items.Values)
        {
            ItemFrame frame = Instantiate(itemFramePF, Grid).GetComponent<ItemFrame>();
            frame.SetInventoryItem(item);
            frame.UpdateInfo();
            IF.Add(frame);
        }
    }

    public void OnClickItemFrame(int x)
    {
        if (selectedItemFrame != null)
        {
            selectedItemFrame.OnDeselect();
        }
        selectedItemFrame = IF[x];
        selectedItemFrame.OnSelected();
    }

    private void Update()
    {
        if ((StatusBarCL.open || StatuBarWS.open || StatuBarS.open))
        { 
            Knapsack.SetActive(true);
        }
        else if (!(StatusBarCL.open || StatuBarWS.open || StatuBarS.open))
        {
            Knapsack.SetActive(false);
        }
    }
}
