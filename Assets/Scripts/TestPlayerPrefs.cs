using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 変数の値をアプリケーションが終了しても残るようにするクラス
/// 参考: https://qiita.com/situtyo666/items/e1a3bf15a2dccc2bfedc
/// </summary>
public class TestPlayerPrefs : MonoBehaviour
{
    #region fields
    //private string highScore = "PLYAERLEVEL";
    #endregion
    #region methods
    // Start is called before the first frame update
    void Start()
    {
        //データ名「CLEARSTAGE」に引数の0を代入        
        PlayerPrefs.SetInt("PLYAERLEVEL", 0);
        Debug.Log(LevelUp());
    }

    public static int LevelUp()
    {
        int playerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        PlayerPrefs.SetInt("PLAYERLEVEL", playerLevel + 1);
        return PlayerPrefs.GetInt("PLAYERLEVEL");
    }
    #endregion
}
