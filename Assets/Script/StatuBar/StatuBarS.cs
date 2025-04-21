using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatuBarS : MonoBehaviour
{
    public static int currentState = 0;
    public List<CanvasGroup> stateImages;

    public static bool isback;
    public static bool islight;
    public static bool open;
    
    private void Start()
    {
        HighlightState(currentState);
    }

    void Update()
    {
        if (Transmission.isInside)
        {
            if (Input.GetKeyDown(KeyCode.L) && !Transmission.isInWS && Transmission.isInside)
            {
                // 切换状态
                SoundManager.Handoff();
                currentState = (currentState + 1) % stateImages.Count;
                HighlightState(currentState);
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                HighlightState(currentState);
            }

            switch (currentState)
            {
                case 0:
                {
                    islight = false;
                    open = true;
                    isback = false;
                    break;
                }
                case 1:
                {
                    islight = true;
                    open = false;
                    isback = false;
                    break;
                }
                case 2:
                {
                    islight = false;
                    open = false;
                    isback = true;
                    break;
                }
                case 3:
                {
                    islight = false;
                    open = false;
                    isback = false;
                    break;
                }
            }
        }
    }

     public void HighlightState(int index)
    {
        foreach (CanvasGroup image in stateImages)
        {
            image.alpha = 0;
        }


        stateImages[index].alpha = 1;
    }
}

