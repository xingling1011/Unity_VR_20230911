//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class EenemyAI : MonoBehaviour
{
    [Header("怪物代理器")]
    public NavMeshAgent agent;
    [Header("玩家物件")]
    public Transform player;
    [Header("移動速度"),Range(0,5)]
    public float moveSpeed = 2.5f;
    [Header("停止距離"), Range(0,5)]
    public float stopDistance = 1;
    [Header("動畫控制器")]
    public Animator ani;
    [Header("延遲造成傷害"), Range(0, 5)]
    public float delayDamage = 0.6f;
    [Header("攻擊冷卻"), Range(0, 5)]
    public float cd = 2.1f;

    private string parMove = "移動";
    private string parAtack = "攻擊";
    private bool canAttack = true;

    private void Awake()
    {
        //代理器的移動速度 = 移動速度
        agent.speed = moveSpeed;
        //代理器的停止距離 = 停止距離
        agent.stoppingDistance = stopDistance;
    }
    private void Update()
    {
        //怪物代理器.設定目的地(玩家的座標)
        agent.SetDestination(player.position);
        //移動值=代理器.加速度.轉換成浮點數(大小)
        float move = agent.velocity.magnitude;
        //動畫控制器.設定浮點數(浮點數參數，浮點數值)
        ani.SetFloat(parMove, move);

        //print($"<color=#f50>移動速度:{agent.velocity.magnitude}</color>");
        float distance = Vector3.Distance(transform.position, player.position);
        //print($"<color=#96f>距離:{distance}</color>");

        //如果移動速度 = 0 並且可以攻擊 就 攻擊 
        //canAttack == true 可以簡寫成 canAttack
        if (agent.velocity.magnitude==0 && canAttack && distance < stopDistance)
        {
            ani.SetTrigger(parAtack); 
            
            //不能攻擊
            canAttack = false;

            StartCoroutine(Attack());
        }

    }

    private IEnumerator Attack()
    {
        //代理器停止
        agent.isStopped = true;
        //播放攻擊動畫
        ani.SetTrigger(parAtack);
        //等0.4秒
        yield return new WaitForSeconds(0.4f);
        //造成玩家傷害
        print("<color=#f69>造成玩家傷害!</color>");
        //等2.1秒
        yield return new WaitForSeconds(2.1f);
        //恢復可攻擊狀態
        canAttack = true;
        //代理器恢復
        agent.isStopped = false;
    }

    }


