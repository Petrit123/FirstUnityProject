using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{

    Camera my_camera;
    Controlable currently_selected_object;

    // Start is called before the first frame update
    void Start()
    {
        my_camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        Ray my_ray = my_camera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(my_ray.origin, 20 * my_ray.direction);

        RaycastHit info_on_hit;

        if (Physics.Raycast(my_ray, out info_on_hit))
        {
            Controlable my_object = info_on_hit.transform.GetComponent<Controlable>();
            if (currently_selected_object)
            {
                if (my_object != currently_selected_object)
                {
                    currently_selected_object.deselect();
                    my_object.isSelected();
                    currently_selected_object = my_object;
                }
            }
            else
            {
                my_object.isSelected();
                currently_selected_object = my_object;
            }

            my_object.isSelected = true;
            my_object.move_up();
        }
        }
    }
}
