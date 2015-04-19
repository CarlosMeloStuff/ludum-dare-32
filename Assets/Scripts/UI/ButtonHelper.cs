using UnityEngine;
using System.Collections;

public class ButtonHelper : MonoBehaviour 
{
    public void Load1PlayerRace()
    {
        GameController.NumberOfPlayers = 1;
        LoadRaceScene();
    }

    public void Load2PlayerRace()
    {
        GameController.NumberOfPlayers = 2;
        LoadRaceScene();
    }

    public void Load3PlayerRace()
    {
        GameController.NumberOfPlayers = 3;
        LoadRaceScene();
    }

    public void Load4PlayerRace()
    {
        GameController.NumberOfPlayers = 4;
        LoadRaceScene();
    }

    public void RestartScene()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void LoadScene(string scene)
    {
        Application.LoadLevel(scene);
    }

	public void LoadRaceScene()
    {
        LoadScene("Race");
    }

    public void ExitGame()
    {
        if (Application.isEditor)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else
        {
            Application.Quit();
        }
    }
}
