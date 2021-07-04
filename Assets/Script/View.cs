using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    public GameObject deadPanel;
    Rigidbody2D rb;
    public bool dead;

    private void Start()
    {
        dead = false;
        rb = GetComponent<Rigidbody2D>();
    }

    public void BirdMove(float playerSpeed)
    {
        if (Input.GetMouseButtonDown(0))
        {

            rb.velocity = Vector3.up * playerSpeed;
            Time.timeScale = 1;
        }
    }
    public void Gameover(bool isDead)
    {
        if (isDead)
        {
            PlayerPrefs.SetInt("score", 0);
            Time.timeScale = 0;
            deadPanel.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Score")
        {
            var score = PlayerPrefs.GetInt("score");
            PlayerPrefs.SetInt("score",score+1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        dead = true;
    }
}
