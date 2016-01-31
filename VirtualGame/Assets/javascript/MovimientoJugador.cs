using UnityEngine;
using System.Collections;

public class MovimientoJugador : MonoBehaviour {

    public float moveSpeed = 100.0f;      // Audio clip of the player shouting.
    public float jumpForce = 1000f;

    private Animator anim;              // Reference to the animator component.
 

    // Use this for initialization
    void Start()
    {
        Debug.Log("CESAR: Start ");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((Vector3.forward)*moveSpeed * Time.deltaTime);
          
        if (Input.GetKeyDown("space")) {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
            Debug.Log("CESAR: Space Bar");
        }

     

     
    }
}


