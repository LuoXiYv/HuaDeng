using System;
using System.Collections;
using System.Collections.Generic;
using SKCell;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Button = UnityEngine.UIElements.Button;
using Random = UnityEngine.Random;

public class Cargo : MonoBehaviour
{
    [SerializeField] private GameObject cargo;
    public GameObject buy;
    public static bool cr1;
    public static bool cr2;
    public static bool cr3;
    
    
    private void Update()
    {
        if (Revolve.newFace == 3 || Revolve.newFace == 4 || Revolve.newFace == 5 || Revolve.newFace == 6 )
        {
            CloseActive();
        }

        if (WindowsCT.isCoin && Collider2D.cargo1 && Input.GetKeyDown(KeyCode.Q))
        {
            if (InventoryManager.items[2].count == 0)
            {
                InventoryManager.AddItem(new InventoryItem()
                {
                    id = 2,
                    count = 1
                });
                GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(7);
                SoundManager.GetCargo();
                InventoryManagerUI.instance.UpdateUIDisplay();
                cr1 = true;
            }
            else
            {
                return;
            }
        }
        else if (!WindowsCT.isCoin && Collider2D.cargo1 && Input.GetKeyDown(KeyCode.Q))
        {
            GameObject.Find("Player").GetComponent<PlayerController>().TiShi();
            GameObject.Find("UI").GetComponent<GetCargoInfo>().Tishi(3);
        }
        
        if (WindowsCT.isCoin && Collider2D.cargo2 && Input.GetKeyDown(KeyCode.Q))
        {
            if (InventoryManager.items[1].count == 0)
            {
                InventoryManager.AddItem(new InventoryItem()
                {
                    id = 1,
                    count = 1
                });
                GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(14);
                SoundManager.GetCargo();
                InventoryManagerUI.instance.UpdateUIDisplay();
                cr2 = true;
            }
            else
            {
                return;
            }
        }
        else if (!WindowsCT.isCoin && Collider2D.cargo2 && Input.GetKeyDown(KeyCode.Q))
        {
            GameObject.Find("Player").GetComponent<PlayerController>().TiShi();
            GameObject.Find("UI").GetComponent<GetCargoInfo>().Tishi(3);
        }
        
        if (WindowsCT.isCoin && Collider2D.cargo3 && Input.GetKeyDown(KeyCode.Q))
        {
            if (InventoryManager.items[3].count == 0)
            {
                InventoryManager.AddItem(new InventoryItem()
                {
                    id = 3,
                    count = 1
                });
                GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(5);
                SoundManager.GetCargo();
                InventoryManagerUI.instance.UpdateUIDisplay();
                cr3 = true;
            }
            else
            {
                return;
            }
        }
        else if (!WindowsCT.isCoin && Collider2D.cargo2 && Input.GetKeyDown(KeyCode.Q))
        {
            GameObject.Find("Player").GetComponent<PlayerController>().TiShi();
            GameObject.Find("UI").GetComponent<GetCargoInfo>().Tishi(3);
        }

        if (WindowsCT.isCoin && (Collider2D.cargo3 || Collider2D.cargo1 || Collider2D.cargo2))
        {
            buy.SetActive(true);
        }
        else if (WindowsCT.isCoin && !(Collider2D.cargo3 || Collider2D.cargo1 || Collider2D.cargo2))
        {
            buy.SetActive(false);
        }

    }
    
    public void OpenActive()
    {
        if (Transmission.isInside && (Revolve.newFace == 7 || Revolve.newFace == 8 || Revolve.newFace == 9 || Revolve.newFace == 10 || Revolve.newFace == 11 || Revolve.newFace == 0))
        { 
            cargo.SetActive(true);
        }
    }

    public void CloseActive()
    {
       cargo.SetActive(false);
    }
}
