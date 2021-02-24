using System.Collections;
using UnityEngine;
public class Bomb : MonoBehaviour
{
    public GameObject Bombs;
    void Start()
    {
        StartCoroutine (Spawn ());
    }
    IEnumerator Spawn () {
        while (true) {
            Instantiate (Bombs, new Vector2 (Random.Range (150f, 600f), 100f), Quaternion.identity);
            yield return new WaitForSeconds (0.5f);
        }
    }
}
