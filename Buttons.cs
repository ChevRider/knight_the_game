using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField] private GameObject cutSceneCamera;

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        CoinsText.coins = 0;
        LevelResults.enemyesOnLevelKill = 0;
        PlayerMovement.isControlled = true;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        CoinsText.coins = 0;
        LevelResults.enemyesOnLevelKill = 0;
        PlayerMovement.isControlled = true;
    }

    public void NextLevel()
    {
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            SceneManager.LoadScene("Level1");
            LevelResults.enemyesOnLevelKill = 0;
            CoinsText.coins = 0;
            PlayerMovement.isControlled = true;
        }

        if (SceneManager.GetActiveScene().name == "Level1")
        {
            SceneManager.LoadScene("Level2");
            LevelResults.enemyesOnLevelKill = 0;
            CoinsText.coins = 0;
            PlayerMovement.isControlled = true;
        }

        if (SceneManager.GetActiveScene().name == "Level2")
        {
            SceneManager.LoadScene("Level3");
            LevelResults.enemyesOnLevelKill = 0;
            CoinsText.coins = 0;
            PlayerMovement.isControlled = true;
        }

        if (SceneManager.GetActiveScene().name == "Level3")
        {
            SceneManager.LoadScene("Level4");
            LevelResults.enemyesOnLevelKill = 0;
            CoinsText.coins = 0;
            PlayerMovement.isControlled = true;
        }

        if (SceneManager.GetActiveScene().name == "Level4")
        {
            SceneManager.LoadScene("Level5");
            LevelResults.enemyesOnLevelKill = 0;
            CoinsText.coins = 0;
            PlayerMovement.isControlled = true;
        }

        if (SceneManager.GetActiveScene().name == "Level5")
        {
            SceneManager.LoadScene("Titles");
            LevelResults.enemyesOnLevelKill = 0;
            CoinsText.coins = 0;
            PlayerMovement.isControlled = true;
        }
    }
}
