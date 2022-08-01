using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
  // Loads the new animation system
  public void LoadMainScene()
  {
    SceneManager.LoadScene(1);
  }
   
  // Pretty self explanatory
  public void ExitGame()
  {
    Application.Quit();
  }
  

  // A different way of closing the game
  private void Update()
  {
    // If you hit the Escape button on your keyboard
    if(Input.GetKeyDown(KeyCode.Escape))
    {
      ExitGame();
    }
  }
}
