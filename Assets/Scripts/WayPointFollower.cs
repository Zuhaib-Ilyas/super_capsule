using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollower : MonoBehaviour
{
    [SerializeField] GameObject[] wayPoints;
    int currentWayPointsIndex = 0;
    [SerializeField] float speed = 1f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, wayPoints[currentWayPointsIndex].transform.position)<0.1f)
        {
            currentWayPointsIndex++;
            if (currentWayPointsIndex >= wayPoints.Length)
            {
                currentWayPointsIndex = 0;
            }
        }



        transform.position = Vector3.MoveTowards(transform.position, wayPoints[currentWayPointsIndex].transform.position, speed * Time.deltaTime);
    }
}
