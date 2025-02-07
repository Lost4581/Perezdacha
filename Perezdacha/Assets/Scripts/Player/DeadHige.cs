using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadHige : MonoBehaviour
{
    [SerializeField] private GameObject RestartPanel;
    public int hight;

    void Update()
    {
        if (transform.position.y <= hight)
        {
            RestartPanel.SetActive(true);
        }
    }
}
