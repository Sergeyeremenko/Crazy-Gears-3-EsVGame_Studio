using System.Collections;
using UnityEngine;
public class Bomb7l : MonoBehaviour
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
            Instantiate(Bombs, new Vector2(Random.Range(50f, 1900f), 140f), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
    }
}