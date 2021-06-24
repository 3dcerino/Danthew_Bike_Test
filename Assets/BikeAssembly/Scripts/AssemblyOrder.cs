using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AssemblyOrder : MonoBehaviour
{
    //Public list of parts to be grabbed and placed
    public List<GameObject> boardParts = new List<GameObject>();
    //Public list of sockets
    public List<GameObject> socketParts = new List<GameObject>();
    //Index for both lists above
    int globalIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Set first socket active
        socketParts[globalIndex].SetActive(true);
    }

    //Will be called by the socketed event in each successful socket
    public void OnAssembly()
    {
        StartCoroutine(AssemblyCoroutine());
    }

    private IEnumerator AssemblyCoroutine()
    {
        //Add +1 to the index in order to target the next socket that will be available
        globalIndex++;

        //Activate next socket
        if (globalIndex <= 10)
        {
            socketParts[globalIndex].SetActive(true);
        }

        //Wait a moment before hiding socket's mesh
        yield return new WaitForSeconds(0.3f);

        //Check if the socket is a single mesh or a group
        if (socketParts[globalIndex - 1].transform.childCount > 0)
        {
            //Get and deactivate previous socket's multiple mesh renderers
            Component[] meshRenderers;
            meshRenderers = socketParts[globalIndex - 1].GetComponentsInChildren<MeshRenderer>();
            foreach (MeshRenderer mR in meshRenderers)
            {
                mR.enabled = false;
            }
        }
        else 
        {
            //Deactivate previous socket's mesh renderer
            socketParts[globalIndex - 1].GetComponent<MeshRenderer>().enabled = false;
        }

        //Deactivate previous board part's grabbable component
        boardParts[globalIndex - 1].GetComponent<Collider>().enabled = false;

        //Hide the last mesh renderer
        if (globalIndex == 11)
        {
            //Check if the socket is a single mesh or a group
            if (socketParts[globalIndex].transform.childCount > 0)
            {
                //Get and deactivate previous socket's multiple mesh renderers
                Component[] meshRenderers;
                meshRenderers = socketParts[globalIndex].GetComponentsInChildren<MeshRenderer>();
                foreach (MeshRenderer mR in meshRenderers)
                {
                    mR.enabled = false;
                }
            }
            else
            {
                //Deactivate previous socket's mesh renderer
                socketParts[globalIndex].GetComponent<MeshRenderer>().enabled = false;
            }

            //Deactivate last board part's grabbable component
            boardParts[globalIndex].GetComponent<Collider>().enabled = false;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
