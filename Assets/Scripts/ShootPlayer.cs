using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPoint;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Fire()
    {
        Instantiate(bullet, bulletPoint.position, bulletPoint.rotation);
        //bullet.velocity = (player.position - bullet.position).normalized * constant;
    }
}
