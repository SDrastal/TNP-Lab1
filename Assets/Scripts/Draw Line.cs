using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    public enum PieceType { Pawn, Rook, Knight, Bishop, Queen, King }
    [SerializeField] private PieceType pieceType;

    [ColorUsage(true, true)]
    public Color pieceColor;

    #if UNITY_EDITOR
    void OnDrawGizmos()
    {
        Gizmos.color = pieceColor;
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
    void OnDrawGizmosSelected()
    {
        switch (pieceType)
        {
            case PieceType.Pawn:
                Gizmos.DrawLine(transform.position + Vector3.up, transform.position - Vector3.up);
                Gizmos.DrawLine(transform.position + Vector3.left, transform.position - Vector3.left);
                break;
            case PieceType.Rook:
                Gizmos.DrawLine(transform.position + Vector3.up, transform.position - Vector3.up);
                Gizmos.DrawLine(transform.position + Vector3.left, transform.position - Vector3.left);
                break;
            case PieceType.Knight:
                Gizmos.DrawLine(transform.position + Vector3.up, transform.position - Vector3.up);
                Gizmos.DrawLine(transform.position + Vector3.left, transform.position - Vector3.left);
                break;
            case PieceType.Bishop:
                Gizmos.DrawLine(transform.position + Vector3.up, transform.position - Vector3.up);
                Gizmos.DrawLine(transform.position + Vector3.left, transform.position - Vector3.left);
                break;
            case PieceType.Queen:
                Gizmos.DrawLine(transform.position + Vector3.up, transform.position - Vector3.up);
                Gizmos.DrawLine(transform.position + Vector3.left, transform.position - Vector3.left);
                break;
            case PieceType.King:
                Gizmos.DrawLine(transform.position + Vector3.up, transform.position - Vector3.up);
                Gizmos.DrawLine(transform.position + Vector3.left, transform.position - Vector3.left);
                break;
        }
    }
    #endif
}
