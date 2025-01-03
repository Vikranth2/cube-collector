using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame updat
    public FixedJoystick joystick;
    public float moveSpeed;

    float hInput , vInput;
    int score = 0;
    public GameObject winText;
    public int winScore;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate(){
        hInput = joystick.Horizontal*moveSpeed;
        vInput = joystick.Vertical*moveSpeed;

        transform.Translate(hInput, vInput,0);

    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "carrot"){

            score++ ;
            Destroy(collision.gameObject);

            if(score >= winScore){
                winText.SetActive(true);
            }
        }
        
    }

}
