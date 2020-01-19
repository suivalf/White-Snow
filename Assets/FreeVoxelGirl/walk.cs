using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class walk : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float rotSpeed;
    Animator anim;
    private int Score;
    public Text ScoreText;
    public Text EndText;

    private void Start()
    {
        anim = GetComponent<Animator>();
        Score = 0;
        SetScoreText();
        EndText.text = "";
    }

    void Update()
    {
        var z = Input.GetAxis("Vertical") * speed;
        var y = Input.GetAxis("Horizontal") * rotSpeed;

        transform.Translate(0, 0, z);
        transform.Rotate(0, y, 0);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           

            anim.SetBool("iswalking", true);
            anim.SetBool("isIdle", false);

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            

            anim.SetBool("iswalking", true);
            anim.SetBool("isIdle", false);

        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            

            anim.SetBool("iswalking", true);
            anim.SetBool("isIdle", false);

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            anim.SetBool("iswalking", true);
            anim.SetBool("isIdle", false);

        }
        else
        {
            anim.SetBool("iswalking", false);
            anim.SetBool("isIdle", true);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "boy")
        {
            other.gameObject.SetActive(false);
            Score = Score + 1;
            SetScoreText();
        }
        
    }

    void SetScoreText()
    {
        ScoreText.text = "Score: " + Score.ToString();
        if (Score >= 7)
        {
            EndText.text = "You found them all! Congratulations.";
        }
    }

}