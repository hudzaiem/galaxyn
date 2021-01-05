using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchMovement : MonoBehaviour
{
    public float move = 5f;
	public int health;
    public GameObject[] heart;

    public GameObject PopUp;
    public bool aktif;
    public Rigidbody2D rb;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * move * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision){
		if(collision.gameObject.tag == "Enemy"){
			damage(1);
            Destroy(heart[health].gameObject);
		}
	}
    	void damage(int nyawa){
		health -= nyawa;
		if (health == 0){
			Destroy(gameObject);
            PopUp.SetActive(aktif);

		}
	}
}
