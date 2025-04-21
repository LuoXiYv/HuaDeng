using UnityEngine;

public class Knapsack : MonoBehaviour
{
    private bool isOpen = false;
    [SerializeField] private GameObject knapsack;
    void Start()
    {
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 1,
            count = 0
        });
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 2,
            count = 0
        });
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 3,
            count = 0
        });
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 4,
            count = 0
        });
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 5,
            count = 0
        });
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 6,
            count = 0
        });
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 7,
            count = 0
        });
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 8,
            count = 0
        });
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 9,
            count = 0
        });
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 10,
            count = 0
        });
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 11,
            count = 0
        });
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 12,
            count = 0
        });
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 13,
            count = 0
        });
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 14,
            count = 0
        });
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 15,
            count = 0
        });
        InventoryManagerUI.instance.UpdateUIDisplay();
        knapsack.SetActive(true);
        knapsack.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OpenKnapsack()
    {
        knapsack.SetActive(true);
        isOpen = true;
        InventoryManagerUI.instance.UpdateUIDisplay();
    }

     void CloseKnapsack()
    {
        knapsack.SetActive(false);
        isOpen = false;
    }

     public void ButtonClick()
     {
         if (!isOpen)
         {
             OpenKnapsack();
         }
         else
         {
             CloseKnapsack();
         }
     }
}
