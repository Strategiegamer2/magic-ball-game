using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellCooldownAnimation : MonoBehaviour
{
    // Skills icons
    public Image icon;

    // Skills buttons
    private Button skillButton;

    public float cooldown;

    void Update()
    {
        GameObject Time1 = GameObject.Find("TimeStop");
        TimeStop TimeScript = Time1.GetComponent<TimeStop>();

    }
}

