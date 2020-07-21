using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public Runner runner;

    private void Start()
    {
        GameObject.FindGameObjectWithTag("BGM").GetComponent<AudioSource>();
        runner.Goal += Changesound;
    }

    private void Changesound()
    {

    }
}
