using UnityEngine;
public class PlaneteryObject : MonoBehaviour, IPlaneteryObject
{   public MassClassEnum massclass { get; set; }
    public double mass { get; set; }
    public float radius { get; set; }
}
