using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{

    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    // 물리적 충돌이 생겼을때 실행
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "MyBall")
        {
            mat.color = new Color(0, 0, 0);
        }
    }

    /*// 물리적 충돌이 지속중일때 실행
    private void OnCollisionStay(Collision collision)
    {
        
    }*/

    // 물리적 충돌이 끝났을때 실행
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "MyBall")
        {
            mat.color = new Color(1, 1, 1);
        }
    }



    /*// 콜라이더 충돌로 발생하는 이벤트(겹치는등의 행위)
    private void OnTriggerEnter(Collider other){}
    private void OnTriggerStay(Collider other){}
    private void OnTriggerExit(Collider other){}

    // 실제 물리적인 충돌로 발생하는 이벤트
    private void OnCollisionEnter(Collision collision){}
    private void OnCollisionStay(Collision collision){}
    private void OnCollisionExit(Collision collision){}*/
}
