using UnityEngine;
using System.Collections;

public class MoveCameraScript : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
            transform.position = new Vector3(player.position.x + offset.x, offset.y, offset.z);
        //ansform.position = Vector3.Lerp (transform.position,new Vector3(Mathf.Sin (Time.time / 5f) * 5f,transform.position.y,transform.position.z),1* Time.deltaTime);
    }
}
