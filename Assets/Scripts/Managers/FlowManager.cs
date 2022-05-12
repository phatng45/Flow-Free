using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FlowManager : MonoBehaviour
{
    public static            FlowManager    Instance;
    private                  List<BaseFlow> flows;
    [SerializeField] private FlowHead       flowHead;
    private                  BaseFlow       selectedFlow;

    private void Awake()
    {
        Instance = this;
    }

    public void PlaceHead(Color color, int x, int y)
    {
        var flow = Instantiate(flowHead, new Vector3(x,y), Quaternion.identity);
        flow.name                                    = $"Head {x} {y}";
        flow.GetComponent<Renderer>().material.color = color;
        flow.GameObject().layer                      = 2;
    }

    public void SetSelectedFlow(BaseFlow flow)
    {
        selectedFlow = flow;
    }
}
