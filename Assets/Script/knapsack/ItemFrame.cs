using System;
using TMPro;
using SKCell;
using UnityEngine;
using UnityEngine.UI;

public class ItemFrame : MonoBehaviour
{
    private InventoryItem item;

    private float hightLigthA = 1f;
    private int x = 0;
    [SerializeField]  CanvasGroup hightLight;
    [SerializeField]  Image itemIconImage;
    [SerializeField]  TextMeshProUGUI itemCountText;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            x = (x+1) % 13;
            InventoryManagerUI.instance.OnClickItemFrame(x);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            x -= 1;
            if (x < 0)
            {
                x = 13;
            }
            InventoryManagerUI.instance.OnClickItemFrame(x);
        }
        
    }

    public void SetInventoryItem(InventoryItem item)
    {
        this.item = item;
    }

    public InventoryItem GetInventoryItem()
    {
        return this.item;
    }
    
    public void UpdateInfo()
    {
        itemIconImage.sprite = ItemData.GetItemSprite(item.id);
        itemCountText.text = item.count.ToString();
    }

    public void OnSelected()
    {
        this.item.isselected = true;
        hightLight.alpha = hightLigthA;
    }

    public void OnDeselect()
    {
        this.item.isselected = false;
        hightLight.alpha = 0f;
    }
}
