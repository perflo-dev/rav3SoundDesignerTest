using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstep_script : MonoBehaviour
    {
        public AK.Wwise.Event footstep;
        public GameObject foot;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown("w"))
            {
                footstep.Post(foot);                
            }
        if (Input.GetKeyUp("w"))
        {
            footstep.Stop(foot);
        }
        if (Input.GetKeyDown("a"))
        {
            footstep.Post(foot);
        }
        if (Input.GetKeyUp("a"))
        {
            footstep.Stop(foot);
        }
        if (Input.GetKeyDown("s"))
        {
            footstep.Post(foot);
        }
        if (Input.GetKeyUp("s"))
        {
            footstep.Stop(foot);
        }
        if (Input.GetKeyDown("d"))
        {
            footstep.Post(foot);
        }
        if (Input.GetKeyUp("d"))
        {
            footstep.Stop(foot);
        }
    }
    }