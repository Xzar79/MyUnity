using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeChara : MonoBehaviour
{

    public GameObject kasumi;
    public GameObject miku;
    public GameObject rubi;
    public GameObject tina;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D obj)
    {
        if(obj.gameObject.name == "awm(Clone)")
        {
            Destroy(obj.gameObject); // 총 파괴
            Destroy(this.gameObject); // 플레이어 파괴
            Instantiate(miku, transform.position, Quaternion.identity); //새로운 플레이어 생성
        }

        else if(obj.gameObject.name == "ak47(Clone)")
        {
            Destroy(obj.gameObject);
            Destroy(this.gameObject);
            Instantiate(rubi, transform.position, Quaternion.identity);
        }

        else if(obj.gameObject.name == "uzi(Clone)")
        {
            Destroy(obj.gameObject);
            Destroy(this.gameObject);
            Instantiate(tina, transform.position, Quaternion.identity);
        }

        else if(obj.gameObject.name == "k5(Clone)")
        {
            Destroy(obj.gameObject);
            Destroy(this.gameObject);
            Instantiate(tina, transform.position, Quaternion.identity);
        }

        else if (obj.gameObject.name == "k5(Clone)")
        {
            Destroy(obj.gameObject);
            Destroy(this.gameObject);
            Instantiate(tina, transform.position, Quaternion.identity);
        }

        else if (obj.gameObject.name == "m4(Clone)")
        {
            Destroy(obj.gameObject);
            Destroy(this.gameObject);
            Instantiate(tina, transform.position, Quaternion.identity);
        }

        else if (obj.gameObject.name == "m16a4(Clone)")
        {
            Destroy(obj.gameObject);
            Destroy(this.gameObject);
            Instantiate(tina, transform.position, Quaternion.identity);
        }

        else if (obj.gameObject.name == "knife1(Clone)")
        {
            Destroy(obj.gameObject);
            Destroy(this.gameObject);
            Instantiate(tina, transform.position, Quaternion.identity);
        }

        else if (obj.gameObject.name == "ump9(Clone)")
        {
            Destroy(obj.gameObject);
            Destroy(this.gameObject);
            Instantiate(tina, transform.position, Quaternion.identity);
        }
    }

    

}
