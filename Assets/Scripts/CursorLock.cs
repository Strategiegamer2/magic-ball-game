using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLock : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        if (Input.GetKeyDown(KeyCode.E))
#else
    if(Input.GetKeyDown(KeyCode.Escape))
#endif
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
