using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtack : MonoBehaviour
{
    [SerializeField] GameObject swordPrefab;
    bool isSwordActive = false;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isSwordActive)
        {
            ActivateSword();
        }
        else if (Input.GetMouseButtonUp(0) && isSwordActive)
        {
            DeactivateSword();
        }
    }
    
    void ActivateSword()
    {
        isSwordActive = true;
        GameObject sword = Instantiate(swordPrefab, transform.position, Quaternion.identity);
        sword.transform.parent = transform;
    }
    
    void DeactivateSword()
    {
        isSwordActive = false;
        Destroy(transform.GetChild(0).gameObject);
    }
}

