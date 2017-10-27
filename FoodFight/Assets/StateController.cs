using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;
//using Complete;

public class StateController : MonoBehaviour
{
    private State currState;
    public EnemyStats stats;
    public State remainState;

    public List<Transform> waypoints;
    public int nextWayPoint;

    private Action search;
    private NavMeshAgent nav;

    public State _state
    {
        get
        {
            return currState;
        }
        set
        {
            ExitState(currState);
            currState = value;
            EnterState(currState);
        }
    }
    public enum State
    {
        Search,
        GoPickUp,
        Aim,
        Throw,
        Block,
    }
    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        nav.updateRotation = false;

        _state = State.Search;
    }
    void EnterState(State enteredState)
    {
        switch (enteredState)
        {
            case State.Search:
                //search = new Action()
                break;
        }
    }
    void ExitState(State prevState)
    {
        
    }
    IEnumerator Searching(Action onComplete)
    {
        //Transform tr = transform.position;
        while (true)
        {
            bool foundItem = false;
        }
    }
    //public State currentState;
    //public EnemyStats enemyStats;
    //public Transform eyes;
    //public State remainState;


    //[HideInInspector] public UnityEngine.AI.NavMeshAgent navMeshAgent;
    //[HideInInspector] public Complete.TankShooting tankShooting;
    //[HideInInspector] public List<Transform> wayPointList;
    //[HideInInspector] public int nextWayPoint;
    //[HideInInspector] public Transform chaseTarget;
    //[HideInInspector] public float stateTimeElapsed;

    //private bool aiActive;


    //void Awake()
    //{
    //    tankShooting = GetComponent<Complete.TankShooting>();
    //    navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    //}

    //public void SetupAI(bool aiActivationFromTankManager, List<Transform> wayPointsFromTankManager)
    //{
    //    wayPointList = wayPointsFromTankManager;
    //    aiActive = aiActivationFromTankManager;
    //    if (aiActive)
    //    {
    //        navMeshAgent.enabled = true;
    //    }
    //    else
    //    {
    //        navMeshAgent.enabled = false;
    //    }
    //}

    //void Update()
    //{
    //    if (!aiActive)
    //        return;
    //    currentState.UpdateState(this);
    //}

    //void OnDrawGizmos()
    //{
    //    if (currentState != null && eyes != null)
    //    {
    //        Gizmos.color = currentState.sceneGizmoColor;
    //        Gizmos.DrawWireSphere(eyes.position, enemyStats.lookSphereCastRadius);
    //    }
    //}

    //public void TransitionToState(State nextState)
    //{
    //    if (nextState != remainState)
    //    {
    //        currentState = nextState;
    //        OnExitState();
    //    }
    //}

    //public bool CheckIfCountDownElapsed(float duration)
    //{
    //    stateTimeElapsed += Time.deltaTime;
    //    return (stateTimeElapsed >= duration);
    //}

    //private void OnExitState()
    //{
    //    stateTimeElapsed = 0;
    //}
}
