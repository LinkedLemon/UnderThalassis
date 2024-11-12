using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject Options;
    [SerializeField] private GameObject LevelSelect;

    public void Quit()
    {
        Application.Quit();
    }

    public void StartGame(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void SettingsToggle()
    {
        Options.SetActive(!Options.activeInHierarchy);
    }
    public void LevelToggle()
    {
        LevelSelect.SetActive(!LevelSelect.activeInHierarchy);
    }

}
