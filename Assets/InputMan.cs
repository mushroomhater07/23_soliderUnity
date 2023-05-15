using System;
using UnityEngine;

public class InputMan : MonoBehaviour
{
    private Inputcontrol _inputAction;
    private Inputcontrol.PlayActions _playActions;

    [SerializeField] private float speed;
    [SerializeField]private GameObject player;
    void Start()
    {
        _inputAction = new Inputcontrol();
        _playActions = _inputAction.play; 
        _playActions.Enable();
    }

    private void FixedUpdate()
    {
        player.transform.Translate(Vector3.forward* _inputAction.play.normal.ReadValue<float>()* speed * Time.deltaTime);
    }
}
