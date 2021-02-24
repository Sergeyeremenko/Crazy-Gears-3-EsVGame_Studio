using UnityEngine;
public class FallDown4l : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed = 9f;
    void Update()
    {
        if (transform.position.y < -120f)
            Destroy(gameObject);
        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
    }
}
