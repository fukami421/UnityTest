using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerPrefs : MonoBehaviour// 変数の値をアプリケーションが終了しても残るようにするクラス
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

    // Update is called once per frame
    void Update()
    {
        
    }

    public static int LevelUp()
    {
        int playerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        PlayerPrefs.SetInt("PLAYERLEVEL", playerLevel + 1);
        return PlayerPrefs.GetInt("PLAYERLEVEL");
    }
    #endregion
}
