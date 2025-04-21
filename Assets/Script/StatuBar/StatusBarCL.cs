using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StatusBarCL : MonoBehaviour
{
    private int currentState = 1;
    public List<CanvasGroup> stateImages; 
    
    public static  bool iswalk;
    public static bool islight;
    public static bool open;

    public GameObject statusBarCL;
    public GameObject statusBarWS;
    public GameObject statusBarS;

    void Start()
    {
        HighlightState(currentState);
    }

    void Update()
    {
        // 检测L键的按下
        if (Input.GetKeyDown(KeyCode.L) && !Transmission.isInWS && !Transmission.isInside)
        {
            // 切换状态
            SoundManager.Handoff();
            currentState = (currentState + 1) % stateImages.Count;
            HighlightState(currentState);
        }

        switch (currentState)
        {
            case 0:
            {
                islight = true;
                iswalk = false;
                open = false;
                break;
            }
            case 1:
            {
                islight = false;
                iswalk = false;
                open = true;
                break;
            }
            case 2:
            {
                islight = false;
                iswalk = false;
                open = false;
                break;
            }
        }

        if (!Transmission.isInside && !Transmission.isInWS)
        {
            statusBarCL.SetActive(true);
            statusBarS.SetActive(false);
            statusBarWS.SetActive(false);
            StatuBarWS.isback = false;
            StatuBarWS.iswalk = false;
            StatuBarWS.islight = false;
            StatuBarWS.open = false;
            StatuBarS.islight = false;
            StatuBarS.isback = false;
            StatuBarS.open = false;
        }
        else if (!Transmission.isInside && Transmission.isInWS)
        {
            currentState = 3;
            statusBarS.SetActive(false);
            statusBarCL.SetActive(false);
            statusBarWS.SetActive(true);
            islight = false;
            iswalk = false;
            open = false;
            StatuBarS.islight = false;
            StatuBarS.isback = false;
            StatuBarS.open = false;
        }
        else if (Transmission.isInside && !Transmission.isInWS)
        {
            statusBarS.SetActive(true);
            statusBarCL.SetActive(false);
            statusBarWS.SetActive(false);
            islight = false;
            iswalk = false;
            open = false;
            StatuBarWS.isback = false;
            StatuBarWS.iswalk = false;
            StatuBarWS.islight = false;
            StatuBarWS.open = false;
        }
        
      
    }

    void HighlightState(int index)
    {
        foreach (CanvasGroup image in stateImages)
        {
            image.alpha = 0;
        }
        stateImages[index].alpha = 1;
    }
}

