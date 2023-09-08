using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickFX : MonoBehaviour
{
    public AudioSource FX;
    public AudioClip clickFX;

    public void ClickSound()
    {
        FX.PlayOneShot(clickFX);
    }
}
