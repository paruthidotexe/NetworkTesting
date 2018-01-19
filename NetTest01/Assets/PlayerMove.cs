using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class PlayerMove : NetworkBehaviour
{

    public MeshRenderer meshRenderer;

    void Start () {
		
	}

    void Update()
    {
        if (!isLocalPlayer)
            return;

        var x = Input.GetAxis("Horizontal") * 0.1f;
        var z = Input.GetAxis("Vertical") * 0.1f;

        transform.Translate(x, 0, z);
    }


    public override void OnStartLocalPlayer()
    {
        meshRenderer.material.color = Color.red;
    }

}
