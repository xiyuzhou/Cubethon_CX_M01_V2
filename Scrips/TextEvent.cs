using UnityEngine;
using UnityEngine.UI;

public class TextEvent : MonoBehaviour
{

    public Transform player;
    public Text scoreText;

    void Update()
    {
        if (PlayerCollision.status == true)
        {
            scoreText.text = "Oops";
        }
        else if (PlayerCollision.status == false)
        {
            if (player.position.z >= 50)
            {
                scoreText.text = "Almost there!";
            }
            else if (player.position.z >= 15)
            {
                scoreText.text = "Good Start";
            }
            else
            {
                scoreText.text = "";
            }
        }
            
    }

}
