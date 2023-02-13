using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContrallor : MonoBehaviour
{

    [SerializeField] private GameObject GO_player_body;
    [SerializeField] private float flt_Rotating_Speed = 10;


    //----ALL PRIVATE VARIABLE---//
    private Rigidbody _playerBody;


    private void Awake()
    {
        _playerBody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
    }

    private void RotatePlayer()
    {
        float horizontal_Axis = Input.GetAxis("Horizontal");

        if(horizontal_Axis < 0)
        {
            GO_player_body.transform.rotation = Quaternion.Euler(0,flt_Rotating_Speed * Time.deltaTime,0);
        }
        else if(horizontal_Axis > 0)
        {
            print("Nove Right");
        }
        else
        {
            print("Moving straight");
        }
    }

    private void FixedUpdate()
    {
        _playerBody.velocity = new Vector3(0, 0, 10);
    }

}
