using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStat : MonoBehaviour
{

    public int health;

    public int MaxHealth;



    // Start is called before the first frame update
    void Start()
    {
        health = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TakeDamage(int damage)
    {
        health -= damage;

        if (health < 0)
        {
            Destroy(gameObject);
        }
    }
}
