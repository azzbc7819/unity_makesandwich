using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontrol : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    public static int cnt_bread = 0;
    void Start()
    {  
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(-0.1f,0,0);
        }else if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(0.1f,0,0);
        }

        
    }

    void OnCollisionEnter(Collision other){
        if(this.gameObject.name == "dish" && other.gameObject.name != "bread(Clone)"){
            //점수 초기화, 샌드위치는 접시에 빵부터 들어와야 하니까 빵이 아닌게 오면 삭제
            Destroy(other.gameObject);
        }

        if(other.gameObject.tag != "table"){
            if(other.gameObject.tag != "dish" && !other.gameObject.GetComponent<del_food>().st_in) {
                if(other.gameObject.name == "bread(Clone)") cnt_bread++;
                whatscore.sandwich.Push(other.gameObject);
                other.gameObject.GetComponent<del_food>().st_in = true;
            }

            bool frag = other.gameObject.GetComponent<playercontrol>().enabled;
            if(!frag) other.gameObject.GetComponent<playercontrol>().enabled = true;
            //접시와 같이 방향키로 이동
           
            
        }

    }

    
}
