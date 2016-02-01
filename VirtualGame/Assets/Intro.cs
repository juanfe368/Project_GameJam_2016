using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Intro : MonoBehaviour {

    public GameObject she;
    public GameObject he;
    public Vector3 waitPosition;
    public Vector3 watchPosition;
    public Vector3 breakPosition;
    public UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter m_Character;
    public int speed = 20;
    private Animator m_Animator;
    private bool vanish;
    private Renderer sheRenderer;
    float steper = 3f;


    [SerializeField] float m_AnimSpeedMultiplier = 1f;

    void Start () {
        sheRenderer = she.GetComponent<Renderer>();
    }
	
	void Update () {
	    if(Vector3.Distance(he.transform.position,watchPosition) > 5)
        {
            float step = speed * Time.deltaTime;
            //he.transform.position = Vector3.MoveTowards(he.transform.position, waitPosition, step);
            m_Character.Move(new Vector3(step, 0,0),false,false);
            //m_Animator.SetFloat("Forward", step, 0.1f, Time.deltaTime);
            //m_Animator.speed = m_AnimSpeedMultiplier;
        }
        else
        {
            vanish = true;
        }
        if (vanish)
        {
            steper -= Time.deltaTime;
            Debug.Log(steper);
            if(steper <= 0f)
            {
                Application.LoadLevel("PrimeraEscena"); 
                //she.transform.Translate
                //sheRenderer.enabled = false;
            }
        }
    }
}
