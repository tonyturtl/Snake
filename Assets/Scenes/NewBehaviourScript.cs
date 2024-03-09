using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{


    //variables
     
    //direction variables
    
    private Vector2 direction;
bool goingUp;
bool goingDown;
bool goingLeft;
bool goingRight;

    List<Transform> segments;
     public Transform bodyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        segments = new List<Transform>();
        segments.Add(transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) && goingDown != true)
        {
            direction = Vector2.up;
            goingUp=true;
            goingDown=false;
            goingLeft=false;
            goingRight=false;
        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) && goingRight != true)
        {
            direction = Vector2.left;
            goingLeft=true;
            goingRight=false;
            goingUp=false;
            goingDown=false;
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) && goingUp != true)
        {
            direction = Vector2.down; 
            goingDown=true;
            goingLeft=false;
            goingRight=false;
            goingUp=false;
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) && goingLeft != true)
        {
            direction = Vector2.right; 
            goingRight=true;
            goingLeft=false;
            goingUp=false;
            goingDown=false;
        }
    }   
       
    void FixedUpdate()
    {
        for (int i = segments.Count - 1; i>0; i--)
        {
            segments[i].position = segments [i - 1].position;
        }
        
        transform.position = new Vector2
        (Mathf.Round(transform.position.x) + direction.x,
        Mathf.Round(transform.position.y) + direction.y);

    }
    void Grow()
    {
        Transform segment = Instantiate(bodyPrefab);
        segment.position = segments[segments.Count - 1].position;
        segments.Add(segment);      
    }



    void OnTriggerEnter2D (Collider2D other)
    {  
      
      if (other.tag == "Food")
        {
            Debug.Log("hit");
            Grow();
        }
        else if (other.tag == "Obstacle")
        {
            SceneManager.LoadScene("end scene");
        }
    }
}
