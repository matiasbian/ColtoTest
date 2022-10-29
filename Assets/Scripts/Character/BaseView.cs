using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class BaseView : MonoBehaviour
{
    // Start is called before the first frame update
    protected CharacterController controller;
    protected virtual void Init()
    {
        controller = GetComponent<CharacterController>();
        GameManager.lose += OnLose;
    }

    void OnDisable () {
        GameManager.lose -= OnLose;
    }

    void OnLose () {
        Debug.Log(this);
        this.enabled = false;
    }

    protected virtual void OnUpdate () {

    }

    void Start () {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        OnUpdate();
    }
}
[System.Serializable]
public struct Direction {
    public string name;
    public Sprite[] sprites;
}
