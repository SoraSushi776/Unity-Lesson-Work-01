using System;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    private void OnEnable()
    {
        GetComponent<Renderer>().material.color = new Color(
            UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f));
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Player.RemovedCubeCount++;
        }
    }
}
