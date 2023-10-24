using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GameControllerAnd : MonoBehaviour
{
    public Text scoreText, hiScore,timerText;
    public GameObject Points, GameOverUi, UiMain, HexSavePoint, HexSavePointTimer;
    public static GameControllerAnd instance;
    public bool hexSafe, memo;
    float startTime, hexTime;
    private int cont = 0, contHiScore;
    public GameObject menuDePauseUI; // Arraste o Canvas do menu de pausa aqui no Inspector

    private bool jogoPausado = false;
    // Start is called before the first frame update

    void Start()
    {   
        hexSafe = true;
        PausarJogo();
        HexSavePoint.SetActive(true);
        //startTime = 0f;  
        contHiScore = PlayerPrefs.GetInt("hiScore");
        hiScore.text = Imprime(contHiScore);
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
       
       /*if (!hexSafe)
        {
            timerText.text = hexTime.ToString("F1");
        }*/
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
    public void Score()
    {   
        cont++;
        scoreText.text = Imprime(cont);
        GameObject.Instantiate(Points);
    }
    public void GameOver()
    {
        UiMain.SetActive(false);
        GameOverUi.SetActive(true);
        if (cont > contHiScore)
        {
            PlayerPrefs.SetInt("hiScore", cont);
            hiScore.text = Imprime(cont);
        }
    }
        public void restart()
        {
            SceneManager.LoadScene(0);
        }
    
    public string Imprime(int numImprime)
    {
        string str;
        if (numImprime  < 100 && numImprime >= 10)
        {
            str = "0" + numImprime.ToString(); ;
            return str;
        }
        else
        {
            str = "00" + numImprime.ToString(); ;
            return str;
        }
    }
   /* public void SafeZoneTimer(Vector2 vec2)
    {
        startTime = 0f;
        startTime = Time.deltaTime;
        HexSavePointTimer.SetActive(true);
        hexTime = 3f - startTime;
        Debug.Log(hexTime);
        Vector2 vecHex = new Vector2(HexSavePoint.transform.position.x, HexSavePoint.transform.position.y);

        if (hexTime <= 0f || vec2 == vecHex )
        {
            startTime = 0f;
            HexSavePointTimer.SetActive(false);
            HexSavePoint.SetActive(false);
        }

    }*/
    public void PausarJogo()
    {
        jogoPausado = true;
        Time.timeScale = 0; // Pausar o tempo do jogo
        menuDePauseUI.SetActive(true); // Ativar o menu de pausa
    }

    public void ContinuarJogo()
    {
        jogoPausado = false;
        Time.timeScale = 1; // Continuar o tempo do jogo
        menuDePauseUI.SetActive(false); // Desativar o menu de pausa
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    /*public void safeZone(Vector2 vec2)
    {
        if (hexSafe)
        {
            hexSafe = !hexSafe;
            SafeZoneTimer(vec2);
        }
    }*/
}
