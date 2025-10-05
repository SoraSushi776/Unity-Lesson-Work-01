using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float speed;
    
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }
}
