using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{ 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this is for x axis' movement  
        if (Input.GetKeyDown(KeyCode.R))
        {
            FindObjectOfType<TimeStop>().PlayAnimatoin();
        }
    }
}
