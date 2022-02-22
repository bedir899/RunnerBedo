using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class bölümSonu : MonoBehaviour
{
    public string sonrakiLevel;
    
    public Text sonuc;
    public GameObject score;
    public GameObject sonucObje;
    public GameObject oyuncu;
    public int nextSceneLoad;
    public GameObject buObje;
    void Start()
    {
        buObje = this.gameObject;
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
        
        Invoke("OnTriggerEnter", 3f);
    }
    public  void OnTriggerEnter(Collider other)
    {     
        if (other.tag=="Player")
        {
            
            movement.anim.SetBool("running", false);
            movement.anim.SetBool("finish", true);
            movement.forwardSpeed = 0;
            Debug.Log("carptı");
            camControl.offset.y = 1f;
            camControl.offset.z = -2f;
            StartCoroutine(donus());                                 
        }
        score.SetActive(false);
        sonucObje.SetActive(true);
        
        sonuc.text = " Level Completed " +
            "" + Altın.sayacDegis + "/46 Cheese ";

        if (nextSceneLoad>PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", nextSceneLoad);
        }
        

    }
    IEnumerator donus()
    {
        oyuncu.transform.Rotate(0, 180, 0);
        yield return new WaitForSeconds(2f);
        buObje.SetActive(false);
       
    }
}
