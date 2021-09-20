using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    public NavMeshAgent enemy;
    bool routineStarted = false;
    [SerializeField] public bool isHit = false;
    public Transform player;
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isHit)
        {
            print("Zombie is hit");
            GetComponent<Animator>().SetBool("isHit", true);
            Destroy(gameObject, GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
        } 
        else
        {
            enemy.SetDestination(player.position);
            //Vector3 direction = player.position - transform.position;
            //Debug.Log(direction);
        }
    }
}
