using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    
    void Update()
    {
        var direction = new Vector3();
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        direction.Normalize();

        transform.position += direction * speed * Time.deltaTime;

        

    }

    
}
