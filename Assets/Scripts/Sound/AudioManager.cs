using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public Sound[] musicSounds; //âm thanh nhạc nền
    public Sound[] sfxSounds; //âm thanh hiệu ứng
    public AudioSource musicSource;
    public AudioSource sfxSource;
    public Text musicText;
    public Text sfxText;
    public bool isMusicMuted;
    public bool isSFXMuted;
    private void Awake() {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        // OnMusic();
        // OnSound();
        musicText.text = musicSource.mute ? "On" : "Off";
        sfxText.text = sfxSource.mute ? "On" : "Off";
    }
    private void Start() {
        PlayMusic("Theme");
    }
    // private void Update() {
    //     OnMusic();
    //     OnSound();
    // }
    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);

        if(s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else{
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }
    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name);

        if(s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else{
            sfxSource.clip = s.clip;
            sfxSource.PlayOneShot(s.clip);
        }
    }
    public void ToggleMusic()
    {
        // isMusicMuted = !isMusicMuted;
        // Prefs.MusicMuted = (isMusicMuted == true) ? 1 : 0;
        musicSource.mute = !musicSource.mute;
        // PlayerPrefs.SetInt("musicMuted", musicSource.mute ? 1 : 0);
        musicText.text = (musicSource.mute == true) ? "On" : "Off";
    }
    public void ToggleSFX(){
        // sfxSource.mute = !sfxSource.mute;
        // sfxSource.mute = (sfxSource.mute == false) ? true : false;
        // sfxText.text = (sfxSource.mute == true) ? "On" : "Off";
        // isSFXMuted = !isSFXMuted;
        // Prefs.SoundMuted = (isSFXMuted == true) ? 1 : 0;
        sfxSource.mute = !sfxSource.mute;
        // sfxSource.mute = (sfxSource.mute == false) ? true : false;
        // PlayerPrefs.SetInt("sfxMuted", sfxSource.mute ? 1 : 0);
        sfxText.text = (sfxSource.mute == true) ? "On" : "Off";
    }
    // private void OnMusic()
    // {
    //     if(Prefs.MusicMuted == 1)
    //     {
    //         musicSource.mute = true;
    //         musicText.text = "On";
    //     }else if(Prefs.MusicMuted == 0)
    //     {
    //         musicSource.mute = false;
    //         musicText.text = "Off";
    //     }
    // }
    // private void OnSound()
    // {
    //     if(Prefs.SoundMuted == 1)
    //     {
    //         sfxSource.mute = true;
    //         sfxText.text = "On";
    //     }else if(Prefs.SoundMuted == 0)
    //     {
    //         sfxSource.mute = false;
    //         sfxText.text = "Off";
    //     }
    // }
}
