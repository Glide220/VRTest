using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl2 : MonoBehaviour
{
    
    private bool on = false;
    private bool buttonHit = false;
    private GameObject button;

    private float buttonDownDistance = 0.025f;
    private float buttonReturnSpeed = 0.001f;
    private float buttonOriginalY;

    public GameObject ui;

    private float buttonHitAgainTime = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
