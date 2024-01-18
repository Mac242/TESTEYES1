using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

public class boxspawner : MonoBehaviour
{   
    private GameObject [] cubes = new GameObject [25];
    [SerializeField] GameObject Treefalling;
    public ParticleSystem fog;
    public bool firstTreeDown;
    // Start is called before the first frame update
    void Start()
    {
       
       firstTreeDown = false;

    }

    // Update is called once per frame
    private void OnTriggerEnter (Collider other)
    {
         if(other.gameObject.CompareTag("Respawn"))
        {
           
            for (int i = 0; i < 25; i++)
            {
                cubes[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cubes[i].name = "Cube_"+ i;
                //cubes[i].transform.SetlocalScale(Random.Range(1,5),Random.Range(1,5), Random.Range(1,5));
                cubes[i].AddComponent<Rigidbody>();
                cubes[i].transform.position = new Vector3 (Treefalling.transform.position.x, Random.Range(1,5), 
                Treefalling.transform.position.z);
                //cubes[i].transform.Translate(new Vector3 (1,0,1));
               
        
            Destroy(Treefalling);
            Destroy(GameObject.FindWithTag("Finish"));
            fog.Play();
            firstTreeDown = true;
            }

         }
    }

}
