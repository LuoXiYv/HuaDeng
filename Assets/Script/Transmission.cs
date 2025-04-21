using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Transmission : MonoBehaviour
{
    public Transform table;
    private Transform playerTransform;
    public Transform shop;
    public Transform workShop;
    public Transform wsDoor;
    public GameObject loadImg;
    public TextMeshProUGUI text;
    public static bool isInside;
    public static bool isInWS;
    
    
    
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    private void Update()
    {
        if (isInside && (Revolve.newFace == 4  || Revolve.newFace == 6) )
        {
            StartCoroutine(OpenLoad(3));
            Invoke("CloseLoad",3f);
            playerTransform.position = shop.position;
            GameObject.Find("CameraFllow").GetComponent<CameraFllow>().UnLock();
            GameObject.Find("Shop_Inside").GetComponent<Cargo>().CloseActive();
            isInside = false;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Transmiss();
        }
    }

    public void Transmiss()
    {
        
        if (StatuBarS.isback)
        {
            StartCoroutine(OpenLoad(2));
            Invoke("CloseLoad",3f);
            playerTransform.position = shop.position;
            isInside = false;
            GameObject.Find("CameraFllow").GetComponent<CameraFllow>().UnLock();
            GameObject.Find("Shop_Inside").GetComponent<Cargo>().CloseActive();
        }

        if (Collider2D.shop && ( Revolve.newFace == 8 ||  Revolve.newFace == 10 ||  Revolve.newFace == 0 ||  Revolve.newFace == 2))
        {  
            StartCoroutine(OpenLoad(0));
            Invoke("CloseLoad",3f);
            playerTransform.position = table.position;
            Revolve.currentFace = 8;
            StatuBarS.isback = false;
            isInside = true;
            GameObject.Find("CameraFllow").GetComponent<CameraFllow>().Lock();
            GameObject.Find(("Shop_Inside")).GetComponent<Cargo>().OpenActive();
            GameObject.Find("CameraFllow").GetComponent<Revolve>().ReSetRotation();
        }

        if (Collider2D.workShop)
        {
            StartCoroutine(OpenLoad(1));
            Invoke("CloseLoad",3f);
            playerTransform.position = wsDoor.position;
            StatuBarWS.isback = false;
            isInWS = true;
            GameObject.Find("CameraFllow").GetComponent<CameraFllow>().Lock();
            GameObject.Find("CameraFllow").GetComponent<Revolve>().ReSetRotation();
        }

        if ( isInWS && StatuBarWS.isback)
        {
            StartCoroutine(OpenLoad(2));
            Invoke("CloseLoad",3f);
            playerTransform.position = workShop.position;
            isInWS = false;
            GameObject.Find("CameraFllow").GetComponent<CameraFllow>().UnLock();
        }
    }

     IEnumerator  OpenLoad(int count)
    {
        loadImg.SetActive(true);
        switch (count)
        {
            case 0:
                text.text = "正在前往—荣记七宝铺";
                break;
            case 1:
                text.text = "正在前往—陈生的作坊";
                break;
            case 2:
                text.text = "返回—烟雨南街";
                break;
            case 3:
                text.text = "返回—烟雨南街";
                break;
        }

        yield return new WaitForSeconds(0f);
    }
    private void CloseLoad()
    {
        loadImg.SetActive(false);
    }
}
