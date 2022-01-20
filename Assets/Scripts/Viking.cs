using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Viking : MonoBehaviour
{
    private Vector3 targetPosition;

    public float moveLength = 0.7f;
    public float moveSpeed = 100f;
    public int healt = 5;

    public Text healtDisplay;

    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healtDisplay.text = healt.ToString();

        if (healt <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
            Destroy(GameObject.Find("ScoreManager"));
            Destroy(GameObject.Find("Spawner"));
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y<0.4) 
        {
            targetPosition = new Vector3(transform.position.x, transform.position.y + moveLength, transform.position.z);
            transform.position = targetPosition;
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > -0.9)
        {
            targetPosition = new Vector3(transform.position.x, transform.position.y - moveLength, transform.position.z);
            transform.position = targetPosition;
        }
    }
}
