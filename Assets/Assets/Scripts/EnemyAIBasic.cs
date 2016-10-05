using UnityEngine;
using System.Collections;

public class EnemyAIBasic : MonoBehaviour 
{
	public GameObject player;
	public float speed;
	public float variable;
	private Vector2 playerdirection;
	private Rigidbody2D rb2d;
	private float Xdif;
	private float Ydif;


	// Use this for initialization
	void Start () 
		{
		rb2d = GetComponent<Rigidbody2D>();
		}
	
	// Update is called once per frame
	void Update () 
		{
		Xdif = player.transform.position.x - transform.position.x;
		Ydif = player.transform.position.y - transform.position.y;

		playerdirection = new Vector2 (Xdif, Ydif);
		rb2d.AddForce (playerdirection.normalized * speed);
		}
}
