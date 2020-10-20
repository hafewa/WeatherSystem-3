using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manageWeather : MonoBehaviour
{
    public GameObject dust;
    public GameObject rain;
    public GameObject snow;
    public float distancePlanet;
    public float distanceCloud;
    public Text distanceTxt;
    public LayerMask layerforPlanet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit , 10000,layerforPlanet))
        {
            if (hit.collider.tag == "planet")
            {
                distancePlanet = Vector3.Distance(transform.position, hit.point);
            }
        }
        RaycastHit hit2;
        if (Physics.Raycast(transform.position, Vector3.up, out hit2))
        {
            if (hit2.collider.tag == "cloud")
            {
                distanceCloud = Vector3.Distance(transform.position, hit2.point);
                distanceTxt.text = ((int)distanceCloud).ToString();
               // Debug.Log(distanceCloud);
            }
        }

        if (distancePlanet < 300) ///wind & dust
        {
            if (!dust.activeSelf)
            {
                dust.SetActive(true);
                rain.SetActive(false);
                snow.SetActive(false);
            }
        }
        if (distancePlanet >= 300 && distancePlanet < 500) ///rain
        {
            if (!rain.activeSelf)
            {
                dust.SetActive(false);
                rain.SetActive(true);
                snow.SetActive(false);
            }
        }
        if(distancePlanet>500) ///snow
        {
            if (!snow.activeSelf)
            {
                dust.SetActive(false);
                rain.SetActive(false);
                snow.SetActive(true);
            }
        }

    }
}
