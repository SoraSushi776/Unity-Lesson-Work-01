using System;
using System.Collections;
using UnityEngine;

public class BuildABrickWall : MonoBehaviour
{
    public Transform brickPrefab;
    public float wallWidth = 5;
    public float wallHeight = 8;

    public void GenerateBrickWall()
    {
        Player.ResetPlayer();
        StartCoroutine(GenerateBrickWallCoroutineL2R());
        StartCoroutine(GenerateBrickWallCoroutineR2L());
    }

    IEnumerator GenerateBrickWallCoroutineL2R()
    {
        for (float x = 0.5f - wallWidth / 2; x < -0.5f; x+=1)
        {
            for (float y = 0.5f; y < wallHeight + 0.5f; y+=1)
            {
                Transform brick = Instantiate(brickPrefab);
                brick.position = new Vector3(x + 1f, y, 0);
            }
            // yield return new WaitForSeconds(0.05f);
        }
        
        yield return null;
    }
    
    IEnumerator GenerateBrickWallCoroutineR2L()
    {
        for (float x = (wallWidth / 2) + 0.5f; x > 0.5f; x-=1)
        {
            for (float y = 0.5f; y < wallHeight + 0.5f; y+=1)
            {
                Transform brick = Instantiate(brickPrefab);
                brick.position = new Vector3(x, y, 0);
            }
            // yield return new WaitForSeconds(0.05f);
        }
        
        yield return null;
    }
}
