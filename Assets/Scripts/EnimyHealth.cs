using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimyHealth : MonoBehaviour
{
    [SerializeField] private float health = 5f;
    // Start is called before the first frame update

    public void TakeDamage(float damageAmount){
        health -= damageAmount;
        if (health <= 0f){
            Destroy(gameObject);
        }
    }
}
