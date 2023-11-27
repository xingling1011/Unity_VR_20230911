//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EenemyAI : MonoBehaviour
{
    [Header("�Ǫ��N�z��")]
    public NavMeshAgent agent;
    [Header("���a����")]
    public Transform player;
    [Header("���ʳt��"),Range(0,5)]
    public float moveSpeed = 2.5f;
    [Header("����Z��"), Range(0,5)]
    public float stopDistance = 1;
    [Header("�ʵe���")]
    public Animator ani;

    private string parMove = "����";
    private string parAtack = "����";
    private bool canAttack = true;

    private void Awake()
    {
        //�N�z�������ʳt�� = ���ʳt��
        agent.speed = moveSpeed;
        //�N�z��������Z�� = ����Z��
        agent.stoppingDistance = stopDistance;
    }
    private void Update()
    {
        //�Ǫ��N�z��.�]�w�ت��a(���a���y��)
        agent.SetDestination(player.position);
        //���ʭ�=�N�z��.�[�t��.�ഫ���B�I��(�j�p)
        float move = agent.velocity.magnitude;
        //�ʵe���.�]�w�B�I��(�B�I�ưѼơA�B�I�ƭ�)
        ani.SetFloat(parMove, move);

        //print($"<color=#f50>���ʳt��:{agent.velocity.magnitude}</color>");
        float distance = Vector3.Distance(transform.position, player.position);
        //print($"<color=#96f>�Z��:{distance}</color>");

        //�p�G���ʳt�� = 0 �åB�i�H���� �N ���� 
        //canAttack == true �i�H²�g�� canAttack
        if (agent.velocity.magnitude==0 && canAttack && distance < stopDistance)
        {
            ani.SetTrigger(parAtack); 
            
            //�������
            canAttack = false;
        }

    }
}


