using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{

    private Rigidbody foodRb;

    public GameObject food;

    public GameObject foodPoint;

    public float Speed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        foodRb = food.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bool Throw = Input.GetButtonDown("Jump");
        if (Throw)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(food, foodPoint.transform.position, foodPoint.transform.rotation);

        foodRb.AddForce(foodPoint.transform.forward * Speed);


    }

}
