using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeStop : MonoBehaviour
{
    public GameObject TimeShader;
    public AudioSource TimeStopAudio;
    public AudioSource TimeStopEndAudio;

    public PostProcessing postProcessing;

    public bool ToBeContinued = false;
    public bool startCooldown;
    public bool EndCooldown;

    public Image icon;

    public float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        TimeShader.SetActive(false);
        startCooldown = false;
        EndCooldown = false;
    }

    private void Update()
    {
        if (startCooldown == true)
        {
            // Display cooling animation
            icon.fillAmount += 1.0f / waitTime * Time.deltaTime;
            if (icon.fillAmount == 1)
            {
                EndCooldown = false;
                startCooldown = false;
                ToBeContinued = false;
            }
        }
    }

    public void PlayAnimatoin()
    {
        StartCoroutine(ZaWardo());
    }

    private IEnumerator ZaWardo()
    {
        if (EndCooldown == false)
        {
            EndCooldown = true;
            ToBeContinued = true;
            TimeStopAudio.Play(0);

            TimeShader.SetActive(true);

            postProcessing.grain.enabled.value = true;
            postProcessing.lensDistortion.enabled.value = true;
            postProcessing.chromaticAberration.enabled.value = true;

            yield return new WaitForSecondsRealtime(2.5f);
            postProcessing.colorGradingLayer.contrast.value = -77f;
            yield return new WaitForSecondsRealtime(0.1f);
            postProcessing.colorGradingLayer.contrast.value = -12f;
            yield return new WaitForSecondsRealtime(0.1f);
            postProcessing.colorGradingLayer.contrast.value = -77f;
            yield return new WaitForSecondsRealtime(0.1f);
            postProcessing.colorGradingLayer.contrast.value = -120f;
            yield return new WaitForSecondsRealtime(0.1f);
            postProcessing.colorGradingLayer.contrast.value = 0f;
            yield return new WaitForSecondsRealtime(0.05f);
            TimeShader.SetActive(false);
            yield return new WaitForSecondsRealtime(20f);
            TimeStopEndAudio.Play(0);
            TimeShader.SetActive(true);
            yield return new WaitForSecondsRealtime(0.5f);
            TimeShader.SetActive(false);
            yield return new WaitForSecondsRealtime(0.5f);
            TimeShader.SetActive(true);
            yield return new WaitForSecondsRealtime(0.5f);
            TimeShader.SetActive(false);
            yield return new WaitForSecondsRealtime(1f);

            postProcessing.grain.enabled.value = false;
            postProcessing.lensDistortion.enabled.value = false;
            postProcessing.chromaticAberration.enabled.value = false;

            icon.fillAmount = 0;
            ToBeContinued = false;
            startCooldown = true;
        }
    }
}
