using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    //public PlayerMovement playerMovement;
    public PlayerMovement2 playerMovement2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(360f * playerMovement2.rb.velocity.magnitude * Time.unscaledDeltaTime, 0.0f, 0.0f);
    }
}
