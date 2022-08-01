using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Speed : MonoBehaviour
{
  public static float speed;
  public Animator anim;

  public float sliderValue;

  private void Update()
  {
    // Loading main menu if Escape key is hit
    if(Input.GetKeyDown(KeyCode.Escape))
    {
      SceneManager.LoadScene(0);
    }
    
    // The animation plays at the speed of the chart in the actual game you set this to follow
    // whatever variable you use for your chart but for this demo I just have a constant speed 
    // set
    anim.speed = Speed.speed;
  }

  private void OnGUI()
  {
    // Creates a slider at the top left of the screen
    GUI.Label(new Rect(0, 25, 40, 60), "Speed");
    sliderValue = GUI.HorizontalSlider(new Rect(90, 50, 400, 120), sliderValue, 0.0F, 100.0F);
    speed = sliderValue;
  }
}
