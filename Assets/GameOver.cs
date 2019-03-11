using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text Tempo;
    public float Tiempo = 0.0f;
    public bool DebeAumentar = false;
    public Text gameOver;
    float timer = 0;
    bool timerReached = false;
    // Start is called before the first frame update
    void Start()
    {
        gameOver.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (DebeAumentar)
            Tiempo += Time.deltaTime;
        // Primero se comprueba que sea falso el tener que aumentar.
        else
        {
            if (Tiempo <= 0.0f)  // Comprueba si es menor o igual a cero.
            {
                Tiempo = 0f;
                gameOver.text = "Game Over";
                //yield return new WaitForSeconds(2);
                //Invoke("DoSomething", 6);
                if (!timerReached)
                    timer += Time.deltaTime;

                if (!timerReached && timer > 3)
                {
                    Debug.Log("Done waiting");
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                    timerReached = true;
                }
                
                //DebeAumentar = true;
            } // Para volver true a este.
            else
            { Tiempo -= Time.deltaTime; } // De lo contrario, sigue bajando.
        }
        if (Tiempo <= 30.0f)
        {
            Tempo.color = Color.red;
            Tempo.fontSize = 30;
        } // Comprueba para cambiar el color del text. 
        else { Tempo.color = Color.green; } // Vuelve a verde cuando aumente...

        Tempo.text = Tiempo.ToString("f0");
        
    }
}
