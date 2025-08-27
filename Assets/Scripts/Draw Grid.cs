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
        while (i < 9)
        {
            Gizmos.DrawLine(new Vector3(i, 0, 0), new Vector3(i, 8, 0));
            ++i;
        }
        while (j < 9)
        {
            Gizmos.DrawLine(new Vector3(0, j, 0), new Vector3(8, j, 0));
            ++j;
        }
    }
#endif
}
