using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelController : MonoBehaviour
{

    public GameObject medeaModel;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = medeaModel.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeAnim(string trigger) {
       // Debug.Log("PRESSED");
        anim.SetTrigger(trigger);
    }
}
