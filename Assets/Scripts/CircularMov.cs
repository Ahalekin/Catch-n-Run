using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMov : MonoBehaviour
{
    public float raio = 2.0f;        // Raio do círculo
    public float velocidade = 1.0f;  // Velocidade de rotação
    private float angulo = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
  

    void Update()
    {
        // Atualiza o ângulo com base no tempo
        angulo += velocidade * Time.deltaTime;

        // Calcula as coordenadas x e y usando seno e cosseno
        float x = raio * Mathf.Cos(angulo);
        float y = raio * Mathf.Sin(angulo);

        // Define a posição do objeto
        transform.position = new Vector3(x, y, 0);
    }
}
