using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;
using UnityEngine.Events;
public class CapsuleCharacter : MonoBehaviour
{
    public UnityEvent onClickEvent;
    NavMeshAgent agent;
    bool sus;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(RandomPos());
        CapsuleManager.instance.onCallallCapsulesSuscribed += Jump;
        sus = true;
    }

    public void Jump()
    {
        agent.isStopped = true;
        transform.DOJump(transform.position, 3, 2, 2);
    }
    public void OnMouseDown()
    {
        onClickEvent?.Invoke();
        if (sus)
        {
            CapsuleManager.instance.onCallallCapsulesSuscribed -= Jump;
            sus = false;
        }
        else if(!sus)
        {
            CapsuleManager.instance.onCallallCapsulesSuscribed += Jump;
            sus = true;
        }

       
    }

    IEnumerator RandomPos()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(2, 5));
            agent.isStopped = false;
            
            agent.SetDestination(new Vector3(transform.position.x + Random.Range(-10, 10),
                transform.position.y, transform.position.z + Random.Range(-10, 10)));
        }
    }

}
