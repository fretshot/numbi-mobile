using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour{

    public Button buttonPlay;
    public Button buttonSettings;
    public Button buttonExit;
    
    void Start(){

        buttonPlay.onClick.AddListener(delegate {
            SceneManager.LoadScene("01");
        });


        buttonExit.onClick.AddListener(delegate {
            Application.Quit();
        });

    }

    

}
