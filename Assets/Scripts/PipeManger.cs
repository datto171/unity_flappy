using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManger : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    float spawnInterval = 5;
    [SerializeField]
    float maxY;
    [SerializeField]
    float minY;
    [SerializeField]
    float startX;

    float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        if(currentTime <= 0){
            Spawn();
            currentTime = spawnInterval;
        }
    }

    void Spawn(){
        var go =   Instantiate(prefab);
        go.transform.position = new Vector2(startX,Random.Range(minY,maxY));
        GameManager.IncreasePoint();
    }
}
