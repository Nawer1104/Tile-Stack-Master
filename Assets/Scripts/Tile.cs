using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void OnMouseEnter()
    {
 
        anim.SetBool("IsFlip", true);
    }
}
