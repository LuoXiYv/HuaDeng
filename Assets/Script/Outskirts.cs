using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outskirts : MonoBehaviour
{
    public GameObject bt;
    public GameObject cl;
    public GameObject bb;
    public Animator ani;
    public GameObject go1;
    public GameObject go2;
    public GameObject go3;
    private bool isGet;
    private bool getFT;
    public Animator anit;
    private void Update()
    {
        if (Collider2D.pavilion && !isGet)
        {
            cl.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Q) && !isGet)
            {
                {
                    SoundManager.GetCargo();
                    GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(1);
                    InventoryManagerUI.instance.UpdateUIDisplay();
                    isGet = true;
                }
            }
        }
        else if (!Collider2D.pavilion)
        {
            cl.SetActive(false);
        }

        if (!getFT && isGet)
        {
            if (Collider2D.gmCL || Collider2D.finish || Collider2D.a)
            {
                bt.SetActive(true);
                if (Input.GetKeyDown(KeyCode.Q) && Collider2D.gmCL)
                {
                    SoundManager.Rummage();
                    ani.SetBool("C",true);
                    Invoke("GetFuTou",2f);
                    bt.SetActive(false);
                    getFT = true;
                }
                else if (Input.GetKeyDown(KeyCode.Q) && Collider2D.a)
                {
                    go1.SetActive(false);
                    SoundManager.Rummage();
                }
                else if (Input.GetKeyDown(KeyCode.Q) && Collider2D.finish)
                {
                    go2.SetActive(false);
                    SoundManager.Rummage();
                }
            }
            else if (!Collider2D.gmCL || !Collider2D.finish || !Collider2D.a)
            {
                bt.SetActive(false);
            }
        }
        else if (InventoryManager.items[7].count != 0 && InventoryManager.items[4].count == 0)
        {
            if (Collider2D.pavilion)
            {
                bb.SetActive(true);
                if (Input.GetKeyDown(KeyCode.Q))
                { 
                    anit.SetBool("Cut",true);
                    Invoke("GetZhuzi",2f);
                }
            }
            else if (!Collider2D.pavilion)
            {
                bb.SetActive(false);
            }
        }
        else if (InventoryManager.items[7].count == 0 && InventoryManager.items[4].count == 0)
        {
            if (Collider2D.pavilion)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                { 
                    GameObject.Find("Player").GetComponent<PlayerController>().TiShi();
                    GameObject.Find("UI").GetComponent<GetCargoInfo>().Tishi(1);
                }
            }
        }
    }

    public void GetFuTou()
    {
        InventoryManager.AddItem(new InventoryItem()
        {
            id = 7,
            count = 1
        });
        SoundManager.GetCargo();
        GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(4);
        InventoryManagerUI.instance.UpdateUIDisplay();
        bt.SetActive(false);
        go1.SetActive(false);
        go2.SetActive(false);
        go3.SetActive(false);
    }

    void GetZhuzi()
    {
        if (InventoryManager.items[4].count == 0)
        {
            InventoryManager.AddItem(new InventoryItem()
            {
                id = 4,
                count = 1
            });
            anit.SetBool("Cut",false);
            SoundManager.GetCargo();
            GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(11);
            bb.SetActive(false);
        }
        else
        {
            return;
        }
        bb.SetActive(false);
        InventoryManagerUI.instance.UpdateUIDisplay();
    }
}
