using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple_animation_trigger : MonoBehaviour
{
    [SerializeField] private Animator[] _anims;

    private void OnMouseDown()
    {
        for (int i = 0; i < _anims.Length; i++)
        {
            _anims[i].SetTrigger("Click");
        }
    }
}
