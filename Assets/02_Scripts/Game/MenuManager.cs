using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject settingPanel;

    public GameObject keySettingPanel;
    public GameObject soundSettingPanel;
    public GameObject displaySettingPanel;

    public void OnSettingBtn()
    {
        if (MenuPanel.gameObject.activeSelf && !settingPanel.gameObject.activeSelf)
        {
            MenuPanel.gameObject.SetActive(false);
            settingPanel.gameObject.SetActive(true);
        }

        else if (!MenuPanel.gameObject.activeSelf && settingPanel.gameObject.activeSelf)
        {
            MenuPanel.gameObject.SetActive(true);
            settingPanel.gameObject.SetActive(false);
        }
    }

    public void OnKeySettingBtn()
    {
        if (!keySettingPanel.gameObject.activeSelf && settingPanel.gameObject.activeSelf)
        {
            keySettingPanel.gameObject.SetActive(true);
            settingPanel.gameObject.SetActive(false);
        }
        else
        {
            keySettingPanel.gameObject.SetActive(false);
            settingPanel.gameObject.SetActive(true);
        }
    }

    public void OnSoundSettingBtn()
    {

    }

    public void OnDisplaySettingBtn()
    {

    }

    public void OnExitButton()
    {
        GameManager.GM.isGame = false;
        SceneManager.LoadScene(0);
    }
}
