using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed;
    
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);    
    }
}
