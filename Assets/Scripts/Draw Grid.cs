using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoardCreator : MonoBehaviour
{
#if UNITY_EDITOR
    void OnDrawGizmos()
    {
        int i = 0;
        int j = 0;
        while (i < 90)
        {
        Gizmos.DrawLine(new Vector3(i, 0, 0), new Vector3(i, 80, 0));
        i += 10;
        }

        while (j < 90)
        {
            Gizmos.DrawLine(new Vector3(0, j, 0), new Vector3(80, j, 0));
            j += 10;
        }



    }
#endif
}
