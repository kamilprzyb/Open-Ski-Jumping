using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Jumper/JumperPose")]
public class JumperPose : ScriptableObject
{
    public float bodyAngle;
    public float kneesAngle;
    public float anklesAngle;
}