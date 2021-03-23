using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLookAt : MonoBehaviour
{
    public Transform target;
    private float dist { get; set; }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            dist = Vector3.Distance(target.position, transform.position);
        }
        if (dist < 30)
        {
            transform.LookAt(target);
        }
    }
}
