using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
   public static AudioSource aS;
   public static AudioClip handoff;
   public static AudioClip rummage;
   public static AudioClip open;
   public static AudioClip zhuanDeng;
   public static AudioClip shiBai;
   public static AudioClip zhengQue;
   public static AudioClip getCargo;
   public static AudioClip start;
 

   private void Start()
   {
      aS = GetComponent<AudioSource>();
      handoff = Resources.Load<AudioClip>("切换");
      rummage = Resources.Load<AudioClip>("落叶堆");
      open = Resources.Load<AudioClip>("打开背包");
      zhuanDeng = Resources.Load<AudioClip>("转灯");
      shiBai = Resources.Load<AudioClip>("失败");
      zhengQue = Resources.Load<AudioClip>("成功音效");
      getCargo = Resources.Load<AudioClip>("获得道具");
   }

   public static void Handoff()
   {
      aS.PlayOneShot(handoff);
   }

   public static void Rummage()
   {
      aS.PlayOneShot(rummage);
   }

   public static void Open()
   {
      aS.PlayOneShot(open);
   }

   public static void ZhuanDeng()
   {
      aS.PlayOneShot(zhuanDeng);
   }

   public static void ShiBai()
   {
      aS.PlayOneShot(shiBai);
   }

   public static void ZhengQue()
   {
      aS.PlayOneShot(zhengQue);
   }

   public static void GetCargo()
   {
      aS.PlayOneShot(getCargo);
   }

  
}
