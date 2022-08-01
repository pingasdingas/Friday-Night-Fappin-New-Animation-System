using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
  public static float speed;
  public Animator anim;

  public float sliderValue;

  private void Update()
  {
    // The animation plays at the speed of the chart in the actual game you set this to follow
    // whatever variable you use for your chart but for this demo I just have a constant speed 
    // set
    anim.speed = Speed.speed;
  }

  private void OnGUI()
  {
    //Create a Label in Game view for the Slider
    GUI.Label(new Rect(0, 25, 40, 60), "Speed");
    //Create a horizontal Slider to control the speed of the Animator. Drag the slider to 1 for normal speed.

    sliderValue = GUI.HorizontalSlider(new Rect(45, 25, 200, 60), sliderValue, 0.0F, 100.0F);
    //Make the speed of the Animator match the Slider value
    speed = sliderValue;
  }
}
