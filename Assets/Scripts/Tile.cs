using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color          baseColor, offsetColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject     highlight;
    [SerializeField] private GameObject     occupiedFlow;

    internal void Init(bool isOffset)
    {
        _renderer.color = isOffset ? baseColor : offsetColor;
    }

    private void OnMouseEnter()
    {
        highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        highlight.SetActive(false);
    }
}