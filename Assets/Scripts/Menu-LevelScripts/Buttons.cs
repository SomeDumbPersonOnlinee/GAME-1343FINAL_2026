using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    string Menu_Scene = "MenuScene";
    string Instructions_Scene = "Instructions";
    string Testing_Scene = "TestingScene";
    string Levels_Scene = "Levels";

    public void GoToMenu()
    {
        Debug.Log("Menu_Scene");
        SceneManager.LoadScene(Menu_Scene);
    }
    public void GoToInstructions()
    {
        Debug.Log("Instructions_Scene");
        SceneManager.LoadScene(Instructions_Scene);
    }
    public void GoToTesting()
    {
        Debug.Log("Testing_Scene");
        SceneManager.LoadScene(Testing_Scene);
    }
    public void GoToLevels()
    {
        Debug.Log("Levels_Scene");
        SceneManager.LoadScene(Levels_Scene);
    }
}
