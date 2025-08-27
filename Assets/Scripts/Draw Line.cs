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

}
