using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour{

    public Button buttonPlay;
    public Button buttonSettings;
    public Button buttonExit;
    public Button buttonResetMaxScore;

    public AudioSource mainSound;

    public Slider sliderMusic;
    public Slider sliderSoundFX;

    void Start(){

        buttonResetMaxScore.interactable = true;

        if (PlayerPrefs.HasKey("MusicVolume") || PlayerPrefs.HasKey("SoundFXVolume")) {

            mainSound.volume = PlayerPrefs.GetFloat("MusicVolume");
            sliderMusic.value = PlayerPrefs.GetFloat("MusicVolume");

            sliderSoundFX.value = PlayerPrefs.GetFloat("SoundFXVolume");

        } else {
            mainSound.volume = 1f;
            sliderMusic.value = 1f;
            sliderSoundFX.value = 1f;
        }

        buttonPlay.onClick.AddListener(delegate {
            SceneManager.LoadScene("01");
        });


        buttonExit.onClick.AddListener(delegate {
            Application.Quit();
        });

        buttonResetMaxScore.onClick.AddListener(delegate {
            PlayerPrefs.SetInt("maxScore", 0);
            buttonResetMaxScore.interactable = false;
        });

        sliderMusic.onValueChanged.AddListener(delegate {
            mainSound.volume = sliderMusic.value;
            PlayerPrefs.SetFloat("MusicVolume", sliderMusic.value);
        });

        sliderSoundFX.onValueChanged.AddListener(delegate {
            PlayerPrefs.SetFloat("SoundFXVolume", sliderSoundFX.value);
        });

    }



}
