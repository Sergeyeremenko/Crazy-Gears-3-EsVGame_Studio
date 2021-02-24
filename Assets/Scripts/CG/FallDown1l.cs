using UnityEngine;
public class FallDown1l : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed = 7f;
    void Update()
    {
        if (transform.position.y < -35f)
            Destroy(gameObject);
        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
    }
}
