using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;

    public void MoveTo(Vector3 endPoint)
    {
        agent.destination = endPoint;
    }

}
