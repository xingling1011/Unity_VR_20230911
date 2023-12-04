//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Collections;

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
    [Header("����y���ˮ`"), Range(0, 5)]
    public float delayDamage = 0.6f;
    [Header("�����N�o"), Range(0, 5)]
    public float cd = 2.1f;

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

            StartCoroutine(Attack());
        }

    }

    private IEnumerator Attack()
    {
        //�N�z������
        agent.isStopped = true;
        //��������ʵe
        ani.SetTrigger(parAtack);
        //��0.4��
        yield return new WaitForSeconds(0.4f);
        //�y�����a�ˮ`
        print("<color=#f69>�y�����a�ˮ`!</color>");
        //��2.1��
        yield return new WaitForSeconds(2.1f);
        //��_�i�������A
        canAttack = true;
        //�N�z����_
        agent.isStopped = false;
    }

    }


