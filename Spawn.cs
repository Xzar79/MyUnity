using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] points;
    //몬스터 프리팹을 할당할 변수

    public GameObject weapon1, weapon2, weapon3, weapon4, weapon5, weapon6, weapon7, weapon8;
    int whatToSpawn;

    //몬스터를 발생시킬 주기
    public float createTime;
    //무기의 최대 발생 개수
    public int maxWeapon = 1;
    //게임 종료 여부 변수
    public bool isGameOver = false;

    // Use this for initialization
    void Start()
    {
        //Hierarchy View의 Spawn Point를 찾아 하위에 있는 모든 Transform 컴포넌트를 찾아옴
        points = GameObject.Find("WeaponSpawner").GetComponentsInChildren<Transform>();

        if (points.Length > 0)
        {
            //몬스터 생성 코루틴 함수 호출
            StartCoroutine(this.CreateMonster());
        }
    }

    IEnumerator CreateMonster()
    {
        //게임 종료 시까지 무한 루프
        while (!isGameOver)
        {
            //현재 생성된 총의 개수 산출
            int monsterCount = (int)GameObject.FindGameObjectsWithTag("Weapon").Length;


            if (monsterCount < maxWeapon)
            {

                //몬스터의 생성 주기 시간만큼 대기
                yield return new WaitForSeconds(createTime);

                whatToSpawn = Random.Range(1, 8);

                switch (whatToSpawn)
                {
                    case 1:
                        Instantiate(weapon1, transform.position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(weapon2, transform.position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(weapon3, transform.position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(weapon4, transform.position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(weapon5, transform.position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(weapon6, transform.position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(weapon7, transform.position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(weapon8, transform.position, Quaternion.identity);
                        break;
                }

            }
            else
            {
                yield return null;
            }
        }
    }

    

    // [출처] [Unity] 게임 매니저를 이용한 몬스터 리스폰 구현|작성자 로봇매냐
}
