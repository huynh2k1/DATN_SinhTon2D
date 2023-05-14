using UnityEngine;

public class AudioSetting : MonoBehaviour
{
    public static AudioSetting instance = null; // singleton instance

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        IsMuteMusic = PlayerPrefs.GetInt("musicMuted", 0) == 1;
        IsMuteSFX = PlayerPrefs.GetInt("sfxMuted", 0) == 1;
    }

    private bool isMuteMusic = false;
    public bool IsMuteMusic 
    {
        get => isMuteMusic;
        set 
        {
            isMuteMusic = value;
            PlayerPrefs.SetInt("musicMuted", isMuteMusic ? 1 : 0);
        } 
    }

    private bool isMuteSFX = false;
    public bool IsMuteSFX
    {
        get => isMuteSFX;
        set
        {
            isMuteSFX = value;
            PlayerPrefs.SetInt("sfxMuted", isMuteSFX ? 1 : 0);
        }
    }
}