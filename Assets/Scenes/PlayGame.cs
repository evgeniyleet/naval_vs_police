using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
   public void PlayGames()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void PlayGamesInfo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void PlayGamesBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
    }

}
