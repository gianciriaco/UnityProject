using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelmover : MonoBehaviour
{
    // Variable to set the scene index from the Inspector
    public int sceneBuildIndex;

    // Trigger when something enters the collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger Entered");

        // Check if the object that entered has the tag "Player"
        if (other.tag == "Player")
        {
            // Log and switch scenes
            print("Switching Scene to " + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
