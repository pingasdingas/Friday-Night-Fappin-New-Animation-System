using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningNotes : MonoBehaviour
{
  public GameObject notes;
  
  // Instead of making an entire charting tool for this little demo I just have it place
  // notes at a certain pace
  public IEnumerator SpawnNote()
  {
    yield return new WaitForSeconds(Speed.speed);
    Instantiate(notes, new Vector3(10, -2, 0), Quaternion.identity);
  }
}
