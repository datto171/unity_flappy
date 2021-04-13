using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGroup : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 3;
    Vector2 position;

    // Start is called before the first frame update
    void Start()
    {
        position = (Vector2)transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.x -= moveSpeed * Time.deltaTime;
        if (position.x <= -11) {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        transform.position = position;
    }
}
