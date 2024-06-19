using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CowAi : MonoBehaviour
{

    private NavMeshAgent agent;


    private Vector3 walkPoint;

    private float addition = 20f;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        //float addPoint = transform.position.z + addition;

        walkPoint = new Vector3(transform.position.x, transform.position.y, transform.position.z - addition);

        agent.SetDestination(walkPoint);

        StartCoroutine(CowDestroyed(20f));

    }


    private IEnumerator CowDestroyed(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);

    }
}
