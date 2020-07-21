using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Runner runner;

    private void Start()
    {
        runner.Goal += Gameover;
    }

    private void Gameover()
    {

    }
}
