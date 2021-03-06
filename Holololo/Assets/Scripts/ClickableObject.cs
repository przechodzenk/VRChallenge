﻿using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClickableObject : MonoBehaviour, IInputClickHandler
{
    private Renderer render;
    private GameObject cursor;
    private Objects objects;

    public void Start()
    {
        objects = FindObjectOfType<Objects>();
        cursor = GameObject.Find("DefaultCursor").gameObject;
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if(tag == "Ball")
        {
            if (objects.ball != null && objects.target == null)
            {
                objects.target = gameObject;
            }
            else
            {
                objects.ball = gameObject;
            }
            Debug.Log("Licked ball");
        }
        else if(tag == "Target")
        {
            objects.target = gameObject;
            Debug.Log("Clicked target");
        }
        else
        {
            GameObject point = new GameObject();
            point.transform.position = cursor.transform.position;
            objects.target = point;
        }
    }

    private void shaderSet(Renderer render, Shader shader)
    {
        if (render.materials[1] != null)
            render.materials[1].shader = shader;
        render.materials[0].shader = shader;
    }
}
