using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_trigger : MonoBehaviour
{
 [SerializeField] private Animator _anim;

    private void OnMouseDown()
    {
        _anim.SetTrigger("Click");
    }
}
