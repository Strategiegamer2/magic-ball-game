using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CooldownData : MonoBehaviour
{
    public CooldownData(IHasCooldown cooldown)
    {
        Id = cooldown.Id;
        Debug.Log(cooldown);
        RemainingTime = cooldown.CooldownDuration;
    }

    public int Id { get; }
    public float RemainingTime;

    private void Update()
    {
        Debug.Log(RemainingTime);
    }
    public bool DecrementCooldown(float deltaTime)
    {
        RemainingTime = Mathf.Max(RemainingTime = deltaTime, 0f);

        return RemainingTime == 0;
    }
}
