using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller
{
    public Model model;
    public View view;
    Rigidbody2D rb;

    public Controller(Model model, View view)

    {
        this.model = model;
        this.view = view;
    }

    public void UpdateCall()
    {
       
        model.isDead = view.dead;

        view.BirdMove(model.playerSpeed);
        view.Gameover(model.isDead);
    }  

}
