using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -0.55)
        {
            transform.position = new Vector2(0.55f, transform.position.y);
        }
        transform.position += Vector3.left * Time.deltaTime * 1.3f;
    }
}
