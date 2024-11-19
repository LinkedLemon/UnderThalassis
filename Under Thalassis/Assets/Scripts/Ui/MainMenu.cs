using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject options;
    [SerializeField] private GameObject levelSelect;

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
        options.SetActive(!options.activeInHierarchy);
    }
    public void LevelToggle()
    {
        levelSelect.SetActive(!levelSelect.activeInHierarchy);
    }

}
