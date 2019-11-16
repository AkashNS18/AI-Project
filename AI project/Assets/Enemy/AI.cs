using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public GameObject enemy;
    public void Start()
    {
        enemy.GetComponent<Animator>().Play("idle");
        enemy.GetComponent<NavMeshAgent>().enabled = false;
    }
    void OnTriggerEnter(Collider other)
    {
        enemy.GetComponent<Animator>().Play("attack");
       // enemy.GetComponent<Enemy>().enabled = false;
        enemy.GetComponent<NavMeshAgent>().enabled = false;
    }
    void OnTriggerExit(Collider other)
    {
        enemy.GetComponent<Animator>().Play("walking");
       //enemy.GetComponent<Enemy>().enabled = true;
        enemy.GetComponent<NavMeshAgent>().enabled = true;
    }
}
