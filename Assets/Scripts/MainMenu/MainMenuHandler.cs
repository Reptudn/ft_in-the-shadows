using UnityEngine;

public class MainMenuHandler : MonoBehaviour
{
    [Header("Menu Containers")]
    public GameObject mainContainer;
    public GameObject playContainer;
    public GameObject settingsContainer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (mainContainer == null || playContainer == null || settingsContainer == null)
        {
            Debug.LogError("One or more menu containers are not assigned in the inspector.");
            return;
        }
        ShowMainMenu();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ShowMainMenu()
    {
        Debug.Log("Showing Main Menu");
        mainContainer.SetActive(true);
        playContainer.SetActive(false);
        settingsContainer.SetActive(false);
    }

    public void ShowPlayMenu()
    {
        Debug.Log("Showing Play Menu");
        mainContainer.SetActive(false);
        playContainer.SetActive(true);
        settingsContainer.SetActive(false);
    }

    public void ShowSettingsMenu()
    {
        Debug.Log("Showing Settings Menu");
        mainContainer.SetActive(false);
        playContainer.SetActive(false);
        settingsContainer.SetActive(true);
    }

    public void ExitGame()
    {
        Debug.Log("Exiting Game");
        Application.Quit();
    }

}
