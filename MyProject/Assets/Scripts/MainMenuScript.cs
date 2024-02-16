using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{

    public GameObject MainMenuCanvas;
    public GameObject AboutCanvas;

    public void PlayButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

    public void AboutButton()
    {
        MainMenuCanvas.SetActive(false);
        AboutCanvas.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void BackButton()
    {
        MainMenuCanvas.SetActive(true);
        AboutCanvas.SetActive(false);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
