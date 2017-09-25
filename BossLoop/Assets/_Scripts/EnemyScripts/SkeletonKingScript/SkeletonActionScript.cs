using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SkeletonActionScript : MonoBehaviour {

    public Rigidbody2D rigidbody;
    // Use this for initialization
    void Start () {
        rigidbody.freezeRotation = true;
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject player = collision.gameObject;
        Vector2 knockBackDirection = (player.transform.position - this.transform.position).normalized;
        getKnockedBack(player,knockBackDirection);
    }

    private void getKnockedBack(GameObject player,Vector2 KnockBackDirection)
    {
        //player.GetComponent<Rigidbody2D>().AddForce(KnockBackDirection * player.GetComponent<PlayerController>().speed, ForceMode2D.Impulse);
        Debug.Log("Osui");
    }

}
