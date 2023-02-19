using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public bool musicOn, soundOn;
    // Start is called before the first frame update
    void Start()
    {
        AudioSetup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MusicToogle(GameObject img)
    {
        if (musicOn)
        {
            musicOn = false;
            this.GetComponent<AudioSource>().Stop();
            
        }
        else
        {
            musicOn = true;
            this.GetComponent<AudioSource>().Play();
        }
        img.SetActive(!musicOn);
        
    }
    public void SoundToogle(GameObject img)
    {
        if (soundOn)
        {
            soundOn = false;

        }
        else
        {
            soundOn = true;
        }
        img.SetActive(!soundOn);

    }
    public void SaveData()
    {
        if (musicOn)
        {
            PlayerPrefs.SetInt("music", 1);
        }
        else
        {
            PlayerPrefs.SetInt("music", 0);
        }
        if (soundOn)
        {
            PlayerPrefs.SetInt("sound", 1);
        }
        else
        {
            PlayerPrefs.SetInt("sound", 0);
        }
    }
    public void AudioSetup()
    {
        if (PlayerPrefs.HasKey("music"))
        {
            if (PlayerPrefs.GetInt("music") == 1)
            {
                musicOn = true;
                this.GetComponent<AudioSource>().Play();
            }
            else
            {
                musicOn = false;
                GameObject.Find("Music").transform.GetChild(1).gameObject.SetActive(true);
            }
        }
        else
        {
            musicOn = true;
            this.GetComponent<AudioSource>().Play();
        }
        if (PlayerPrefs.HasKey("sound"))
        {
            if (PlayerPrefs.GetInt("sound") == 1)
            {
                soundOn = true;
            }
            else
            {
                soundOn = false;
                GameObject.Find("Sound").transform.GetChild(1).gameObject.SetActive(true);
            }
                
        }
        else
        {
            soundOn = true;
        }
    }
}