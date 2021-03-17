using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellCooldownAnimation : MonoBehaviour
{
    // Skills icons
    public Image icon;

    // Cooling time of skills
    public float coolDown;

    // Skill name, used to distinguish which skill is used
    public string skillName;

    // Save the cooldown of the current skill
    public float currentCoolDown;

    // Skills buttons
    private Button skillButton;

    public void UseSkill(string skillName)
    {
        if (currentCoolDown >= coolDown)
        {
            // Using skills, here's just a simple print.
            Debug.Log("Player Used" + skillName);

            // Reset Cooling Time
            currentCoolDown = 0;
        }
    }

    void Start()
    {
        currentCoolDown = coolDown;
    }

    void Update()
    {
        if (currentCoolDown < coolDown)
        {
            // refrigeration cooling
            currentCoolDown += Time.deltaTime;

            // Display cooling animation
            this.icon.fillAmount = currentCoolDown / coolDown;
        }
    }
}

