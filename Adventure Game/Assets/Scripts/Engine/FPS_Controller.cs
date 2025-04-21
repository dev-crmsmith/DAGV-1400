using System;
using UnityEngine;

public class FPS_Controller : MonoBehaviour
{
    private void Awake()
    {
        QualitySettings.vSyncCount = 0; // Disables VSync
        Application.targetFrameRate = 30; // Sets the target frame rate to 30 FPS
    }
}
