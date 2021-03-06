﻿using UnityEngine;
using System.Collections;

public class ShooterData : MonoBehaviour {

    public bool already_exist = false;

    public int enemy_killed;
    public int wave_size;

    public int score;
    public int life;
    public int corpses;

    public int max_combo;

    public bool gameOver;

    void Awake()
    {
            DontDestroyOnLoad(this);   
    }

    void Start()
    {
        max_combo = 0;
    }

    public void saveEnemyManager(int em_enemy_killed, int em_wave_size)
    {
        enemy_killed = em_enemy_killed;
        wave_size = em_wave_size;
    }

    public void savePlayer(int pl_score, int pl_life, int pl_corpses)
    {
        score = pl_score;
        life = pl_life;
        corpses = pl_corpses;
    }
}
