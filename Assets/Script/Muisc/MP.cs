using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MP : MonoBehaviour
{
    public static AudioSource a;
    public static AudioClip dajie;
    void Start()
    {
        a = GetComponent<AudioSource>();
        dajie = Resources.Load<AudioClip>("街市");
    }

    // Update is called once per frame
    void Update()
    {
        if (!a.isPlaying)
        {
            PlayStart();
        }
        else
        {
            return;
        }
    }
    
    public static void PlayStart()
    {
        a.PlayOneShot(dajie);
    }
}
