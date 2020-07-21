using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene3
    : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown("o"))
        {
            SceneManager.LoadScene(2);
        }
        if (Input.GetKeyDown("p"))
        {
            SceneManager.LoadScene(4);
        }

    }
}
