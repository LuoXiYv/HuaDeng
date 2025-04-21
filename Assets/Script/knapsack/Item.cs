/// <summary>
/// 物品在背包内信息
/// </summary>
public class InventoryItem
{
    public int id = 0;
    public int count = 0;
    public bool isselected = false;
}

/// <summary>
/// 物品固有信息
/// </summary>
public class ItemInfo
{
    public string name;
    public int id;
    public int count = 0;
}