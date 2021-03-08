using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessing : MonoBehaviour
{
    [HideInInspector]
    public ColorGrading colorGradingLayer = null;
    [HideInInspector]
    public Grain grain = null;
    [HideInInspector]
    public LensDistortion lensDistortion = null;
    [HideInInspector]
    public ChromaticAberration chromaticAberration = null;

    // Start is called before the first frame update
    void Start()
    {

        PostProcessVolume volume = gameObject.GetComponent<PostProcessVolume>();
        volume.profile.TryGetSettings(out colorGradingLayer);
        volume.profile.TryGetSettings(out grain);
        volume.profile.TryGetSettings(out lensDistortion);
        volume.profile.TryGetSettings(out chromaticAberration);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
