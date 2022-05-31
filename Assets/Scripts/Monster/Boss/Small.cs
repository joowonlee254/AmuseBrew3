using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Small : MonoBehaviour
{
    public Animator anim = null;
    public BossController_LNH boss;
    public GameObject GO_Boss;
    private void Start()
    {
        anim = this.GetComponent<Animator>();
        GO_Boss = GameObject.Find("Boss");
        boss = GO_Boss.GetComponent<BossController_LNH>();
    }
    private void Update()
    {
        if (boss.e_hp <= 0)
        {
            //Destroy(this.gameObject, 3.0f);
            anim.SetTrigger("Dead");
        }
        
    }
}
