using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteNote : MonoBehaviour
{
  public Animator anim;
  public GameObject notes;

  public bool whichClap = false;

  public AudioSource audiosrc;
  public AudioClip[] randomSounds;
  public AudioClip chosenSound;

  public void OnCollisionEnter2D(Collision2D col)
  {
    Destroy(col.gameObject);
    audiosrc.PlayOneShot(chosenSound);

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

  // playing a random sound
  private void Update()
  {
    chosenSound = randomSounds[Random.Range(0, randomSounds.Length)];
  }
}
