using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public Ball ball { get; private set; }
    public Paddle paddle { get; private set; }

    public int level = 1;
    public int score = 0;
    public int lives = 3;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        SceneManager.sceneLoaded += OnLevelLoaded;
    }

    private void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        this.score = 0;
        this.lives = 3;

        LoadLevel(1);
    }

    private void LoadLevel(int level)
    {
        this.level = level;

        SceneManager.LoadScene("level" + level);
    }

    private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
    {

    }

    private void ResetLevel()
    {
        this.ball.ResetBall();
        this.paddle.ResetPaddle();
    }

    private void GameOver()
    {

        //SceneManager.LoadScene("GameOver");
        NewGame();
    }
    public void Miss()
    {
        this.lives--;

        if (this.lives > 0)
        {
            Resetlevel();
        }
        else
        {
            GameOver();
        }

    }

    public void Hit(Brick brick)
    {
        this.score += brick.points;
    }

}
