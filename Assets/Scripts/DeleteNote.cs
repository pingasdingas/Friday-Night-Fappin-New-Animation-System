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

  public float timerTime;
  
  private void Awake()
  {
    timerTime = Random.Range(1.0f, 3.0f);
  }

  // When something hits it (the only thing that can hit it is a note)
  public void OnCollisionEnter2D(Collision2D col)
  {
    // Delete the note
    Destroy(col.gameObject);

    // Play random sound effect
    audiosrc.PlayOneShot(chosenSound);
    
    // Switches between 2 different animations after hitting a note
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
    
  }

  // Chooses which of the sounds will be played
  private void Update()
  {
    chosenSound = randomSounds[Random.Range(0, randomSounds.Length)];

    NoteRandomizer();
  }

  // Randomizes the times the arrows spawn
  private void NoteRandomizer()
  {
    timerTime -= Time.deltaTime;
    
    if (timerTime <= 0.0f)
    {
      TimerEnded();
    }
  }
  
  // When the note randomizing timer ends it resets
  private void TimerEnded()
  {
    timerTime = Random.Range(0.1f, 0.5f);

    // Spawns a note
    Instantiate(notes, new Vector3(10, -2, 0), Quaternion.identity);
  }
}
