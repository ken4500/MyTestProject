using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 6.0f;
	public float jumpSpeed = 6.0f;
	public float gravity = 20.0f;

	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {

        //移動方向を取得
        transform.Rotate(0, Input.GetAxis("Horizontal") * 360 * Time.deltaTime, 0);
        transform.position += transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime;

        if (controller.isGrounded)
        {


            //ジャンプ
            if (Input.GetKeyDown(KeyCode.Space))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        // 重力を計算
        moveDirection.y -= gravity * Time.deltaTime;

        // 移動
        controller.Move(moveDirection * Time.deltaTime);
    }
}


