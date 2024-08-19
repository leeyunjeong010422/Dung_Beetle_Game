using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSound : MonoBehaviour
{
    static AudioSource audioSource;
    public static AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioClip = Resources.Load<AudioClip>("MP_Sharp Fart");    
    }

    // Update is called once per frame
    public static void SoundPlay()
    {
        audioSource.PlayOneShot(audioClip);
    }
}
