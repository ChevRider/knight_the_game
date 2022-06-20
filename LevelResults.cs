using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelResults : MonoBehaviour
{
    public static int enemyesOnLevelKill;
    public Text totalCoinsText;
    public Text totalEnemyesText;
    public Text totalScoreText;
    public GameObject oneStar;
    public GameObject twoStars;
    public GameObject threeStars;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            totalCoinsText.text = ($"Собрано монет: {CoinsText.coins}/185");
            totalEnemyesText.text = ($"Убито врагов: {enemyesOnLevelKill}/9");
        }

        if (SceneManager.GetActiveScene().name == "Level2")
        {
            totalCoinsText.text = ($"Собрано монет: {CoinsText.coins}/122");
            totalEnemyesText.text = ($"Убито врагов: {enemyesOnLevelKill}/6");
        }

        if (SceneManager.GetActiveScene().name == "Level3")
        {
            totalCoinsText.text = ($"Собрано монет: {CoinsText.coins}/196");
            totalEnemyesText.text = ($"Убито врагов: {enemyesOnLevelKill}/15");
        }

        if (SceneManager.GetActiveScene().name == "Level4")
        {
            totalCoinsText.text = ($"Собрано монет: {CoinsText.coins}/241");
            totalEnemyesText.text = ($"Убито врагов: {enemyesOnLevelKill}/8");
        }

        if (SceneManager.GetActiveScene().name == "Level5")
        {
            totalCoinsText.text = ($"Собрано монет: {CoinsText.coins}/507");
            totalEnemyesText.text = ($"Убито врагов: {enemyesOnLevelKill}/18");
        }

        totalScoreText.text = ($"Очки: {Score.score}");
    }

    // Update is called once per frame
    void Update()
    {
        if(CoinsText.coins == 185 || enemyesOnLevelKill == 9 && SceneManager.GetActiveScene().name == "Level1")
        {
            oneStar.SetActive(false);
            twoStars.SetActive(true);
        }

        if(CoinsText.coins == 185 && enemyesOnLevelKill == 9 && SceneManager.GetActiveScene().name == "Level1")
        {
            oneStar.SetActive(false);
            threeStars.SetActive(true);
        }

        if (CoinsText.coins == 122 || enemyesOnLevelKill == 6 && SceneManager.GetActiveScene().name == "Level2")
        {
            oneStar.SetActive(false);
            twoStars.SetActive(true);
        }

        if (CoinsText.coins == 122 && enemyesOnLevelKill == 6 && SceneManager.GetActiveScene().name == "Level2")
        {
            oneStar.SetActive(false);
            threeStars.SetActive(true);
        }

        if (CoinsText.coins == 196 || enemyesOnLevelKill == 15 && SceneManager.GetActiveScene().name == "Level3")
        {
            oneStar.SetActive(false);
            twoStars.SetActive(true);
        }

        if (CoinsText.coins == 196 && enemyesOnLevelKill == 15 && SceneManager.GetActiveScene().name == "Level3")
        {
            oneStar.SetActive(false);
            threeStars.SetActive(true);
        }

        if (CoinsText.coins == 241 || enemyesOnLevelKill == 8 && SceneManager.GetActiveScene().name == "Level4")
        {
            oneStar.SetActive(false);
            twoStars.SetActive(true);
        }

        if (CoinsText.coins == 241 && enemyesOnLevelKill == 8 && SceneManager.GetActiveScene().name == "Level4")
        {
            oneStar.SetActive(false);
            threeStars.SetActive(true);
        }

        if (CoinsText.coins == 507 || enemyesOnLevelKill == 18 && SceneManager.GetActiveScene().name == "Level5")
        {
            oneStar.SetActive(false);
            twoStars.SetActive(true);
        }

        if (CoinsText.coins == 507 && enemyesOnLevelKill == 18 && SceneManager.GetActiveScene().name == "Level5")
        {
            oneStar.SetActive(false);
            threeStars.SetActive(true);
        }


    }
}
