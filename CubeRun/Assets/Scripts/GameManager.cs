using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

    bool GameEnded = false;

    public float restartDelay = 1f;

    public GameObject successUI;

    public void Success()
    {
        successUI.SetActive(true);
    }

    public void EndGame() {

        if (GameEnded == false) {
            GameEnded = true;
            Debug.Log("GameOver");

            //Restar Game
            Invoke("Restart", restartDelay);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
