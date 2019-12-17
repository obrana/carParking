using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    Animation anim;
    private bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DoorControl()
    {
        if (isOpen == false){
            anim["DoorAnim"].speed = 1;
            anim.Play();
        }
        else if (isOpen == true){
            anim["DoorAnim"].speed = -1;
            anim["DoorAnim"].time = anim["DoorAnim"].length;

           anim.Play();
            isOpen = false;
        }
    }
}
