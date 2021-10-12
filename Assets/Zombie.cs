using FPSControllerLPFP;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

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

    void Awake()
    {
        //killCounterScript = GetComponent<KillCounterScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isHit)
        {
            print("Zombie is hit");
            GetComponent<Animator>().SetBool("isHit", true);
            Destroy(gameObject, GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
            isHit = false;
        } 
        else
        {
            enemy.SetDestination(player.position);
            //Vector3 direction = player.position - transform.position;
            //Debug.Log(direction);
        }
    }

    private void OnDestroy()
    {
        var killCounteScriptr = GameObject.Find("KillCounter").GetComponent<KillCounterScript>();
        killCounteScriptr.killCounter++;
        killCounteScriptr.UpdateKillCounter();

        //killCounterScript.killCounter++;
        //killCounterScript.UpdateKillCounter();
    }

}
