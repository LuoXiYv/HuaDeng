using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowsCT : MonoBehaviour
{
    public Animator animator;
    public Animator npc;
    public static bool isCoin;
    private  bool isOpen;
    public static bool ban;

    private void Update()
    {
        if (Transmission.isInside)
        {
            if (!ban && StatuBarS.islight)
            {
                if (Input.GetKeyDown(KeyCode.Q) && !isOpen )
                {
                    GameObject.Find("Player").GetComponent<PlayerController>().TiShi();
                    GameObject.Find("UI").GetComponent<GetCargoInfo>().Tishi(4);
                    GameObject.Find("CameraFllow").GetComponent<Revolve>().OpenLight();
                    Revolve.currentFace = 8;
                    GameObject.Find("CameraFllow").GetComponent<Revolve>().SetLight();
                    isOpen = true;
                }
                
                if (Input.GetKeyDown(KeyCode.Q) && ( Revolve.currentFace == 0) && !isCoin)
                {  
                    animator.SetBool("IsT",true);
                    animator.SetBool("Night",false);
                    InventoryManagerUI.instance.UpdateUIDisplay();
                    GameObject.Find("CameraFllow").GetComponent<Revolve>().CloseLight();
                    SoundManager.ZhengQue();
                    Invoke("GetCoin",3f);
                    ban = true;
                }
                else if (Input.GetKeyDown(KeyCode.Q) && Revolve.currentFace != 0)
                {
                    GameObject.Find("CameraFllow").GetComponent<Revolve>().OpenLight();
                    Revolve.currentFace = 8;
                    SoundManager.ShiBai();
                }
            }

            if (Revolve.newFace == 3 || Revolve.newFace == 4 || Revolve.newFace == 5 || Revolve.newFace == 6)
            {
                animator.SetBool("Night",true);
                animator.SetBool("IsOne",false);
                animator.SetBool("IsT",true);
            }
        }
    }

    void GetCoin()
    {
        isCoin = true;
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 13,
            count = 1
        });
        InventoryManagerUI.instance.UpdateUIDisplay();
        GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(18);
    }
}
