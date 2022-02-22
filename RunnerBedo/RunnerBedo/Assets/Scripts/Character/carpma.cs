using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carpma : MonoBehaviour
{
    public GameObject engel;
    public GameObject ölüm;
    public GameObject oyuncu;
    public Vector3 hareket;   
    void Start()
    {   
        engel = this.gameObject;
    }
    public  void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Çarptý");
            movement.anim.SetBool("running", false);
            movement.anim.SetBool("die", true);
            SwerveMovement.swerveSpeed = 0f;
            SwerveMovement.maxSwerveAmount = 0f;
            movement.forwardSpeed = 0;
            CircleHealth.healtValue += 25f;
            
            Debug.Log(CircleHealth.healtValue);

            

            if (CircleHealth.healtValue == 100)
            {
                ölüm.SetActive(true); 
                
                PlayerPrefs.DeleteKey("sayacTopla");
                
            }
            if(CircleHealth.healtValue!=100)
            {

                StartCoroutine("yenidenDogum");
            }
            
            
        }
    }
    IEnumerator yenidenDogum()
    {

       
            oyuncu.transform.Translate(hareket);
            movement.anim.SetBool("running", true);
            movement.anim.SetBool("die", false);
            movement.forwardSpeed = 3;
            SwerveMovement.swerveSpeed = 0.5f;
            SwerveMovement.maxSwerveAmount = 1f;

        yield return new WaitForSeconds(3f);
    }

    
}
