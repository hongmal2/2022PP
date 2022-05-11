using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    Transform menuPanel;
    Event keyEvent;
    Text buttonText;
    KeyCode newKey;

    bool escapeLock; // 키 바꾸고 있을 때 esc 막음
    bool waitingForKey;

    void Start()
    {
        menuPanel = transform.FindChild("KeySettings");
        menuPanel.gameObject.SetActive(false);
        waitingForKey = false;
        escapeLock = false;

        for (int i = 0; i < 5; i++)
        {
            if (menuPanel.GetChild(i).name == "ForwardKey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.forward.ToString();
            else if (menuPanel.GetChild(i).name == "BackKey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.backward.ToString();
            else if (menuPanel.GetChild(i).name == "LeftKey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.Left.ToString();
            else if (menuPanel.GetChild(i).name == "RightKey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.right.ToString();
            else if (menuPanel.GetChild(i).name == "JumpKey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.jump.ToString();
        }
    }
    private void OnGUI()
    {
        keyEvent = Event.current; // 키이벤트가 현재이벤트와 같음

        if(keyEvent.isKey && waitingForKey) 
        {
            newKey = keyEvent.keyCode;
            waitingForKey = false;
        }
    }

    public void StartAssignment(string keyName)
    {
        if (!waitingForKey)
            StartCoroutine(AssignKey(keyName));
    }

    public void SendText(Text text)
    {
        buttonText = text;
    }

    IEnumerator WaitForKey() // 키 입력 기다리는중
    {
        while (!keyEvent.isKey)
        {
            buttonText.text = "아무 키나 입력";
            yield return null;
        }
    }

    public IEnumerator AssignKey(string keyName) // 키 입력
    {
        waitingForKey = true;
        escapeLock = true;
        yield return WaitForKey();

        switch(keyName)
        {
            case "forward":
                GameManager.GM.forward = newKey;
                buttonText.text = GameManager.GM.forward.ToString();
                PlayerPrefs.SetString("forwardKey", GameManager.GM.forward.ToString());
                break;
            case "backward":
                GameManager.GM.backward = newKey;
                buttonText.text = GameManager.GM.backward.ToString();
                PlayerPrefs.SetString("backwardKey", GameManager.GM.backward.ToString());
                break;
            case "left":
                GameManager.GM.Left = newKey;
                buttonText.text = GameManager.GM.Left.ToString();
                PlayerPrefs.SetString("leftKey", GameManager.GM.Left.ToString());
                break;
            case "right":
                GameManager.GM.right = newKey;
                buttonText.text = GameManager.GM.right.ToString();
                PlayerPrefs.SetString("rightKey", GameManager.GM.right.ToString());
                break;
            case "jump":
                GameManager.GM.jump = newKey;
                buttonText.text = GameManager.GM.jump.ToString();
                PlayerPrefs.SetString("jumpKey", GameManager.GM.jump.ToString());
                break;
        }
        escapeLock = false;
        yield return null;
    }


}
