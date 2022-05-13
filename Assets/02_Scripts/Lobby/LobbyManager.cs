using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyManager : MonoBehaviour
{
    public Stack<int> panels;
    int panelsnum;


    public GameObject lobbyPanel;
    public GameObject settingPanel;

    public GameObject keySettingPanel;
    public GameObject soundSettingPanel;
    public GameObject displaySettingPanel;

    public void OnStartBtn()
    { 
        GameManager.GM.isGame = true;
        LoadingSceneController.LoadScene("Game");
    }

    public void OnStack()
    {
        
    }
}
