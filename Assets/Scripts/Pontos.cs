using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontos : MonoBehaviour
{
    private float raio;        // Raio do círculo
    private float randomFloat;
    private int randomInt;
    private float[] linha = new float[3];
    Collider2D col2D;
   
    // Start is called before the first frame update
    void Start()
    {   
        col2D = GetComponent<Collider2D>();
        randomFloat = Random.Range(-1.0f, 1.0f);
        randomInt = Random.Range(0, 2);
        linha[0] = 1.65f;
        linha[1] = 2.65f;
        linha[2] = 3.65f;
    }

    // Update is called once per frame
    void Update()
    {
        raio = linha[randomInt];


        // Calcula as coordenadas x e y usando seno e cosseno
        float x = raio * Mathf.Cos(randomFloat);
        float y = raio * Mathf.Sin(randomFloat);
        // Define a posição do objeto
        transform.position = new Vector2(x, y);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "Player")
        {
            col2D.enabled = !col2D.enabled;
            Destroy(gameObject);
            GameControllerAnd.instance.Score();
        }
    }
}
