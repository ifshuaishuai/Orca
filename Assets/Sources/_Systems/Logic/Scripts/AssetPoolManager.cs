﻿using System.Collections;
using System.Collections.Generic;
using RSG;
using UnityEngine;

public class AssetPoolManager
{
    private static AssetPoolManager _instance;

    public static AssetPoolManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new AssetPoolManager();
            }

            return _instance;
        }
    }

    private GameObject _characterAsset;
    private GameObject _puppyAsset;
    private GameObject _mapAsset;
    
    public AssetPoolManager()
    {
    }

    public IPromise Initialize(int characterSize, int puppySize, int mapSize)
    {
        var promise = new Promise();

        InitializeCharacter(characterSize);
        InitializePuppy(puppySize);
        InitializeMap(mapSize);
        
        promise.Resolve();

        return promise;
    }

    private void InitializeMap(int mapSize)
    {
        _mapAsset = Resources.Load<GameObject>("Map_Template");
        
        PoolManager.Instance.WarmPool(_mapAsset, mapSize);
    }

    private void InitializeCharacter(int characterSize)
    {
         _characterAsset = Resources.Load<GameObject>("Character_Template");
        
        PoolManager.Instance.WarmPool(_characterAsset, characterSize);
    }
    
    private void InitializePuppy(int puppySize)
    {
         _puppyAsset = Resources.Load<GameObject>("Puppy_Template");
        
        PoolManager.Instance.WarmPool(_puppyAsset, puppySize);
    }

    public GameObject SpawnCharacter(Vector3 position, Quaternion rotation)
    {
        return PoolManager.Instance.SpawnObject(_characterAsset, position, rotation);
    }
    
    public GameObject SpawnCharacter()
    {
        return PoolManager.Instance.SpawnObject(_characterAsset);
    }

    public void DestroyCharacter(GameObject character)
    {
        PoolManager.Instance.ReleaseObject(character);
    }

    public GameObject SpawnMap(Vector3 position, Quaternion rotation)
    {
        return PoolManager.Instance.SpawnObject(_mapAsset, position, rotation);
    }
    
    public GameObject SpawnMap()
    {
        return PoolManager.Instance.SpawnObject(_mapAsset);
    }

    public void DestroyMap(GameObject map)
    {
        PoolManager.Instance.ReleaseObject(map);
    }

    public GameObject SpawnPuppy(Vector3 position, Quaternion rotation)
    {
        return PoolManager.Instance.SpawnObject(_puppyAsset, position, rotation);
    }
    
    public GameObject SpawnPuppy()
    {
        return PoolManager.Instance.SpawnObject(_puppyAsset);
    }

    public void DestroyPuppy(GameObject puppy)
    {
        PoolManager.Instance.ReleaseObject(puppy);
    }
}
