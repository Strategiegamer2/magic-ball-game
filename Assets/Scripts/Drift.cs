using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drift : MonoBehaviour
{
    public GameObject player;
    public GameObject Particle;

    float currMagnitude;
    float oldMagnitude;

    private ParticleSystem m_particleSystem;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        oldMagnitude = currMagnitude;
        currMagnitude = player.GetComponent<Rigidbody>().velocity.magnitude;

        float mDiffrence = currMagnitude - oldMagnitude;
        Debug.Log(mDiffrence);
        if (mDiffrence < -0.2f)
        {
            PlayParticle(transform.position - new Vector3(0, transform.localScale.y / 2, 0), transform.forward);
        }
    }

    private void PlayParticle(Vector3 position, Vector3 direction)
    {
        m_particleSystem = Particle.GetComponent<ParticleSystem>();
        ParticleSystem.ShapeModule _editableShape = m_particleSystem.shape;
        _editableShape.position = position;
        transform.position = direction;
    }
}
