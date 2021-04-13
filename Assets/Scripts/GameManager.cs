using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager Instance;
    private int point;
    private bool isOver;

    public static Action<int> onPointUpdate; 


    void Awake(){
        Time.timeScale = 0;
        
        Instance = this;
    } 

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            Time.timeScale = 1;
        }
    }

    void Start(){
        onPointUpdate.Invoke(point);
    }

    public static void IncreasePoint(){
        Instance.point++;
        onPointUpdate(Instance.point);
    }

    public static void GameOver(){
            Instance.isOver = true;
        Time.timeScale = 0;
        Debug.Log("Game over");
    }

    public static void Replay(){
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public static bool IsOver(){
        return Instance.isOver;
    }


}
