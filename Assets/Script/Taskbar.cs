using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Taskbar : MonoBehaviour
{
  public TextMeshProUGUI text;
  public TextMeshProUGUI text1;
  public GameObject img;

  LinkedList<string> tasks = new LinkedList<string>();

  private void Start()
  {
    tasks.AddLast("前往 郊外-绿玉君亭 获取材料-竹片");
    tasks.AddLast("前往 荣记七宝铺 购买蜡烛、棉线与浆糊");
    tasks.AddLast("前往 陈生的作坊 加工材料");
    tasks.AddLast("前往 烟雨南街 与邻里交谈");
    tasks.AddLast("前往 跨虹桥 参加上元灯会");

    UpdateTaskbar();
  }

  private void Update()
  {
    if (InventoryManager.items[4].count != 0)
    {
        tasks.Remove("前往 郊外-绿玉君亭 获取材料-竹片");
        UpdateTaskbar();
    }
    else if (Cargo.cr3 && Cargo.cr2)
    {
      tasks.Remove("前往 荣记七宝铺 购买蜡烛、棉线与浆糊");
      UpdateTaskbar();
    }
    else if (InventoryManager.items[6].count != 0 )
    {
      tasks.Remove("前往 陈生的作坊 加工材料");
      UpdateTaskbar();
    }
    else if (TextPlay.get1 && TextPlay.get2 && TextPlay.get3 && TextPlay.get4 && TextPlay.get5)
    {
      tasks.Remove("前往 烟雨南街 与邻里交谈");
      UpdateTaskbar();
    }
  }

  private void UpdateTaskbar()
  {
    string task1 = tasks.Count > 0 ? tasks.First.Value : "没有更多任务";
    string task2 = tasks.Count > 1 ? tasks.First.Next.Value : "没有更多任务";

    text.text = "任务1: " + task1;
    text1.text = "任务2: " + task2;
  }
}
