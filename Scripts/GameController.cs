using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int numOfEnemiesRemaining;
    public static GameController Instance;
    public string nextSceneName;
    public string thisLevelName;
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(numOfEnemiesRemaining == 0)
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}