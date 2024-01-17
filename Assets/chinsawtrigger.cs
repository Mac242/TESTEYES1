using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class chinsawtrigger : MonoBehaviour
{   private GameObject Treefall;
    // Start is called before the first frame update
    void Start()
    {
        Treefall = GameObject.FindWithTag("Finish");
        Treefall.SetActive(false);
    }

    private void GetComponent<T>(bool v)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("chainsaw"))
        {
            Destroy(GameObject.FindWithTag("tree"));
            Treefall.SetActive(true);
            Destroy(GameObject.FindWithTag("chainsaw"));
        }
    }

}
