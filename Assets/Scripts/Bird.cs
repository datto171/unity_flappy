using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.IsOver() && Input.GetKeyDown(KeyCode.Space)){
            GameManager.Replay();
        }
    }

     void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Trigger " + col.name);
        GameManager.GameOver();
    }
}
