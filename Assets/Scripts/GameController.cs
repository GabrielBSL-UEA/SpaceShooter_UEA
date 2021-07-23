using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    [Header("Spawners")]
    [SerializeField] private GameObject enemySpawner;
    [SerializeField] private GameObject playerSpawner;

    [Header("Gameplay")]
    [SerializeField] private int lifes = 3;
    [SerializeField] private float secondsToRestart = 5f;

    [Header("Panels")]
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject hud;
    [SerializeField] private GameObject pausePainel;
    [SerializeField] private GameObject gameOverPanel;

    [Header("Images")]
    [SerializeField] private Sprite pauseSprite;
    [SerializeField] private Sprite playSprite;
    [SerializeField] private Image pauseButtonImage;

    [Header("Texts")]
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI lifeText;

    private int m_Points;
    private bool gameStarted;

    private int m_CurrentLifes;

    public static GameController Instance;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    private void Start()
    {
        RestartGame();
    }

    public void StartGame()
    {
        AudioManager.Instance.Play(AudioList.ButtonClick);

        if (gameStarted) return;
        gameStarted = true;

        mainMenu.SetActive(false);
        hud.SetActive(true);
        enemySpawner.SetActive(true);
        playerSpawner.SetActive(true);

        AudioManager.Instance.Play(AudioList.GameplayMusic, isMusic: true);
    }

    public void AddScore(int score)
    {
        m_Points += score;
        scoreText.text = m_Points.ToString("000000");
    }

    public bool RemoveLife()
    {
        if (m_CurrentLifes <= 0)
        {
            StartCoroutine(StartGameOverState());
            return false;
        }

        m_CurrentLifes--;
        lifeText.text = "X" + m_CurrentLifes;

        return true;
    }

    public void onPauseButtonClicked()
    {
        AudioManager.Instance.Play(AudioList.ButtonClick);

        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
            pausePainel.SetActive(false);
            pauseButtonImage.sprite = playSprite;
            AudioManager.Instance.ResumeMusic();

            return;
        }
        
        Time.timeScale = 0;
        pausePainel.SetActive(true);
        pauseButtonImage.sprite = pauseSprite;
        AudioManager.Instance.PauseMusic();
    }

    private IEnumerator StartGameOverState()
    {
        gameOverPanel.SetActive(true);
        enemySpawner.SetActive(false);
        playerSpawner.SetActive(false);
        AudioManager.Instance.StopMusic();

        yield return new WaitForSeconds(secondsToRestart);

        RestartGame();
    }

    private void RestartGame()
    {
        gameStarted = false;

        scoreText.text = "000000";
        lifeText.text = "X" + lifes;
        m_CurrentLifes = lifes;

        m_Points = 0;

        gameOverPanel.SetActive(false);
        pausePainel.SetActive(false);
        hud.SetActive(false);
        mainMenu.SetActive(true);

        AudioManager.Instance.Play(AudioList.MenuMusic, isMusic: true);
    }
}
