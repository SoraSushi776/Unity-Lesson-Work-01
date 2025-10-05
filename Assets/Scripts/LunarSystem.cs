using UnityEngine;

public class LunarSystem : MonoBehaviour
{
    public float speed;
    public Transform sun, moon, earth;
    
    void Update()
    {
        sun.Rotate(Vector3.up * Time.deltaTime * speed * 0.5f);
        moon.Rotate(Vector3.up * Time.deltaTime * speed * 1.2f);
        earth.Rotate(Vector3.up * Time.deltaTime * speed  * 1f);
        
        // 地球围绕太阳旋转
        earth.RotateAround(sun.localPosition, Vector3.up, Time.deltaTime * speed  * 1f);
        
        // 月球围绕地球旋转
        moon.RotateAround(earth.localPosition, Vector3.up, Time.deltaTime * speed * 1.2f);
    }
}
