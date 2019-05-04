using UnityEngine;
using System.Collections;

public class VibrateScript
{
    public static void vibrate(int msec)
    {
        AndroidJavaObject unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        AndroidJavaObject vibrator = currentActivity.Call<AndroidJavaObject>("getSystemService", "vibrator");

        vibrator.Call("vibrate", msec);

        vibrator.Dispose();
        currentActivity.Dispose();
        unityPlayer.Dispose();
    }
}