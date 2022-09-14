using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveAnimation : MonoBehaviour
{
    public GameManager GameManager; 

    private Animator Animator;

    private void Awake()
    {
        Animator = gameObject.GetComponent<Animator>();
    }
    void Start()
    {
        Animator.Play("Init");
    }

    public void CallShowCard()
    {
        GameManager.Activate();
        gameObject.SetActive(false);
    }

   
}
