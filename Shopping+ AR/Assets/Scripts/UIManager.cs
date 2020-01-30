using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class for managing the UI
/// </summary>
public class UIManager : MonoBehaviour
{

    //======================== [ Button methods ] ========================

    public void TestButton()
    {
        ButtonHapticFeedback();
    }

    /// <summary>
    /// Shows if flashlight is on or off
    /// </summary>
    bool isFlashActive;

    /// <summary>
    /// Toggles the flashlight
    /// </summary>
    public void ToggleFlashButton()
    {
        if(isFlashActive == false)
        {
            Vuforia.CameraDevice.Instance.SetFlashTorchMode(true);
            isFlashActive = true;
        }
        else if(isFlashActive == true)
        {
            Vuforia.CameraDevice.Instance.SetFlashTorchMode(false);
            isFlashActive = false;
        }

        ButtonHapticFeedback();
    }






    //======================== [ Helper methods ] ========================

    /// <summary>
    /// This will peform an Android haptic feedback
    /// </summary>
    void ButtonHapticFeedback()
    {
       HapticFeedback();
    }

    private class HapticFeedbackManager
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        private int HapticFeedbackConstantsKey;
        private AndroidJavaObject UnityPlayer;
#endif

        public HapticFeedbackManager()
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            HapticFeedbackConstantsKey=new AndroidJavaClass("android.view.HapticFeedbackConstants").GetStatic<int>("VIRTUAL_KEY");
            UnityPlayer=new AndroidJavaClass ("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity").Get<AndroidJavaObject>("mUnityPlayer");
            //Alternative way to get the UnityPlayer:
            //int content=new AndroidJavaClass("android.R$id").GetStatic<int>("content");
            //new AndroidJavaClass ("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity").Call<AndroidJavaObject>("findViewById",content).Call<AndroidJavaObject>("getChildAt",0);
#endif
        }

        public bool Execute()
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            return UnityPlayer.Call<bool> ("performHapticFeedback",HapticFeedbackConstantsKey);
#endif
            return false;
        }
    }

    //Cache the Manager for performance
    private static HapticFeedbackManager mHapticFeedbackManager;

    public static bool HapticFeedback()
    {
        if (mHapticFeedbackManager == null)
        {
            mHapticFeedbackManager = new HapticFeedbackManager();
        }
        return mHapticFeedbackManager.Execute();
    }
}
