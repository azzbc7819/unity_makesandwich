using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class del_food : MonoBehaviour
{
    public bool st_in = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag=="table"){
            if(whatscore.sandwich.Count > 0) {
                if(this.gameObject == whatscore.sandwich.Peek()) {
                    GameObject obj = whatscore.sandwich.Pop();
                }
            }
            Destroy(this.gameObject);
        }
        
    }
}
