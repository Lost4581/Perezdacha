using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoForPlayer : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;
    [SerializeField] private float followSpeed = 5f;
    [SerializeField] private Vector3 offset;

    void LateUpdate()
    {
        if (targetObject != null)
        {
            Vector3 targetPosition = transform.position + offset;
            targetObject.transform.position = Vector3.Lerp(targetObject.transform.position, targetPosition, followSpeed * Time.deltaTime);
        }
    }   
}
