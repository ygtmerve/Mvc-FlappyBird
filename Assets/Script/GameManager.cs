using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    Model model;
    public View view;
    Controller controller;

    public static GameManager gameManager;

    public void Awake()
    {
        model = new Model();
        controller = new Controller(model, view);

        if (gameManager == null)
        {
            gameManager = this;
        }
        else if (gameManager!=this)
        {
            Destroy(gameObject);
        }

    }
    public GameObject deadPanel;
    public Text scoreText;

    void Start()
    {     
    }
    void Update()
    {
        scoreText.text = PlayerPrefs.GetInt("score").ToString();
        controller.UpdateCall();
    }
}
