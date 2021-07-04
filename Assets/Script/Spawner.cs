using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipe;
    public float timer;
    private float baseTimer;
    void Start()
    {
        GameObject gameObject = Instantiate(pipe, transform);
        gameObject.transform.position = new Vector2(gameObject.transform.position.x, Random.Range(-0.1f, 0.5f));
        baseTimer = timer;
    }

    
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer<0)
        {
            GameObject gameObject= Instantiate(pipe, transform);
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, Random.Range(-0.1f, 0.5f));
            timer = baseTimer;
        }
    }
}
