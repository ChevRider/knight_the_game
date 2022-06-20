using UnityEngine;
using UnityEngine.UI;

public class CoinsText : MonoBehaviour
{
    public static int coins;
    public static Text coinsText;

    void Start()
    {
        coinsText = GetComponent<Text>();
        coinsText.text = coins.ToString();
    }
}
