using CoreRuntime.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace FlipaScreen
{
    internal class headflippa : HexedCheat
    {

        public static void Update()
        {
            if (!Input.GetKey(KeyCode.LeftControl)) return;

            Camera camera = Camera.main;
            if (camera == null) return;

            float mouseWheel = Input.GetAxis("Mouse ScrollWheel");
            if (mouseWheel > 0.1)
            {
                Quaternion quaternion = camera.transform.rotation;
                Vector3 euler = quaternion.eulerAngles;
                euler -= Vector3.forward;
                camera.transform.rotation = Quaternion.Euler(euler);
            }
            else if (mouseWheel < -0.1)
            {
                Quaternion quaternion = camera.transform.rotation;
                Vector3 euler = quaternion.eulerAngles;
                euler += Vector3.forward;
                camera.transform.rotation = Quaternion.Euler(euler);
            }
        }
    }
}
