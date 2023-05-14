using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefs : MonoBehaviour
{
    public static int Attack{
        get => PlayerPrefs.GetInt(Consts.ATK, 5);
        set {
            PlayerPrefs.SetInt(Consts.ATK, value);
        }
    }
    public static int Health{
        get => PlayerPrefs.GetInt(Consts.HP, 20);
        set {
            PlayerPrefs.SetInt(Consts.HP, value);
        }
    }
    public static int Gold{
        get => PlayerPrefs.GetInt(Consts.GOLD, 200000);
        set {
            PlayerPrefs.SetInt(Consts.GOLD, value);
        }
    }
    public static int Ruby{
        get => PlayerPrefs.GetInt(Consts.RUBY, 0);
        set {
            PlayerPrefs.SetInt(Consts.RUBY, value);
        }
    }
    public static int LevelSelected{
        get => PlayerPrefs.GetInt(Consts.LEVEL, 0);
        set {
            PlayerPrefs.SetInt(Consts.LEVEL, value);
        }
    }
    public static int PlayerSelected{
        get => PlayerPrefs.GetInt(Consts.PLAYER, 0);
        set {
            PlayerPrefs.SetInt(Consts.PLAYER, value);
        }
    }
    public static int MusicMuted{
        get => PlayerPrefs.GetInt("musicMuted", 0);
        set {
            PlayerPrefs.SetInt("musicMuted", value);
        }
    }
    public static int SoundMuted{
        get => PlayerPrefs.GetInt("soundMuted", 0);
        set {
            PlayerPrefs.SetInt("soundMuted", value);
        }
    }
}
