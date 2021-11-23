using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBtn : MonoBehaviour
{
    public GameObject mainMenuUi;
    public GameObject settingsUi;
    public GameObject inGameMenuUi;

    public void OpenGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenSettings()
    {
        mainMenuUi.SetActive(false);
        settingsUi.SetActive(true);
    }

    public void CloseSetting()
    {
        mainMenuUi.SetActive(true);
        settingsUi.SetActive(false);
    }

    public void OpenInGameMenu()
    {
        inGameMenuUi.SetActive(true);
    }

    public void CloseInGameMenu()
    {
        inGameMenuUi.SetActive(false);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
