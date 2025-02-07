using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private List<TeleportPoint> points = new List<TeleportPoint>();

    private void OnCollisionEnter2D(Collision2D collision)
    {
        foreach (var point in points)
        {
            if (collision.gameObject == point.teleportObject)
            {
                collision.gameObject.transform.position = point.teleportPosition;
                break;
            }
        }
    }

    [System.Serializable]
    private class TeleportPoint
    {
        public GameObject teleportObject;
        public Vector2 teleportPosition;
    }
}

