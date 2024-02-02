using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public Text ScoreText;
    public Text WinText;
    public GameObject Wall;
    private Rigidbody rb;
    public int Score;
    
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        Score = 0;
        SetScoreText();
        WinText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * Speed);

        //Restart level
        if(Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        //Quit game
        if(Input.GetKeyDown(KeyCode.Escape))
        { 
            Application.Quit(); 
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("coin"))
        {
            other.gameObject.SetActive(false);
            Score++;
            SetScoreText();

            if(Score > 3)
            {
                Wall.gameObject.SetActive(false);
            }
        }
        if(other.gameObject.tag == "danger")
        {
            Application.LoadLevel(Application.loadedLevel);
        }

    }
    void SetScoreText()
    {
        ScoreText.text = "Score: " + Score.ToString();

        if( Score >= 5)
        {
            WinText.text = "R or ESC";
        }
    }
}
