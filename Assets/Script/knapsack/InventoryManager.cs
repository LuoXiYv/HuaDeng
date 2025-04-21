using System.Collections.Generic;

public class InventoryManager
{
    public static Dictionary<int,InventoryItem> items = new Dictionary<int, InventoryItem>();


    public static void AddItem(InventoryItem item)
    {
        if (items.ContainsKey(item.id))
        {
            items[item.id].count += item.count;
        }
        else
        {
            items.Add(item.id,item);
        }
    }

    public static void RemoveItem(InventoryItem item)
    {
        if (items.ContainsKey(item.id))
        {
            items.Remove(item.id);
        }
        else
        {
            return;
        }
    }

    public static void UseItem(InventoryItem item)
    {
        
    }
}
