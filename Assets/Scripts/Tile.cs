using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color          baseColor, offsetColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject     highlight;
    [SerializeField] private BaseFlow       occupiedFlow;

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

    private void setFlow(BaseFlow flow)
    {
        if (flow.occupiedTile != null) flow.occupiedTile.occupiedFlow = null;

        flow.transform.position = transform.position;
        occupiedFlow            = flow;
        flow.occupiedTile       = this;
    }

    private bool _dragging;

    void OnMouseDown()
    {
        _dragging = true;

        if (occupiedFlow != null)
        {
            FlowManager.Instance.SetSelectedFlow(occupiedFlow);
        }
    }
}