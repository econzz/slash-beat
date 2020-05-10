using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public enum SFX
    {
        HIT,
        MISS
    }

    public static AudioClip hitSound, missSound;
    static AudioSource audioSrc;
    void Start()
    {
        hitSound = Resources.Load<AudioClip>("HitShortLeft1");
        missSound = Resources.Load<AudioClip>("BadCut0");
        audioSrc = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(SFX idSfx)
    {
        switch (idSfx)
        {
            case SFX.HIT:
                audioSrc.PlayOneShot(hitSound);
                break;
            case SFX.MISS:
                audioSrc.PlayOneShot(missSound);
                break;
        }
    }
}
