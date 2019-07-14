using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour{

    public NumberGenerator[] numberGenerator;

    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;

    public Button buttonExit;
    public Button buttonPlayAgain;
    public Button buttonMainMenu;

    private List<int> numbersList;

    private int actualScore = 0;
    private int maxScore = 0;

    public Text textActualScore;

    public TextMeshProUGUI txtYourScore;
    public TextMeshProUGUI txtMaxScore;

    public GameObject canvasMain;
    public GameObject canvasLose;

    public AudioSource mainSound;
    public AudioSource loseSound;
    public AudioSource earnPointsSound;

    public static float initialSpeed = 4f;

    void Update() {
        increaseSpeed();    
    }

    void Start(){

        canvasMain.SetActive(true);
        canvasLose.SetActive(false);

        if (PlayerPrefs.HasKey("MusicVolume") || PlayerPrefs.HasKey("SoundFXVolume")) {
            mainSound.volume = PlayerPrefs.GetFloat("MusicVolume");
            loseSound.volume = PlayerPrefs.GetFloat("SoundFXVolume");
            earnPointsSound.volume = PlayerPrefs.GetFloat("SoundFXVolume");
        } else {
            mainSound.volume = 1f;
            loseSound.volume = 1f;
            earnPointsSound.volume = 1f;
        }

        if (PlayerPrefs.HasKey("maxScore")) {
            maxScore = PlayerPrefs.GetInt("maxScore");
        }

        numbersList = new List<int>();

        button1.onClick.AddListener(delegate {
            if (numbersList.Contains(1)) {
                Destroy(GameObject.FindGameObjectWithTag("num1"));
                numbersList.Remove(1);
                actualScore += 1;
                textActualScore.text = actualScore.ToString();
                earnPointsSound.Play();
            } else {
                playerLost();
            }
        });

        button2.onClick.AddListener(delegate {
            if (numbersList.Contains(2)) {
                Destroy(GameObject.FindGameObjectWithTag("num2"));
                numbersList.Remove(2);
                actualScore += 1;
                textActualScore.text = actualScore.ToString();
                earnPointsSound.Play();
            } else {
                playerLost();
            }
        });

        button3.onClick.AddListener(delegate {
            if (numbersList.Contains(3)) {
                Destroy(GameObject.FindGameObjectWithTag("num3"));
                numbersList.Remove(3);
                actualScore += 1;
                textActualScore.text = actualScore.ToString();
                earnPointsSound.Play();
            } else {
                playerLost();
            }
        });

        button4.onClick.AddListener(delegate {
            if (numbersList.Contains(4)) {
                Destroy(GameObject.FindGameObjectWithTag("num4"));
                numbersList.Remove(4);
                actualScore += 1;
                textActualScore.text = actualScore.ToString();
                earnPointsSound.Play();
            } else {
                playerLost();
            }
        });

        button5.onClick.AddListener(delegate {
            if (numbersList.Contains(5)) {
                Destroy(GameObject.FindGameObjectWithTag("num5"));
                numbersList.Remove(5);
                actualScore += 1;
                textActualScore.text = actualScore.ToString();
                earnPointsSound.Play();
            } else {
                playerLost();
            }
        });

        button6.onClick.AddListener(delegate {
            if (numbersList.Contains(6)) {
                Destroy(GameObject.FindGameObjectWithTag("num6"));
                numbersList.Remove(6);
                actualScore += 1;
                textActualScore.text = actualScore.ToString();
                earnPointsSound.Play();
            } else {
                playerLost();
            }
        });

        button7.onClick.AddListener(delegate {
            if (numbersList.Contains(7)) {
                Destroy(GameObject.FindGameObjectWithTag("num7"));
                numbersList.Remove(7);
                actualScore += 1;
                textActualScore.text = actualScore.ToString();
                earnPointsSound.Play();
            } else {
                playerLost();
            }
        });

        button8.onClick.AddListener(delegate {
            if (numbersList.Contains(8)) {
                Destroy(GameObject.FindGameObjectWithTag("num8"));
                numbersList.Remove(8);
                actualScore += 1;
                textActualScore.text = actualScore.ToString();
                earnPointsSound.Play();
            } else {
                playerLost();
            }
        });

        button9.onClick.AddListener(delegate {
            if (numbersList.Contains(9)) {
                Destroy(GameObject.FindGameObjectWithTag("num9"));
                numbersList.Remove(9);
                actualScore += 1;
                textActualScore.text = actualScore.ToString();
                earnPointsSound.Play();
            } else {
                playerLost();
            }
        });

        buttonExit.onClick.AddListener(delegate {
            Application.Quit();
        });

        buttonPlayAgain.onClick.AddListener(delegate {
            SceneManager.LoadScene("01");
            initialSpeed = 4f;
        });

        buttonMainMenu.onClick.AddListener(delegate {
            SceneManager.LoadScene("00");
        });


    }

    public void addNumbersToList(int number) {
        numbersList.Add(number);
    }

    public void playerLost() {

        cleanScreen();
        numbersList.Clear();

        mainSound.Stop();
        loseSound.Play();

        foreach (NumberGenerator i in numberGenerator) {
            i.stopNumberGenerator();
        }

        if (actualScore > maxScore) {
            PlayerPrefs.SetInt("maxScore",actualScore);
            txtYourScore.GetComponent<Animator>().enabled = true;
        } else {
            txtYourScore.GetComponent<Animator>().enabled = false;
        }

        txtYourScore.text = "Your Score: "+actualScore.ToString();
        txtMaxScore.text = "Max Score: " + maxScore.ToString();
        
        canvasMain.SetActive(false);
        canvasLose.SetActive(true);
    }

    public void cleanScreen() {

        string[] tags = {
            "num0","num1","num2","num3","num4","num5","num6","num7","num8","num9"
        };

        foreach (string tag in tags) {
            GameObject[] numeros = GameObject.FindGameObjectsWithTag(tag);

            foreach (GameObject numero in numeros) {
                Destroy(numero);
            }
        }
    }

    public static void increaseSpeed() {
        initialSpeed += 0.01f * Time.deltaTime;
    }

}
