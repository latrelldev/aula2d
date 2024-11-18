using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    [SerializeField]
    private SceneController _sceneController;
    public void Play()
    {
        _sceneController.LoadScene("Game");
    }

    public void Menu()
    {
        _sceneController.LoadScene("Menu");
    }

    public void Historia()
    {
        _sceneController.LoadScene("Historia");
    }

    public void Controles()
    {
        _sceneController.LoadScene("Controles");
    }


    public void Exit()
    {
        Application.Quit();
    }
}
