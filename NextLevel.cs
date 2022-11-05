using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider gameObjectInformation)
    {
        if (gameObjectInformation.gameObject.name == "Player")
        {
            Debug.Log("Collision");
            SceneManager.LoadScene("Level2");
        }
            
    }
}
