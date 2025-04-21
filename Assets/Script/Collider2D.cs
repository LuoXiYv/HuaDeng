using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Collider2D : MonoBehaviour
{
    private Transform player;
    public GameObject enter;
    public static bool shop;
    public static bool table;
    public static bool workShop;
    public static bool steamer;
    public static bool shelf;
    public static bool pavilion;
    public static bool gmCL;
    public static bool finish;
    public static bool bambo;
    public static bool cargo1;
    public static bool cargo2;
    public static bool cargo3;
    public static bool hS;
    public static bool sG;
    public static bool xH;
    public static bool hL;
    public static bool sR;
    public static bool end;
    public static bool a;
    public static bool bxs;

    private void Start()
    {
        player = this.transform;
    }
    
    
    private void OnTriggerEnter2D(UnityEngine.Collider2D e)
    {
        if (e.gameObject.tag.CompareTo("Shop") == 0)
        {
            enter.SetActive(true);
            shop = true;
        }
        

        if (e.gameObject.tag.CompareTo("WorkShop") == 0)
        {
            enter.SetActive(true);
            workShop = true;
        }

        if (e.gameObject.tag.CompareTo("steamer") == 0)
        {
            steamer = true;
        }

        if (e.gameObject.tag.CompareTo("Table") == 0)
        {
            table = true;
        }

        if (e.gameObject.tag.CompareTo("shelf") == 0)
        {
            shelf = true;
        }
        
        if (e.gameObject.tag.CompareTo("pavilion") == 0)
        {
            pavilion = true;
        }

        if (e.gameObject.tag.CompareTo("Finish") == 0)
        {
            finish = true;
        }

        if (e.gameObject.tag.CompareTo("A") == 0)
        {
            a = true;
        }
        
        if (e.gameObject.tag.CompareTo("Respawn") == 0)
        {
            gmCL = true;
        }

        if (e.gameObject.tag.CompareTo("Bambo") == 0)
        {
            bambo = true;
        }

        if (e.gameObject.tag.CompareTo("Cargo1") == 0)
        {
            cargo1 = true;
        }
        
        if (e.gameObject.tag.CompareTo("Cargo2") == 0)
        {
            cargo2 = true;
        }
        
        if (e.gameObject.tag.CompareTo("Cargo3") == 0)
        {
            cargo3 = true;
        }
        
        if (e.gameObject.tag.CompareTo("HS") == 0)
        {
            hS = true;
        }
        if (e.gameObject.tag.CompareTo("SG") == 0)
        {
            sG = true;
        }
        if (e.gameObject.tag.CompareTo("XH") == 0)
        {
           xH = true;
        }
        if (e.gameObject.tag.CompareTo("HL") == 0)
        {
            hL = true;
        }
        if (e.gameObject.tag.CompareTo("SR") == 0)
        {
            sR = true;
        }

        if (e.gameObject.tag.CompareTo("End") == 0)
        {
            end = true;
        }

        if (e.gameObject.tag.CompareTo("Bxs")  == 0)
        {
            bxs = true;
        }
    }

    private void OnTriggerExit2D(UnityEngine.Collider2D e)
    {
        if (e.gameObject.tag.CompareTo("Shop") == 0)
        {
            enter.SetActive(false);
            shop = false;
        }
        
        
        if (e.gameObject.tag.CompareTo("WorkShop") == 0)
        {
            enter.SetActive(false);
            workShop = false;
        }
        
        if (e.gameObject.tag.CompareTo("steamer") == 0)
        {
            steamer = false;
        }
        
        if (e.gameObject.tag.CompareTo("Table") == 0)
        {
            table = false;
        }
        
        if (e.gameObject.tag.CompareTo("shelf") == 0)
        {
            shelf = false;
        }
        
        if (e.gameObject.tag.CompareTo("pavilion") == 0)
        {
            pavilion = false;
        }
        
        if (e.gameObject.tag.CompareTo("Finish") == 0)
        {
            finish = false;
        }
        
        if (e.gameObject.tag.CompareTo("Respawn") == 0)
        {
            gmCL = false;
        }
        
        if (e.gameObject.tag.CompareTo("Bambo") == 0)
        {
            bambo = false;
        }

        if (e.gameObject.tag.CompareTo("Cargo1") == 0)
        {
            cargo1 = false;
        }
        
        if (e.gameObject.tag.CompareTo("Cargo2") == 0)
        {
            cargo2 = false;
        }
        
        if (e.gameObject.tag.CompareTo("Cargo3") == 0)
        {
            cargo3 = false;
        }
        
        if (e.gameObject.tag.CompareTo("HS") == 0)
        {
            hS = false;
        }
        if (e.gameObject.tag.CompareTo("SG") == 0)
        {
            sG = false;
        }
        if (e.gameObject.tag.CompareTo("XH") == 0)
        {
            xH = false;
        }
        if (e.gameObject.tag.CompareTo("HL") == 0)
        {
            hL = false;
        }
        if (e.gameObject.tag.CompareTo("SR") == 0)
        {
            sR = false;
        }
        
        if (e.gameObject.tag.CompareTo("End") == 0)
        {
            end = false;
        }
        
        if (e.gameObject.tag.CompareTo("A") == 0)
        {
            a = false;
        }
        
        if (e.gameObject.tag.CompareTo("Bxs")  == 0)
        {
            bxs = false;
        }
    }
}
