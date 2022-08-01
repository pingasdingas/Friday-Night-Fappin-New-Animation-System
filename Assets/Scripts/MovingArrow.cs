using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingArrow : MonoBehaviour
{
  public  Rigidbody2D rb;

  private void Update()
  {
    rb.velocity = new Vector2(-Speed.speed, 0);
  }
}
