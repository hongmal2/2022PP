using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyManager : MonoBehaviour
{
    public GameObject lobbyPanel;
    public GameObject settingPanel;

    public GameObject keySettingPanel;
    public GameObject soundSettingPanel;
    public GameObject displaySettingPanel;

    public void OnSettingBtn()
    {
        if(lobbyPanel.gameObject.activeSelf && !settingPanel.gameObject.activeSelf)
        {
            lobbyPanel.gameObject.SetActive(false);
            settingPanel.gameObject.SetActive(true);
        }

        else if(!lobbyPanel.gameObject.activeSelf && settingPanel.gameObject.activeSelf)
        {
            lobbyPanel.gameObject.SetActive(true);
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

    public void OnStartBtn()
    {
        GameManager.GM.isGame = true;
        SceneManager.LoadScene(1);
    }
}
