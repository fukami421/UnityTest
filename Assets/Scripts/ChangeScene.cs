
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//追加
using UnityEngine.SceneManagement;
 
public class ChangeScene : MonoBehaviour
{

    private string LoadSceneName = "A";
    private AsyncOperation async;

    // Use this for initialization
    void Start()
    {
        //SceneManager.LoadScene("B", LoadSceneMode.Additive);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(SceneManager.GetActiveScene().name == "A");
            if (SceneManager.GetActiveScene().name == "A")
            {
                ScenePreLoad("B");
            }else if (SceneManager.GetActiveScene().name == "B")
            {
                ScenePreLoad("A");
            }
        }
        if (Input.GetKeyUp(KeyCode.Space)) StartCoroutine("SceneLoad");
    }

    void ScenePreLoad(string changeScn)
    {
        async = SceneManager.LoadSceneAsync(changeScn, LoadSceneMode.Additive);
        async.allowSceneActivation = false;
    }

    IEnumerator SceneLoad()
    {
        async.allowSceneActivation = true;
        yield return null;
        if (SceneManager.GetActiveScene().name == "A")
        {
            SceneManager.UnloadSceneAsync("A");
        }
        else if (SceneManager.GetActiveScene().name == "B")
        {
            SceneManager.UnloadSceneAsync("B");
        }

    }
}