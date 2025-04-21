using System.Collections.Generic;
using UnityEngine;

public class ItemData
{

    public static Dictionary<int, ItemInfo> itemDatas = new Dictionary<int, ItemInfo>()
    {
        {
            1,new ItemInfo()
            {
                id = 1,
                name = "JiangHu"
            }
        },
        {  
            2,new ItemInfo()
            {
                id = 2,
                name = "LaZhu"
            }
        },
        {  
            3,new ItemInfo()
            {
                id = 3,
                name = "MianXian"
            }
        },
        {   
            4,new ItemInfo()
            {
                id = 4,
                name = "ZhuZi"
            }
        },
        {    
            5,new ItemInfo()
            {
                id = 5,
                name = "ZhuZhi"
            }
        },
        {    
            6,new ItemInfo()
            {
                id = 6,
                name = "FengGan"
            }
        },
        {    7,new ItemInfo()
            {
                id = 7,
                name = "FuTou"
            }
        },
        {   8,new ItemInfo()
            {
                id = 8,
                name = "XiaoRen"
            }
        },
        {    
            9,new ItemInfo()
            {
                id = 9,
                name = "SuiZi"
            }
        },
        {   
            10,new ItemInfo()
            {
                id = 10,
                name = "Zhi"
            }
        },
        {  
            11,new ItemInfo()
            {
                id = 11,
                name = "YouYvTu"
            }
        },
        {   12,new ItemInfo()
            {
                id = 12,
                name = "HeHua"
            }
        },
        {   13,new ItemInfo()
            {
                id = 13,
                name = "JinBi"
            }
        },
        {
            14,new ItemInfo()
            {
                id = 14,
                name = "KuangJia"
            }
        },
        {
            15,new ItemInfo()
            {
                id = 15,
                name = "BengMian"
            }
        }
    };
    public static ItemInfo GetItemInfo(int id)
    {
        ItemInfo info = itemDatas[id];
        return info;
    }

    public static Sprite GetItemSprite(int id)
    {
        return Resources.Load<Sprite>($"Cargo_{id}");
        
    }
}
