using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Vector3 myPos;

    // Start is called before the first frame update
    void Start()
    {
        myPos = new Vector3(0, 0, 0);
        transform.position = myPos;
    }

    // Update is called once per frame
    void Update()
    {
        MovementToScale(KeyCode.W, Vector3.one);


        MovementToRotation(KeyCode.R, new Vector3(45, 0, 45));

    }

    public void MovementToScale(KeyCode key, Vector3 scale)
    {
        if (Input.GetKeyDown(key))
        {
            transform.localScale += scale;
        }
    }

    public void MovementToRotation(KeyCode key, Vector3 axis)
    {
        if (Input.GetKeyDown(key))
        {
            transform.rotation *= Quaternion.Euler(axis);
        }
    }
}
