using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteNote : MonoBehaviour
{
  public Animator anim;
  public GameObject notes;

  public bool whichClap = false;

  public void OnCollisionEnter2D(Collision2D col)
  {
    Destroy(col.gameObject);

    switch (whichClap)
    {
      case false:
       anim.Play("boing");
       whichClap = true;
      break;
      case true:
       anim.Play("boing2");
       whichClap = false;
      break;
    }

    Instantiate(notes, new Vector3(10, -2, 0), Quaternion.identity);
  }
}
