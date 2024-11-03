using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    GameObject OptionsPanel;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ShowOptions(bool isActive)
    {
        OptionsPanel.SetActive(isActive);
    }

    public void ExitGame()
    {
        Application.Quit();
    }


}
