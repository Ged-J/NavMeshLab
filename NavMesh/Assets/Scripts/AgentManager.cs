using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentManager : MonoBehaviour
{

    GameObject[] agents;

    // Start is called before the first frame update
    void Start()
    {

        agents = GameObject.FindGameObjectsWithTag("ai");

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            SetDestinationToMousePosition();
        }


    }

    void SetDestinationToMousePosition()
    {
        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, 100))
        {

            foreach (GameObject a in agents)

                a.GetComponent<NavMeshAgent>().SetDestination(hit.point);


        }

    }


}
