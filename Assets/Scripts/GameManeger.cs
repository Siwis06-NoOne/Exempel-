using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    public static GameManeger GlobalGameManeger = null;

    public int CurrentLevel = -7014;
    private int StartingLevel = 1;
    public int MenuIndex = 0;


    private void Awake()
    {
       if (GameManeger.GlobalGameManeger == null)
        {
            GlobalGameManeger = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && CurrentLevel != MenuIndex)
        {
            ToMenu();
        }
    }

    public void OnStartAtFirstLevel()
    {
        CurrentLevel= StartingLevel;
        SceneManager.LoadScene(CurrentLevel);
    }

    public void OnLoadLevel(int aLevelIndexToLoad)
    {
        CurrentLevel = aLevelIndexToLoad;
        SceneManager.LoadScene(CurrentLevel);
    }

    public void ToMenu()
    {
        CurrentLevel = MenuIndex;
        SceneManager.LoadScene(CurrentLevel);
    }
}
