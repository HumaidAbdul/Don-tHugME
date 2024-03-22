using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public float waitSec;
    private int waitSecInt;

    public Text text;

    private void FixedUpdate(){
        if(waitSec > 0){
            waitSec -= Time.fixedDeltaTime;
            waitSecInt =(int)waitSec;
            text.text =waitSecInt.ToString();
        }else{
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
