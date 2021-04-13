using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreUpdater : MonoBehaviour
{
    [SerializeField]
    Text text;
    void OnEnable(){
        GameManager.onPointUpdate += OnPointUpdate;
    }

    void OnPointUpdate(int value){
        text.text = "Score: " + value;
    }

    void OnDisable(){
        GameManager.onPointUpdate -= OnPointUpdate;
    }
}
