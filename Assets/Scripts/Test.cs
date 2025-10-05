using UnityEngine;

public class Test : MonoBehaviour
{
    private float _count = 0;
    void Start()
    {
        /*
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
        
        Debug.Log("Hello World!");
        Debug.LogWarning("Warning!");
        Debug.LogError("Error!");
        */
        
        // 用名字查找物体
        GameObject findGameObjectByName = GameObject.Find("ScriptObject");
        Debug.Log(findGameObjectByName.name);
        
        // 用 Tag 查找物体
        GameObject findGameObjectByTag = GameObject.FindGameObjectWithTag("Sample");
        Debug.Log(findGameObjectByTag.name);
        
        // 遍历查找
        GameObject[] findGameObjectsByTag = GameObject.FindGameObjectsWithTag("Sample");
        foreach (GameObject gameObject in findGameObjectsByTag)
        {
            Debug.Log(gameObject.transform.position);
        }
    }

    void Update()
    {
        /*
        Debug.Log($"{Mathf.RoundToInt(_count)}: Calling Update");
        _count += Time.deltaTime;
        */
    }
}
