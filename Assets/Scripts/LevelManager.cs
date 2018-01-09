using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int level;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            int load = SceneManager.GetActiveScene().buildIndex;
            if (load < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(level);
            }
        }
    }

}
