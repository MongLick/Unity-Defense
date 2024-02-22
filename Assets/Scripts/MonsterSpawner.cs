using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField] Monster monsterPrefab;
    [SerializeField] float repeatTime;
    [SerializeField] Transform startPoint;
    [SerializeField] Transform endPoint;


    Coroutine routine;

    private void OnEnable()
    {
        // ���� ����
        routine = StartCoroutine(SpawnRoutine());
    }

    private void OnDisable()
    {
        // ���� ����
        StopCoroutine(routine);
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            // �� ��ٷȴ�
            yield return new WaitForSeconds(repeatTime);
            // ���� �ϳ� ����
            Monster monster = Instantiate(monsterPrefab, startPoint.position, Quaternion.identity);
            monster.MoveTo(endPoint.position);
        }
    }
}
