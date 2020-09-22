using System.Collections.Generic;
using UnityEngine;

public class PlanetrySystem :MonoBehaviour, IPlaneterySystem
{
    public List<PlaneteryObject> planeteryObjects = new List<PlaneteryObject>();
    public IEnumerable<IPlaneteryObject> PlaneteryObjects => planeteryObjects;
    
    public void FixedUpdate()
    {
        float time = Time.timeSinceLevelLoad;
        float speed = 20f;
        foreach(var planet in planeteryObjects)
        {
            Vector3 targetVector = planet.transform.position.normalized;
            targetVector = Quaternion.Euler(0, 90, 0) * targetVector;
            planet.gameObject.GetComponent<Rigidbody>().velocity = speed * targetVector * Time.deltaTime;
            targetVector = Quaternion.Euler(0, 90, 0) * targetVector;
            planet.gameObject.GetComponent<Rigidbody>().AddForce(speed * targetVector * Time.deltaTime, ForceMode.Force);
        }
    }
}
