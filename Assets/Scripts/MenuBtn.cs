using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBtn : MonoBehaviour
{
    public GameObject mainMenuUi;
    public GameObject inGameUi;
    public GameObject settingsUi;
    public GameObject inGameMenuUi;

    public void OpenGame()
    {
        mainMenuUi.SetActive(false);
        inGameUi.SetActive(true);
    }

    public void OpenSettings()
    {
        mainMenuUi.SetActive(false);
        settingsUi.SetActive(true);
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
        CloseInGameMenu();
        mainMenuUi.SetActive(true);
        inGameMenuUi.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
