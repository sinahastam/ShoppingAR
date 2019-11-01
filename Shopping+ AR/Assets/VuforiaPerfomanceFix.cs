using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VuforiaPerfomanceFix : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        OnVuforiaStarted();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnVuforiaStarted()
    {
        // Query Vuforia for recommended frame rate and set it in Unity
        int targetFps = VuforiaRenderer.Instance.GetRecommendedFps(VuforiaRenderer.FpsHint.FAST);

        // By default, we use Application.targetFrameRate to set the recommended frame rate.
        // If developers use vsync in their quality settings, they should also set their
        // QualitySettings.vSyncCount according to the value returned above.
        // e.g: If targetFPS > 50 --> vSyncCount = 1; else vSyncCount = 2;
        if (Application.targetFrameRate != targetFps)
        {
            Debug.Log("Setting frame rate to " + targetFps + "fps");
            Application.targetFrameRate = targetFps;
        }
    }
}
