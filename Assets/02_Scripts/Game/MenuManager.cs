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

    bool isMenu = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !MenuPanel.activeSelf && !isMenu)
        {
            MenuPanel.SetActive(true);
            isMenu = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && MenuPanel.activeSelf && isMenu)
        {
            MenuPanel.SetActive(false);
            isMenu = false;
        }
    }
    public void OnSettingBtn()
    {

    }

    public void OnKeySettingBtn()
    {

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
        LoadingSceneController.LoadScene("Lobby");
    }
}
