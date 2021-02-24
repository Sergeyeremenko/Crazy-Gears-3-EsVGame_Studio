using UnityEngine;
public class FallDown7l : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed = 9f;
    void Update()
    {
        if (transform.position.y < -60f)
            Destroy(gameObject);
        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
    }
}
