using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    public float fallThreshold = -10f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < fallThreshold)
        {
            SceneManager.LoadSceneAsync(1);
            Time.timeScale = 1;
        }
    }
}
