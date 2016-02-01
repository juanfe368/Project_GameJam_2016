using UnityEngine;
using System.Collections;

public class ControlGUIScript : MonoBehaviour
{

    public GameObject personaje;
    //public float Value;
    public float Fade = 0.01f;

    public GUIBarScript GBS;

    public Vector2 Offset;

    public Vector2 LabelOffSet;

    public string playText = "Play";
    public bool IsPlaying = false;
    public string nombreEscena = "personajeEscene";

    void Start()
    {
        //value = personaje.GetComponent<VidaScript>().vidaPersonaje/100;
        //  Value = personaje.GetComponent<VidaScript>().vidaPersonaje;
        GBS = GetComponent<GUIBarScript>();
    }

    void OnGUI()
    {
        if (GBS == null)
        {
            return;
        }

        if (IsPlaying != true)
        {
            GUIStyle LabelStyle = new GUIStyle();
            LabelStyle.normal.textColor = Color.black;
            LabelStyle.fontSize = 18;
            GUI.Label(new Rect(GBS.Position.x + Offset.x + LabelOffSet.x, GBS.Position.y + Offset.y + LabelOffSet.y - 40, 100, 25), "Value", LabelStyle);
            if (personaje != null) { 
            personaje.GetComponent<VidaScript>().vidaPersonaje = GUI.HorizontalSlider(new Rect(GBS.Position.x + Offset.x, GBS.Position.y + Offset.y - 40, 180, 25), personaje.GetComponent<VidaScript>().vidaPersonaje, 0.0F, 1F);
            }
        }
         
        if (GUI.Button(new Rect(GBS.Position.x + Offset.x + LabelOffSet.x, GBS.Position.y + Offset.y + LabelOffSet.y - 80, 100, 25), playText))
        {
            if (IsPlaying == true)
            {
                IsPlaying = false;
                playText = "Play";
            }
            else
            {
                IsPlaying = true;
                playText = "Stop";
            }

        }

    }

    void Update()
    {
        if (personaje != null)
        {
            if (personaje.GetComponent<VidaScript>() != null && (personaje.GetComponent<VidaScript>().vidaPersonaje) < 0)
            {//HA MUERTO EL PERSONAJE

               
                //Debug.Log("CESAR: ENTRO AL LOAD DE BACKGROUND");
                Application.LoadLevel(nombreEscena);
                // Debug.Log("CESAR: VALOR VALUE:" + personaje.GetComponent<VidaScript>().vidaPersonaje);

            }
            else
            {//TODAVIA TIENE VIDA
             // Debug.Log("CESAR: TIENE VIDA:" + personaje.GetComponent<VidaScript>().vidaPersonaje);
                personaje.GetComponent<VidaScript>().vidaPersonaje -= 0.001f;
            }
            if (GBS == null)
            {
                return;
            }

            if (IsPlaying == true)
            {
                GBS.Value = ((Mathf.Sin(Time.time) / 2f) + 0.5f) * 1.01f;
            }
            else
            {
                GBS.Value = personaje.GetComponent<VidaScript>().vidaPersonaje;
            }
        }
    }
}
