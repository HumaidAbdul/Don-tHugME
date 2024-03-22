using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rest : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gb;
   public void Reset(){
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
   public void Starts(){
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
     gb.SetActive(false);

   }
   public void Quit(){
    Application.Quit();
   }
}
