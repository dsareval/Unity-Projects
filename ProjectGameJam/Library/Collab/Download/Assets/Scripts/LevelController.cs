﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

    public GameObject Lasers;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Button;
    public GameObject Turret;

    bool stop = false;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(3);
        Instantiate(Lasers);
        yield return new WaitForSeconds(1);
        //Instantiate(Enemy1, new Vector3 (13, ), Quaternion.identity);
        Instantiate(Enemy1);
        Instantiate(Turret);
        yield return new WaitForSeconds(3);
        Instantiate(Enemy1);
        Instantiate(Turret);
        yield return new WaitForSeconds(3);
        Instantiate(Turret);
        yield return new WaitForSeconds(1);
        Instantiate(Enemy1);
        yield return new WaitForSeconds(2);
        yield return new WaitForSeconds(1.5f);
        Instantiate(Lasers);
        yield return new WaitForSeconds(2);
        Instantiate(Enemy1);
        yield return new WaitForSeconds(2.2f);
        Instantiate(Enemy1);
        Instantiate(Turret);
        yield return new WaitForSeconds(1.5f);
        Instantiate(Lasers);
        yield return new WaitForSeconds(2);
        Instantiate(Button);
    }

    // Update is called once per frame
    void Update ()
    {
     
    }
}
