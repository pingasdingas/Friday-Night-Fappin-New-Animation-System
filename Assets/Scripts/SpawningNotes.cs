using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningNotes : MonoBehaviour
{
  public GameObject notes;

  public IEnumerator SpawnNote()
  {
    yield return new WaitForSeconds(Speed.speed);
    Instantiate(notes, new Vector3(10, -2, 0), Quaternion.identity);
  }
}
