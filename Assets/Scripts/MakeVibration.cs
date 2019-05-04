using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

/// <summary>
/// VibrationをplaySystemSound.mmと共に実装しています
/// 参考(iOS): https://qiita.com/DURIAN_JADE/items/3fdddb4ad19658f50539
/// 参考(Droid): https://ameblo.jp/vantrux/entry-11605689738.html
/// ネイティブコードと連携する
/// 参考: https://qiita.com/edo_m18/items/2aff04ec51c7ffc4cf7c
/// </summary>

public class MakeVibration : MonoBehaviour
{
    #region fields
    [DllImport("__Internal")] private static extern void playSystemSound(int n);
    #endregion

    #region methods
    // Start is called before the first frame update
    void Start()
    {
        Vibration();
    }

    private static void Vibration()
    {
#if UNITY_EDITOR
        Debug.Log("Play system sound or vibration on real devices");
#elif UNITY_IPHONE
        playSystemSound(1519);//Plugins/iOS/VplaySystemSound.mmを呼び出している
#else
        VibrateScript.vibrate(3);//Plugins/Droid/VibrateScriptを呼び出している
#endif
    }
    #endregion
}
