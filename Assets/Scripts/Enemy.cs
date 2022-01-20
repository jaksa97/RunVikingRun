using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 1;
    public float moveSpeed = 5f;

    public GameObject effect;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Viking"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            collider.GetComponent<Viking>().healt -= damage;
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }
}
