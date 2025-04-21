using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuiscPlay : MonoBehaviour
{
    public static AudioSource st;
    public static AudioClip start;
    void Start()
    {
        st = GetComponent<AudioSource>();
        start = Resources.Load<AudioClip>("开始界面灯会BGM");
    }

    private void Update()
    {
        if (!st.isPlaying)
        {
            PlayStart();
        }
    }

    public static void PlayStart()
    {
        st.PlayOneShot(start);
    }
}
