using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScenesChange : MonoBehaviour
{
    public GameObject Wall;
    public GameObject img;
    public Image img1;
    public Image img2;
    public Image img3;
    public Image img4;
    public Image img5;
    public Image img6;
    public Image img7;
    public Image img8;
    public SpriteRenderer img9;
    public SpriteRenderer img10;
    public Image img11;
    public Image img12;
    public Image img13;
    public Image img14;
    public Image img15;
    public SpriteRenderer spr1;
    public SpriteRenderer spr2;
    public SpriteRenderer spr3;
    public SpriteRenderer spr4;

    public GameObject npc1;
    public GameObject npc2;
    public GameObject npc3;
    public GameObject npc4;
    public GameObject npc5;
    public GameObject npc6;
    private void Update()
    {
        
            if (Revolve.newFace == 7 || Revolve.newFace == 8 || Revolve.newFace == 9 || Revolve.newFace == 10 || Revolve.newFace == 11 || Revolve.newFace == 0)
            {
                BackGroundChange(1);
                Wall.SetActive(false);
                npc1.SetActive(true);
                npc2.SetActive(true);
                npc3.SetActive(true);
                npc4.SetActive(true);
                npc5.SetActive(true);
                npc6.SetActive(true);
            }
            if (Revolve.newFace == 1 || Revolve.newFace == 2)
            {
                BackGroundChange(2);
                Wall.SetActive(false);
                npc1.SetActive(false);
                npc2.SetActive(false);
                npc3.SetActive(false);
                npc4.SetActive(false);
                npc5.SetActive(false);
                npc6.SetActive(false);
            }
            if (Revolve.newFace == 3 || Revolve.newFace == 4 || Revolve.newFace == 5 || Revolve.newFace == 6 )
            {
                BackGroundChange(3);
                Wall.SetActive(true);
                npc1.SetActive(false);
                npc2.SetActive(false);
                npc3.SetActive(false);
                npc4.SetActive(false);
                npc5.SetActive(false);
                npc6.SetActive(false);
            }

            if (Collider2D.shelf || Collider2D.steamer)
            {
                img.SetActive(true);
            }
            else
            {
                img.SetActive(false);
            }
    }

    void BackGroundChange(int id1)
    { 
        img1.sprite = Resources.Load<Sprite>($"Bck1-{id1}");
        img2.sprite = Resources.Load<Sprite>($"Bck2-{id1}");
        img3.sprite = Resources.Load<Sprite>($"Bck3-{id1}");
        img4.sprite = Resources.Load<Sprite>($"Bck4-{id1}");
        img5.sprite = Resources.Load<Sprite>($"Bck5-{id1}");
        img6.sprite = Resources.Load<Sprite>($"Bck6-{id1}");
        img7.sprite = Resources.Load<Sprite>($"Bck7-{id1}");
        img8.sprite = Resources.Load<Sprite>($"Bck8-{id1}");
        img9.sprite = Resources.Load<Sprite>($"Bck9-{id1}");
        img10.sprite = Resources.Load<Sprite>($"Bck10-{id1}");
        img11.sprite = Resources.Load<Sprite>($"Bck11-{id1}");
        img12.sprite = Resources.Load<Sprite>($"Bck12-{id1}");
        img13.sprite = Resources.Load<Sprite>($"Bck13-{id1}");
        img14.sprite = Resources.Load<Sprite>($"Bck14-{id1}");
        img15.sprite = Resources.Load<Sprite>($"Bck15-{id1}");
        spr1.sprite = Resources.Load<Sprite>($"Spr1-{id1}");
        spr2.sprite = Resources.Load<Sprite>($"Spr2-{id1}");
        spr3.sprite = Resources.Load<Sprite>($"Spr3-{id1}");
        spr4.sprite = Resources.Load<Sprite>($"Spr4-{id1}");
        
    }
}
