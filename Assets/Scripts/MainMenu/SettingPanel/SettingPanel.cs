using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SettingPanel : MonoBehaviour
{
    public static SettingPanel instance;
    public BasePopup PanelSetting;

    // Start is called before the first frame update
    private void Awake() {

        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
    public void CloseButton()
    {
        AudioManager.instance.PlaySFX("Click");
        PanelSetting.Show(false);
    }
}
