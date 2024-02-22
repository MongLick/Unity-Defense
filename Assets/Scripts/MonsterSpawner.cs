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
        // 스폰 진행
        routine = StartCoroutine(SpawnRoutine());
    }

    private void OnDisable()
    {
        // 스폰 막기
        StopCoroutine(routine);
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            // 초 기다렸다
            yield return new WaitForSeconds(repeatTime);
            // 몬스터 하나 스폰
            Monster monster = Instantiate(monsterPrefab, startPoint.position, Quaternion.identity);
            monster.MoveTo(endPoint.position);
        }
    }
}
