using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rigid;

    void Start(){

        rigid = GetComponent<Rigidbody>();
        //rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate(){
        //rigid.velocity = new Vector3(2, 4, 3); // 속력 바꾸기

        if (Input.GetButtonDown("Jump")) {
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
            Debug.Log(rigid.velocity);
        }

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);

        // 회전력
        //rigid.AddTorque(Vector3.back);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "cube") {
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
        }
    }

    public void Jump() {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}
