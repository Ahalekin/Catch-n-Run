using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerInput : MonoBehaviour
{       // Raio do círculo
    public float velocidade = 0.8f;  // Velocidade de rotação
    private float [] linha = new float[4];
    private int cont = 1;
    private float angulo = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        linha[0] = 0;
        linha[1] = 1.65f;
        linha[2] = 2.65f;
        linha[3] = 3.65f;
    }
    // Update is called once per frame

    void Update()
    {
        Debug.Log(cont);
        mov(linha[cont]);
        inputTeclado(false, Input.GetKeyDown(KeyCode.DownArrow));
        inputTeclado(Input.GetKeyDown(KeyCode.UpArrow), false);
    }
    private void inputTeclado(bool yAxisUp, bool yAxisDown)
    {
        if (yAxisUp && cont < 3)
        {
            cont++;
            mov(linha[cont]);
        }
        if (yAxisDown && cont > 1)
        {
            cont--;
            mov(linha[cont]);
        }
    }
    private void mov(float raio)
    {
        // Atualiza o ângulo com base no tempo
        angulo += velocidade * Time.deltaTime;

        // Calcula as coordenadas x e y usando seno e cosseno
        float x = raio * Mathf.Cos(angulo);
        float y = raio * Mathf.Sin(angulo);

        // Define a posição do objeto
        transform.position = new Vector3(x, y, 0);
    }
    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.tag == "Death")
        {
            Destroy(gameObject);
            GameControllerAnd.instance.GameOver();

        }
    }
}

