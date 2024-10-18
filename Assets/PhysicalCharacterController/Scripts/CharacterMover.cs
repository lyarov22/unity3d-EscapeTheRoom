using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMover : MonoBehaviour
{
    public Transform pointA; // ����� A
    public Transform pointB; // ����� B
    private NavMeshAgent agent; // NavMeshAgent

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        MoveToNextPoint(); // �������� �������� � ������ �����
    }

    void MoveToNextPoint()
    {
        // �������� ��������� �����
        if (agent.destination == pointA.position)
        {
            agent.SetDestination(pointB.position);
        }
        else
        {
            agent.SetDestination(pointA.position);
        }
    }

    void Update()
    {
        // ���������, ������ �� ����� ����
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            MoveToNextPoint(); // ������������� �� ��������� �����
        }
    }
}
