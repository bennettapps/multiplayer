using FishNet.Object;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : NetworkBehaviour
{
    public float movespeed = 5;
    CharacterController controller;

	private void Awake () {
        controller = GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update()
    {
        if (!IsOwner) return;

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 offset = new Vector3(horizontal, Physics.gravity.y, vertical) * movespeed * Time.deltaTime;
        controller.Move(offset);
    }
}
