using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 忘れない！！




public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string MainScene)
    {
        SceneManager.LoadScene(MainScene);
    }
}
