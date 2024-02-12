using UnityEngine;
using GameDev.Tool_BCY;

public class GameManager : Singleton<GameManager>
{
    private Transform _mainCamera;
    private Transform _mainCameraParent;
    private Transform _mainPlayer;


    protected override void Awake()
    {
        base.Awake();
        Init();
    }

    private void Init()
    {
        _mainCamera = GameObject.FindWithTag("MainCamera").transform;
        _mainPlayer = GameObject.FindWithTag("Player").transform;
        _mainCameraParent = _mainCamera.root;
    }

    protected override void OnDestroy()
    {
        base.OnDestroy();
        _mainCamera = null;
        _mainPlayer = null;
        _mainCameraParent = null;
    }


    public Transform GetMainPlayer() => _mainPlayer;
    public Transform GetMainCamera() => _mainCamera;
    public Transform GetMainCameraParent() => _mainCameraParent;
}
