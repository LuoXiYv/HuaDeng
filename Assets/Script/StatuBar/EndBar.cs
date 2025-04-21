using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBar : MonoBehaviour
{
   public static bool GongDeng;
   public static bool ZouMaDeng;
   public static bool HeHuaDeng;
   public static bool YvDeng;
   
   private int currentState = 1;
   public List<CanvasGroup> stateImages; 
   
   void Start()
   {
      HighlightState(currentState);
   }


   void Update()
   {
      // 检测L键的按下
      if (Input.GetKeyDown(KeyCode.Z) && !Transmission.isInWS && !Transmission.isInside)
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
            GongDeng = true;
            ZouMaDeng = false;
            HeHuaDeng = false;
            YvDeng = false;
            break;
         }
         case 1:
         {
            GongDeng = false;
            ZouMaDeng = true;
            HeHuaDeng = false;
            YvDeng = false;
            break;
         }
         case 2:
         {
            GongDeng = false;
            ZouMaDeng = false;
            HeHuaDeng = true;
            YvDeng = false;
            break;
         }
         case 3:
         {
            GongDeng = false;
            ZouMaDeng = false;
            HeHuaDeng = false;
            YvDeng = true;
            break;
         }
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
