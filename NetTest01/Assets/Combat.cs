using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Combat : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public const int maxHealth = 100;
    [SyncVar]
    public int health = maxHealth;

    public void TakeDamage(int amount)
    {
        Debug.Log("health = " + health);
        if (!isServer)
            return;

        health -= amount;
        if (health <= 0)
        {
            health = maxHealth;
            RpcRespawn();
        }
    }



    [ClientRpc]
    void RpcRespawn()
    {
        if (isLocalPlayer)
        {
            // move back to zero location
            transform.position = Vector3.zero;
        }
    }


}
