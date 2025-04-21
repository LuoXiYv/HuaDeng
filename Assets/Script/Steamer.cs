    using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Steamer : MonoBehaviour
{
    public Animator anim;
    public static bool isOpen = true;
    public static bool ban;
    public static bool one;


    private void Update()
    {
        if (Transmission.isInWS)
        {
            if (Collider2D.steamer && Input.GetKeyDown(KeyCode.Q) && InventoryManager.items[5].count == 0)
            {
                anim.SetBool("isSteamer", true);
                StatuBarWS.currentState = 1;
            }
            else if (!Collider2D.steamer)
            {
                anim.SetBool("isSteamer", false);
            }

            if (Collider2D.steamer && Input.GetKeyDown(KeyCode.Q) && InventoryManager.items[4].isselected && InventoryManager.items[5].count == 0)
            { 
                
                if (InventoryManager.items[5].count != 0 && Input.GetKeyDown(KeyCode.Q) && !one)
                {
                    StatuBarWS.currentState = 0;
                    GameObject.Find("StatuBarCL").GetComponent<StatuBarWS>().HighlightState(StatuBarWS.currentState);
                    GameObject.Find("CameraFllow").GetComponent<Revolve>().OpenLight();
                    GameObject.Find("Player").GetComponent<PlayerController>().TiShi();
                    GameObject.Find("UI").GetComponent<GetCargoInfo>().Tishi(4);
                    Revolve.currentFace = 8;
                    GameObject.Find("CameraFllow").GetComponent<Revolve>().SetLight();
                    one = true;
                }
                if (Input.GetKeyDown(KeyCode.Q) && Revolve.currentFace == 10 )
                {
                    if (InventoryManager.items[5].count == 0)
                    {
                       Invoke("GetCargo1",2f);
                    }
                    else
                    {
                        return;
                    }
                    SoundManager.ZhengQue();
                    GameObject.Find("CameraFllow").GetComponent<Revolve>().CloseLight();
                }
                else if (Input.GetKeyDown(KeyCode.Q) && Revolve.currentFace != 0)
                {
                    StatuBarWS.currentState = 0;
                    GameObject.Find("CameraFllow").GetComponent<Revolve>().OpenLight();
                    Revolve.currentFace = 8;
                    SoundManager.ShiBai();
                    GameObject.Find("CameraFllow").GetComponent<Revolve>().SetLight();
                }
                anim.SetBool("Steamed", true);
                
            }
            else if (Collider2D.steamer && Input.GetKeyDown(KeyCode.Q) && InventoryManager.items[4].count == 0)
            {
                GameObject.Find("Player").GetComponent<PlayerController>().TiShi();
                GameObject.Find("UI").GetComponent<GetCargoInfo>().Tishi(2);
            }
            else if (!Collider2D.steamer)
            {
                anim.SetBool("Steamed", false);
            }

            if (Collider2D.shelf && !ban)
            {
                if (Input.GetKeyDown(KeyCode.Q) && isOpen)
                {
                    StatuBarWS.currentState = 1;
                    GameObject.Find("Player").GetComponent<PlayerController>().TiShi();
                    GameObject.Find("UI").GetComponent<GetCargoInfo>().Tishi(4);
                    if (InventoryManager.items[5].isselected && Input.GetKeyDown(KeyCode.Q))
                    {
                        isOpen = false;
                    }
                }

                if (Input.GetKeyDown(KeyCode.Q) &&  Revolve.currentFace == 0)
                {
                    SoundManager.ZhengQue();
                    GameObject.Find("CameraFllow").GetComponent<Revolve>().CloseLight();
                    ban = true;
                    Invoke("GetCargo",2f);
                }
                else if (Input.GetKeyDown(KeyCode.Q) && Revolve.currentFace != 0 && !isOpen)
                {
                    StatuBarWS.currentState = 0;
                    GameObject.Find("CameraFllow").GetComponent<Revolve>().OpenLight();
                    Revolve.currentFace = 8;
                    SoundManager.ShiBai();
                    GameObject.Find("CameraFllow").GetComponent<Revolve>().SetLight();
                }

            }
        }
    }

    void GetCargo()
    {
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 6,
            count = 1
        });
        SoundManager.GetCargo();
        GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(16);
        InventoryManagerUI.instance.UpdateUIDisplay();
    }

    void GetCargo1()
    {
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 5,
            count = 1
        });
        SoundManager.GetCargo();
        GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(9);
        InventoryManagerUI.instance.UpdateUIDisplay();
    }
}
