using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour {

    public GameObject she;
    public GameObject he;
    public Vector3 waitPosition;
    public Vector3 watchPosition;
    public Vector3 breakPosition;
    public int speed = 20;
    private Animator m_Animator;
    private bool vanish;
    private Renderer sheRenderer;

    void Start () {
        sheRenderer = she.GetComponent<Renderer>();
	}
	
	void Update () {
        m_Animator = he.GetComponent<Animator>();
        Debug.Log(Vector3.Distance(he.transform.position, watchPosition));
	    if(Vector3.Distance(he.transform.position,watchPosition) > 5)
        {
            float step = speed * Time.deltaTime;
            m_Animator.SetFloat("Forward", step, 0.1f, Time.deltaTime);
            he.transform.position = Vector3.MoveTowards(he.transform.position, waitPosition, step);
        }
        else
        {
            vanish = true;
        }
        if (vanish)
        {
            int steper = 0;
            
            if(steper <= 2) {
                sheRenderer.enabled = false;
                
            }
               
        }
    }
}
