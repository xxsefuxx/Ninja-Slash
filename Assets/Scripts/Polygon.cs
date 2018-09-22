﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polygon {

    Vector3[] vertices;
    int[] indices;
    Mesh mesh;
    
    public float area;

    public Polygon(Vector3[] PolygonVertices)
    {
        vertices = PolygonVertices;
    }
    public void SetVertices(Vector3[] PolygonVertices)
    {
        vertices = PolygonVertices;
    }
    public void SetMesh(Mesh PolygonMesh)
    {
        mesh = PolygonMesh;
    }
    public Vector3[] GetVertices()
    {
        return vertices;
    }
    public Mesh GetMesh()
    {
        return mesh;
    }
   
    
    public void SetIndices(int[] ind)
    {
        indices = ind;
    }
    public int[] GetIndices()
    {
        return indices;
    }
}