using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    public Rigidbody bulletPrefab;

    public static int RemovedCubeCount = 0;
    public static int BallCount = 0;
    
    void Update()
    {
        float leftRight = Input.GetAxis("Horizontal");
        float upDown = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.right * (Time.deltaTime * speed * leftRight));
        transform.Translate(Vector3.forward * (Time.deltaTime * speed * upDown));
        
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.up * (Time.deltaTime * speed));
        }
        
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.down * (Time.deltaTime * speed));
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up, mouseX * speed);
        float mouseY = Input.GetAxis("Mouse Y");
        transform.Rotate(Vector3.left, mouseY * speed);
        
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);
        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Fire()
    {
        Rigidbody bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        bullet.linearVelocity = transform.forward * 10;
        BallCount++;
        
        Destroy(bullet.gameObject, 5);
    }
    
    public static void ResetPlayer()
    {
        BallCount = 0;
        RemovedCubeCount = 0;
    }
}
