using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public KeyCode moveLeft;
    public KeyCode moveRight;
    
    public float leftMaxPos, rightMaxPos;
    public float moveDistance;
    
    private void Update()
    {
        if (Input.GetKeyDown(moveLeft) && transform.position.x > leftMaxPos)
        {
            transform.position -= new Vector3(moveDistance, 0, 0);
        }
        
        if  (Input.GetKeyDown(moveRight) && transform.position.x < rightMaxPos)
        {
            transform.position += new Vector3(moveDistance, 0, 0);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShotBullet();
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadScene();
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void ShotBullet()
    {
        GameObject bullet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        bullet.transform.position = transform.position;
        
        // 往前发射
        bullet.AddComponent<Rigidbody>();
        
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.mass = 3;
        rb.AddForce(transform.forward * 5000);
        
        // 销毁子弹
        Destroy(bullet, 2);
    }
}
