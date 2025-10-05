using UnityEngine;
using UnityEngine.AI;

public class AIFollowPlayer : MonoBehaviour
{
    public Transform playerTarget;
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (playerTarget != null)
        {
            navMeshAgent.SetDestination(playerTarget.position);
        }
    }
}