using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public enum AIState
{
    Idle,
    Wandering,
    Attacking,
}


public class RangedEnemy : MonoBehaviour
{

    [Header("Stats")]
    public int health;
    public float walkSpeed;
    public float runSpeed;

    public float fieldOfView = 120f;

    [Header("Wandering")]
    public float minWanderDistance;
    public float maxWanderDistance;
    public float minWanderWaitTime;
    public float maxWanderWaitTime;


    [Header("AI")]
    private AIState aiState;
    public float detectDistance;

    [Header("Combat")]
    public int damage;
    public float attackRate;
    public float attackDistance;
    private float playerDistance;


    private NavMeshAgent agent;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        SetState(AIState.Wandering);
    }


    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void SetState(AIState state)
    {
        aiState = state;

        switch (aiState)
        {
            case AIState.Idle:
                agent.speed = walkSpeed;
                agent.isStopped = true;
                break;
            case AIState.Wandering:
                agent.speed = walkSpeed;
                agent.isStopped = false;
                break;
            case AIState.Attacking:
                agent.speed = runSpeed;
                agent.isStopped = true;
                break;
          
        }

        animator.speed = agent.speed / walkSpeed;
    }


    void AttackingUpdate()
    {
        if (playerDistance < attackDistance || !IsPlayerInFieldOfView())
        {
            agent.isStopped = true;

            // ���� ���� �߰�
            // ������Ʈ Ǯ �̿��ؼ� źȯ �߻�
            // ��ڻ� https://youtu.be/9X13qf62UQA?si=KEJw_emOGUl8CPLP ����? 


        }
        else
        {

            //�÷��̾�κ��� �־����� ��. ���?

            agent.isStopped = true;


        }
    }

    bool IsPlayerInFieldOfView()
    {
        Vector3 directionToPlayer = CharacterManager.Instance.Player.transform.position - transform.position;
        float angle = Vector3.Angle(transform.forward, directionToPlayer);
        return angle < fieldOfView * 0.5f;
    }


    void PassiveUpdate()
    {
        if (aiState == AIState.Wandering && agent.remainingDistance < 0.1f)
        {
            SetState(AIState.Idle);
            Invoke("WanderToNewLocation", Random.Range(minWanderWaitTime, maxWanderWaitTime));
        }

        if (playerDistance < detectDistance)
        {
            SetState(AIState.Attacking);
        }
    }

  


}
