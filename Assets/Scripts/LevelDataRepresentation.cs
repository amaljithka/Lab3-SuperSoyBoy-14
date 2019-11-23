using UnityEngine;
using System;
[Serializable]

public class LevelDataRepresentation
{
    public Vector2 playerStartPosition;
    public CameraSettingsRepresentation cameraSettings;
    public LevelItemRepresentation[] levelItems;

    public Vector3 rotation;
    public Vector3 scale;
    public Vector2 position;
    public string prefabName;
    public int spriteOrder;
    public string spriteLayer;
    public Color spriteColor;
}