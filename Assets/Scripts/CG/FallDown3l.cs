using UnityEngine;
public class FallDown3l : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed = 9f;
    void Update()
    {
        if (transform.position.y < -100f)
            Destroy(gameObject);
        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
    }
}
