using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    //INSPECTOR VARIABLES
    //Dropdown selection
    public enum PieceType { Pawn, Rook, Knight, Bishop, Queen, King }
    [SerializeField] private PieceType pieceType;

    //Color picker
    [ColorUsage(true, true)]
    public Color pieceColor;

    //Always showing
    #if UNITY_EDITOR
    void OnDrawGizmos()
    {
        //Show icon in selected color
        Gizmos.color = pieceColor;

        //Show correct icon
        switch (pieceType)
        {
            case PieceType.Pawn:
                Gizmos.DrawIcon(transform.position, "pawn.png", true, pieceColor);
                break;
            case PieceType.Rook:
                Gizmos.DrawIcon(transform.position, "rook.png", true, pieceColor);
                break;
            case PieceType.Knight:
                Gizmos.DrawIcon(transform.position, "knight.png", true, pieceColor);
                break;
            case PieceType.Bishop:
                Gizmos.DrawIcon(transform.position, "bishop.png", true, pieceColor);
                break;
            case PieceType.Queen:
                Gizmos.DrawIcon(transform.position, "queen.png", true, pieceColor);
                break;
            case PieceType.King:
                Gizmos.DrawIcon(transform.position, "king.png", true, pieceColor);
                break;
        }
    }

    //When piece is selected
    void OnDrawGizmosSelected()
    {
        //
        switch (pieceType)
        {
            case PieceType.Pawn:
                Gizmos.DrawLine(transform.position + Vector3.up, transform.position - Vector3.up);
                Gizmos.DrawLine(transform.position + Vector3.left, transform.position - Vector3.left);
                break;
            case PieceType.Rook:
                Gizmos.DrawLine(transform.position + Vector3.up * 7, transform.position - Vector3.up * 7);
                Gizmos.DrawLine(transform.position + Vector3.left * 7, transform.position - Vector3.left  * 7);
                break;
            case PieceType.Knight:
                Gizmos.DrawLine(transform.position + Vector3.up * 2, transform.position - Vector3.up * 2);
                Gizmos.DrawLine(transform.position + (Vector3.up * 2) + Vector3.left, transform.position + (Vector3.up * 2) + Vector3.right);
                Gizmos.DrawLine(transform.position + (-Vector3.up * 2) + Vector3.left, transform.position + (-Vector3.up * 2) + Vector3.right);
                Gizmos.DrawLine(transform.position + Vector3.left * 2, transform.position - Vector3.left * 2);
                Gizmos.DrawLine(transform.position + (Vector3.left * 2) + Vector3.up, transform.position + (Vector3.left * 2) - Vector3.up);
                Gizmos.DrawLine(transform.position + (-Vector3.left * 2) + Vector3.up, transform.position + (-Vector3.left * 2) - Vector3.up);
                break;
            case PieceType.Bishop:
                Gizmos.DrawLine(transform.position + Vector3.up * 7 + Vector3.right * 7, transform.position - Vector3.up * 7 + Vector3.left * 7);
                Gizmos.DrawLine(transform.position + Vector3.up * 7 + Vector3.left * 7, transform.position - Vector3.up * 7 + Vector3.right * 7);
                break;
            case PieceType.Queen:
                Gizmos.DrawLine(transform.position + Vector3.up * 7, transform.position - Vector3.up * 7);
                Gizmos.DrawLine(transform.position + Vector3.up * 7 + Vector3.right * 7, transform.position - Vector3.up * 7 + Vector3.left * 7);
                Gizmos.DrawLine(transform.position + Vector3.left * 7, transform.position - Vector3.left * 7);
                Gizmos.DrawLine(transform.position + Vector3.up * 7 + Vector3.left * 7, transform.position - Vector3.up * 7 + Vector3.right * 7);
                break;
            case PieceType.King:
                Gizmos.DrawLine(transform.position + Vector3.up, transform.position - Vector3.up);
                Gizmos.DrawLine(transform.position + Vector3.up + Vector3.right, transform.position - Vector3.up + Vector3.left);
                Gizmos.DrawLine(transform.position + Vector3.left, transform.position - Vector3.left);
                Gizmos.DrawLine(transform.position + Vector3.up + Vector3.left, transform.position - Vector3.up + Vector3.right);
                break;
        }
    }
    #endif
}
