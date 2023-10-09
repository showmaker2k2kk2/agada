using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class EnemyAi : charracter
{
    public NavMeshAgent agent;
    public Transform[] diemden;
    public Transform player;
    private charracter character;


    private int diempointhenai;
    public float speed;

    public bool dcphepdichuyendenpoint;
    public float phamvitancong = 5f;

    bool onfollow=false;

    //Vector3 phamvitancong=


    private void Start()
    {
        base.Start();
        agent = GetComponent<NavMeshAgent>();
        diempointhenai = 0;
        dichuyenwaypoint();
        //dcphepdichuyendenpoint = true;
     

    }
    private void Update()
    {
        GameObject player = GameObject.FindWithTag("player");
        if (player == null)

        {
            return;
        }
        float khoangcachdung = Vector3.Distance(transform.position, player.transform.position);
        float khoangcachbancuaenemy = Vector3.Distance(transform.position, player.transform.position);
        if (!agent.pathPending && agent.remainingDistance < 0.1f)
        {

            dichuyenwaypoint();
        }
        
        if (khoangcachbancuaenemy <= phamvitancong)
        {
            attack();
            onfollow = true;
            agent.isStopped = true;
            return;
       }
        if(onfollow&&khoangcachbancuaenemy>phamvitancong)
        {
            duoitheoplayer();
        }       

    }
    float count;
    private void attack()
    {


        Debug.Log("hahahahahah");
    }

    void dichuyenwaypoint()
    {

        agent.SetDestination(diemden[diempointhenai].position);

        diempointhenai++;
        if (diempointhenai >= diemden.Length)
            diempointhenai = 0;

    } 

    void duoitheoplayer()
    {
      
        if(player!=null)
        {

            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        }    
        
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("bulet"))
        {
            TakeDame(dameshoogun);
        }
    }
}   
