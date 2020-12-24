using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columns : MonoBehaviour
{
    
    public float speed = 5f;
    [SerializeField]
    public float height = 0.5f;

    Vector2 pos;

    private void Start()
    {
        pos = transform.position;
    }
    void Update()
    {

        //calculate what the new Y position will be
        float newY = Mathf.Sin(Time.time * speed) * height + pos.y;
        //set the object's Y to the new calculated Y
        transform.position = new Vector2(transform.position.x, newY);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<bird>() != null)
        {
           
            GameController.instance.BirdScored();
        }
    }
}
