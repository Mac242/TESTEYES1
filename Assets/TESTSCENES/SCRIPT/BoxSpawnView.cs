using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Versioning;
using UnityEngine;

public class BoxSpawnView : MonoBehaviour
{ public boxspawner _boxspawner;
private bool viewActivated;
 private GameObject [] cubes = new GameObject [20];
 public GameObject thisTree;
 public ParticleSystem thisSmog;

    // Start is called before the first frame update
    void Start()
    {
       // _boxspawner.firstTreeDown = GetComponent<boxspawner>().firstTreeDown;
       viewActivated = false;
      
    }

    // Update is called once per frame
    void Update()
    {
        if(_boxspawner.firstTreeDown == true)
        {
            Debug.Log("viewspawn");
            viewActivated = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(viewActivated==true && other.gameObject.CompareTag("Viewer"))
        {
             for (int i = 0; i < 20; i++)
            {
            cubes[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubes[i].name = "Cube_"+ i;
            //cubes[i].transform.SetlocalScale(Random.Range(1,5),Random.Range(1,5), Random.Range(1,5));
            cubes[i].AddComponent<Rigidbody>();
                //Vector3 pos = new Vector3(thisTree.transform.position.x, Random.Range(5, 20),
                //pos.z = thisTree.transform.position.z)
               
            cubes[i].transform.position = new Vector3 (thisTree.transform.position.x, Random.Range(2,15), 
            thisTree.transform.position.z);
            

            Destroy(thisTree);

            }
                thisSmog.Play();
        }
    }

    private object GetComponent<T>(T skyDome)
    {
        throw new System.NotImplementedException();
    }
}
