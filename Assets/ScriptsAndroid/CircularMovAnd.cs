using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMovAnd : MonoBehaviour
{
    public float raio = 2.0f;        // Raio do c�rculo
    public float velocidade = 1.0f;  // Velocidade de rota��o
    private float angulo = 0.0f;
    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frameS
  

    void Update()
    {
        // Atualiza o �ngulo com base no tempo
        angulo += velocidade * Time.deltaTime;

        // Calcula as coordenadas x e y usando seno e cosseno
        float x = 0.7f * raio * Mathf.Cos(angulo);
        float y = 0.7f * raio * Mathf.Sin(angulo);

        // Define a posi��o do objeto
        transform.position = new Vector3(x, y, 0);
    }
}
