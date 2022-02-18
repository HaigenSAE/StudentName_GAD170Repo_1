using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPSystem : MonoBehaviour
{
    public int level; //laps

    public float curXp; //curLapProgress
    public float reqXp; //reqLapProgress

    //Stats variables (to be tracked and modified upon level up)
    public float health;
    public float defense;
    public float speed;
    public float attack;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitialStats()
    {
        //Initialize stats, level, xp, reqxp etc.
    }
    public void Interaction(int exp)
    {
        //An interaction called by a button press
    }
    public void GainXP(int amount) //GainProgress
    {
        //increase our current xp
    }
    public void LevelUp() //CompletedLap
    {
        //increase our level
    }
    public void IncreaseStats()
    {
        //Improve our stats
    }
}
