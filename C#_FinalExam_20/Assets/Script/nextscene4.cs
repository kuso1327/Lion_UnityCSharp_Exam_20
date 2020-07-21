using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene4 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown("o"))
        {
            SceneManager.LoadScene(3);
        }
        if (Input.GetKeyDown("p"))
        {
            SceneManager.LoadScene(4);
        }

    }
}
