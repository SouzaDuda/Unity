using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{

private NavMeshAgent playerNavMeshAgent; //declaração do navmesh

void Start()
{
    playerNavMeshAgent = GetComponent<NavMeshAgent>();

}

void Update()
{

    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    RaycastHit rayhit;

    if (Input.GetMouseButtonDown(0))
    {

        if (Physics.Raycast(ray, out rayhit, 200f))
        {

            playerNavMeshAgent.destination = rayhit.point;
        }

    }

}
}
