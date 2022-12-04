using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { START , PLAYERTURN , PLAYER2TURN }
public class TurnDecision : MonoBehaviour
{
    public Light lt1;
    public Light lt2;
    public BattleState state;
    
    void Start()
    {
        state = BattleState.START;
        lt1.enabled = false;
        lt2.enabled = false;
    }

    void OnMouseDown()
    {
        if(state == BattleState.START)
        {
            lt1.enabled = true;
            lt2.enabled = false;
            state = BattleState.PLAYERTURN;
        }
        else if(state == BattleState.PLAYERTURN)
        {
            lt1.enabled = false;
            lt2.enabled = true;
            state = BattleState.PLAYER2TURN;
        }
        else if(state == BattleState.PLAYER2TURN)
        {
            state = BattleState.START;
            lt1.enabled = false;
            lt2.enabled = false;
        }
    }
}
