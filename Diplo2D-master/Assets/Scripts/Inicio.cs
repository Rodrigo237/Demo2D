using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Inicio : MonoBehaviour
{
    public int currentLevel = 0;
   public void play()
    {
        if (DataLoader.instance.currentPlayer.lives > 0)
        {
            currentLevel = DataLoader.instance.currentPlayer.lastLevel;
            SceneManager.LoadScene(currentLevel);
        }
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
