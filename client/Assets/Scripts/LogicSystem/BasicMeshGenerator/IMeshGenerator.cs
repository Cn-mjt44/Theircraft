﻿using protocol.cs_theircraft;
using System.Collections.Generic;
using UnityEngine;

public abstract class IMeshGenerator
{
    //方块图集的行数和列数
    protected static readonly int atlas_row = 58;
    protected static readonly int atlas_column = 24;
    
    protected static Vector3 nearBottomLeft = new Vector3(-0.5f, -0.5f, -0.5f);
    protected static Vector3 nearBottomRight = new Vector3(0.5f, -0.5f, -0.5f);
    protected static Vector3 nearTopLeft = new Vector3(-0.5f, 0.5f, -0.5f);
    protected static Vector3 nearTopRight = new Vector3(0.5f, 0.5f, -0.5f);
    protected static Vector3 farBottomLeft = new Vector3(-0.5f, -0.5f, 0.5f);
    protected static Vector3 farBottomRight = new Vector3(0.5f, -0.5f, 0.5f);
    protected static Vector3 farTopLeft = new Vector3(-0.5f, 0.5f, 0.5f);
    protected static Vector3 farTopRight = new Vector3(0.5f, 0.5f, 0.5f);

    // because we pack textures so tightly, we need to manipulate uv coords slightly when sampling the texture.
    protected static readonly float compensation = 0.005f;
    
    abstract public Mesh GenerateSingleMesh(CSBlockType type);
    virtual public void GenerateMeshInChunk(CSBlockType type, Vector3Int posInChunk, Vector3Int globalPos, List<Vector3> vertices, List<Vector2> uv, List<int> triangles)
    {

    }

    protected static void AddUV(List<Vector3> vertices, List<Vector2> uv, List<int> triangles, Vector2 texPos)
    {
        //上下翻转
        texPos.y = (atlas_row - 1) - texPos.y;

        // bottom left
        uv.Add(new Vector2((texPos.x + compensation) / atlas_column, (texPos.y + compensation) / atlas_row));
        // top left
        uv.Add(new Vector2((texPos.x + compensation) / atlas_column, (texPos.y + 1 - compensation) / atlas_row));
        // top right
        uv.Add(new Vector2((texPos.x + 1 - compensation) / atlas_column, (texPos.y + 1 - compensation) / atlas_row));
        // bottom right
        uv.Add(new Vector2((texPos.x + 1 - compensation) / atlas_column, (texPos.y + compensation) / atlas_row));

        int verticesCount = vertices.Count;
        triangles.Add(verticesCount - 4);
        triangles.Add(verticesCount - 3);
        triangles.Add(verticesCount - 2);
        triangles.Add(verticesCount - 4);
        triangles.Add(verticesCount - 2);
        triangles.Add(verticesCount - 1);
    }

    static Dictionary<string, Mesh> meshDict = new Dictionary<string, Mesh>();
    protected static Mesh LoadMesh(string path)
    {
        if (!meshDict.ContainsKey(path))
        {
            meshDict.Add(path, Resources.Load<Mesh>(path));
        }
        return meshDict[path];
    }
}
