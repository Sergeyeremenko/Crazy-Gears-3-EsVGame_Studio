using System.Collections;
using UnityEngine;
public class Bomb4l : MonoBehaviour
{
    public GameObject Bombs;
    void Start()
    {
        StartCoroutine (Spawn ());
    }
    IEnumerator Spawn () {
        while (true) {
            Instantiate (Bombs, new Vector2 (Random.Range (140f, 1140f), 200f), Quaternion.identity);
            yield return new WaitForSeconds (0.3f);
        }
    }
}
