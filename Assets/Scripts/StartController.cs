using System;
using System.Collections;
using System.Collections.Generic;
using Core.Systems;
using Descriptions.SO.Player;
using Player;
using UnityEngine;

public class StartController : MonoBehaviour
{
    [SerializeField] private PlayerDescriptionSO _description; 
    private PlayerManager _playerManager = new PlayerManager();

    private void Awake()
    {
        
    }

    void Start()
    {
        _playerManager.InitializePlayer(_description);
    }

    void Update()
    {
        UpdateSystem.Instance.ManualUpdate(Time.deltaTime);
    }

    public void PreInit()
    {
        
    }

    public void Init()
    {
        
    }

    public void PostInit()
    {
        
    }
}
