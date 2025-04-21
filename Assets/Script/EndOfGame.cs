using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfGame : MonoBehaviour
{
    public GameObject end;
    private void Update()
    {
        if (InventoryManager.items[6].count != 0 && InventoryManager.items[2].count != 0 && InventoryManager.items[3].count != 0 && InventoryManager.items[14].count == 0)
        {
           Invoke("Get14",2f);
        }

        if (InventoryManager.items[14].count != 0 && InventoryManager.items[1].count != 0 && InventoryManager.items[10].count != 0 && InventoryManager.items[15].count == 0)
        {
            Invoke("Get15",8f);
        }

        if (InventoryManager.items[15].count != 0 && Collider2D.end && TextPlay.get1 && Input.GetKeyDown(KeyCode.Q) && EndBar.GongDeng)
        {
            SoundManager.GetCargo();
            GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(3);
            Invoke("BackToStart",5f);
        }
        else if (InventoryManager.items[15].count != 0 && Collider2D.end && TextPlay.get3 && Input.GetKeyDown(KeyCode.Q) && EndBar.ZouMaDeng)
        {
            SoundManager.GetCargo();
            GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(15);
            Invoke("BackToStart",5f);
        }
        else if (InventoryManager.items[15].count != 0 && Collider2D.end && TextPlay.get4 && Input.GetKeyDown(KeyCode.Q) && EndBar.HeHuaDeng)
        {
            SoundManager.GetCargo();
            GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(13);
            Invoke("BackToStart",5f);
        }
        else if (InventoryManager.items[15].count != 0 && Collider2D.end && TextPlay.get5 && Input.GetKeyDown(KeyCode.Q) && EndBar.YvDeng)
        {
            SoundManager.GetCargo();
            GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(17);
            Invoke("BackToStart",5f);
        }
        

        if (InventoryManager.items[15].count != 0 && Collider2D.end && TextPlay.get1)
        {
            end.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(0);
        }
        
    }


    void Get14()
    {
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 14,
            count = 1
        });
        GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(19);
        InventoryManagerUI.instance.UpdateUIDisplay();
    }

    void Get15()
    {
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 15,
            count = 1
        });
        GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(20);
        InventoryManagerUI.instance.UpdateUIDisplay();
    }

    void BackToStart()
    {
        SceneManager.LoadScene(2);
    }
}
