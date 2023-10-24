using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Menu : MonoBehaviour
{
    public GameObject Jogo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {   
            Jogo.SetActive(false);   
            gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void PlayGame()
    {   
        Jogo.SetActive(true);
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    
}*/
public class MenuAnd : MonoBehaviour
{
    public GameObject menuDePauseUI; // Arraste o Canvas do menu de pausa aqui no Inspector

    private bool jogoPausado = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (jogoPausado)
            {
                ContinuarJogo();
            }
            else
            {
                PausarJogo();
            }
        }
    }

    void PausarJogo()
    {
        jogoPausado = true;
        Time.timeScale = 0; // Pausar o tempo do jogo
        menuDePauseUI.SetActive(true); // Ativar o menu de pausa
    }

    void ContinuarJogo()
    {
        jogoPausado = false;
        Time.timeScale = 1; // Continuar o tempo do jogo
        menuDePauseUI.SetActive(false); // Desativar o menu de pausa
    }
}
