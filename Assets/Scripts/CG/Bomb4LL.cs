using System.Collections;
using UnityEngine;
public class Bomb4LL : MonoBehaviour
{
    public GameObject Bombs;
    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (true)
        {
            Instantiate(Bombs, new Vector2(Random.Range(100f, 1000f), 30f), Quaternion.identity);
            yield return new WaitForSeconds(0.3f);
        }
    }
}
