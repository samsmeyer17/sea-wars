// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityStandardAssets.CrossPlatformInput;

// public class BlasterHandler : MonoBehaviour
// {
//     [SerializeField] GameObject blasterFX1;
//     [SerializeField] GameObject blasterFX2;
//     float blasterThrow;



//     // Update is called once per frame
//     void Update()
//     {
//         ProcessBlaster();
//     }

//     void ProcessBlaster()
//     {
//         blasterThrow = CrossPlatformInputManager.GetAxis("Fire1");
//         if (blasterThrow > 0)
//         {
//             blasterFX1.SetActive(true);
//             blasterFX2.SetActive(true);
//         }
//         else
//         {
//             blasterFX1.SetActive(false);
//             blasterFX2.SetActive(false);
//         }
//     }
// }
