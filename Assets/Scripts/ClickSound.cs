using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour
{
    public AudioSource Sound;
    public AudioClip clickSound;

    public void OnMouseDown()
    {
        Sound.PlayOneShot(clickSound);
    }
}
