using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticEnemy : MonoBehaviour
{
    [field: SerializeField] public int Damage { get; private set; }
    public bool CanDamage { get; private set; }
    private SpriteRenderer _spriteRenderer;
    private bool _isSwordCollision;

    private void Awake()
    {
        CanDamage = true;
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Sword"))
        {
            _isSwordCollision = true;
        }
        if (_isSwordCollision)
        {
            CanDamage = false;
            _spriteRenderer.color = Color.white;
        }
    }

}

