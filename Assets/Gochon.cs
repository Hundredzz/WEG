using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gochon : MonoBehaviour

{
    public AudioSource sfx;
    public int Sco ;
    public int max_Sco ;
    public Text Ui_sco ;

    // //Collider only
    void OnTriggerEnter(Collider other)
    {
         if(other.gameObject.tag == "Coin")
         {
            sfx.Play(0);
            Sco ++ ; 
            Destroy(other.gameObject); 
         }
    }

    void Update()
    {
        Ui_sco.text = "Score :"+ Sco +" / " + max_Sco;
    }   


}
