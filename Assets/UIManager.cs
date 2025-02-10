using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenuUI;
    public GameObject gameplayUI;
    public GameObject pausedMenuUI;

    
    public void EnableMainMenuUI()
    {
        DisableAllUIPanels();
        mainMenuUI.SetActive(true);
    }

    public void EnableGameplayUI()
    {
        DisableAllUIPanels();
        gameplayUI.SetActive(true);
    }

    public void EnablePausedMenuUI()
    {
        DisableAllUIPanels();
        pausedMenuUI.SetActive(true);
    }

    public void DisableAllUIPanels()
    {
        mainMenuUI.SetActive(false);
        gameplayUI.SetActive(false);
        pausedMenuUI.SetActive(false);
    }
}
