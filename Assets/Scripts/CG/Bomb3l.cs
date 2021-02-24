using System.Collections;
using UnityEngine;
public class Bomb3l : MonoBehaviour
{
    public GameObject Bombs;
    void Start()
    {
        StartCoroutine (Spawn ());
    }
    IEnumerator Spawn () {
        while (true) {
            Instantiate (Bombs, new Vector2 (Random.Range (200f, 2100f), 315f), Quaternion.identity);
            yield return new WaitForSeconds (0.3f);
        }
    }
}
