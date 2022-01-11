using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class whatscore : MonoBehaviour
{
public static Stack<GameObject> sandwich = new Stack<GameObject>(); //점수 측정을 위한 스택. 
    public static int score;
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        /**/
        if(playercontrol.cnt_bread == 2){
            GameObject.Find("food_position1").GetComponent<generatefood>().gen_food = false;
            GameObject.Find("food_position2").GetComponent<generatefood>().gen_food = false;
            GameObject.Find("food_position3").GetComponent<generatefood>().gen_food = false;
            playercontrol.cnt_bread = 0;
            measure();
            
        }
       

        if(Input.GetKey(KeyCode.R)){
            
            SceneManager.LoadScene("main_scene",LoadSceneMode.Single);
        
            
            
        }
        
    }

    void measure(){
        while(sandwich.Count>0){
            
            GameObject obj = sandwich.Pop();
            if(obj.GetComponent<del_food>().st_in) score += 10;
            GameObject.Find("Canvas").transform.Find("Text").gameObject.SetActive(true);
            
        }
    }

    void OnGUI(){
        GUI.Label(new Rect(10,40, 130,80),"score : " + score.ToString());
    }
}
