using UnityEngine;
using System.Collections;

public class MovimientoJugador : MonoBehaviour {

    public float moveSpeed = 10f;      // Audio clip of the player shouting.
    public float jumpForce = 100f;
    public float jumping = 0;
    private Animator anim;
    // Reference to the ,animator component.
    public Rigidbody rigid;

    // Use this for initialization
    void Start()
    {
        Debug.Log("CESAR: Start ");
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((Vector3.forward)*moveSpeed * Time.deltaTime);
        if(jumping < 2) {   //SALTA SI NO HA DADO EL DOBLE SALTO
            if (Input.GetKeyDown("space")) {
                rigid.AddForce(Vector3.up * jumpForce);
              //  xrigidbody.AddForce(
              //  GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
                Debug.Log("CESAR: Space Bar");
                jumping++;
            }
            if(jumping == 2){ //TO DO : LOGICA CUANDO CAE AL SUELO
                jumping = 0;
            }
        }




    }
    
}


