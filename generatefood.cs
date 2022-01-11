using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatefood : MonoBehaviour
{
    public GameObject[] food;
    private float interval = 2.0f;
    public bool gen_food = true;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while(gen_food){
            GameObject show = food[(int)Random.Range(0.0f,4.0f)];
            
            Instantiate(show,this.transform.position,show.transform.rotation);
            
            yield return new WaitForSeconds(interval);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void OnCollisionEnter(Collision coll){
        if(coll.gameObject.tag == "dish"){

        }else{
            Destroy(gameObject);
        }
    }*/

    //collision 한게 접시가 아니면 프리팹 삭제, 접시면 물체 합칟기....
}
