using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class IceMeteor : MonoBehaviour
{
    

    // Update is called once per frame
    Transform startPoint;
    Transform endPoint;
    // [SerializeField] private duration;
    bool resetFall=false;   

    private void Start() {
        this.transform.position=startPoint.position;
    }
    void Update()
    {
        if(resetFall){
            // this.transform.DOMove(this.transform.position);
        }
    }
    
}
