using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbController : MonoBehaviour
{
    public bool bulbOn = false;
    private Animator bulbAnimator;



    private void Awake()
    {
        bulbAnimator = gameObject.GetComponent<Animator>();

        bulbOff();

    }

    void Start()

    {
        
    }

    
    void Update()
    {
        
    }

    public void bulbOff()
    {
    
                {
            bulbOn = false;
            bulbAnimator.SetBool("BulbOn", bulbOn);
        }
    }
}
