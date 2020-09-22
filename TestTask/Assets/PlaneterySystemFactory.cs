using UnityEngine;

public class PlaneterySystemFactory : MonoBehaviour, IPlaneterySystemFactory
{
    [SerializeField] GameObject planetPrefab;
    [SerializeField] float maxDistance;

    

    public IPlaneterySystem Create(float mass)
    {
        GameObject system = new GameObject(name = "PlaneterySystem");
        PlanetrySystem planeterySystem = system.AddComponent<PlanetrySystem>();
        Specifications specific = new Specifications();

        while (mass > 0)
        {
            float newPlanetMass = 0.01f;
            if (mass > 0.01f)
                newPlanetMass = Random.Range(0, mass);
            else
                newPlanetMass = mass;
            foreach (var spec in specific.metrixs)
            {
                if(newPlanetMass <= spec.maxMass && newPlanetMass >= spec.minMass)
                {
                    float radius = Mathf.Lerp(spec.minRad, spec.maxRad, (float)(mass - spec.minMass) / (spec.maxMass - spec.minMass));                    
                    GameObject planet = Instantiate(planetPrefab);
                    planet.transform.localScale = new Vector3(radius, radius, radius);
                    float orbit = Random.Range(-maxDistance, maxDistance);
                    Debug.Log(orbit);                    
                    planet.transform.position = new Vector3(orbit,0);
                    planet.AddComponent<PlaneteryObject>();
                    PlaneteryObject planeteryObject = planet.GetComponent<PlaneteryObject>();
                    planeteryObject.massclass = spec.name;
                    planeteryObject.mass = newPlanetMass;
                    planeteryObject.radius = radius;
                    planeterySystem.planeteryObjects.Add(planet.GetComponent<PlaneteryObject>());
                }
            }
            mass -= newPlanetMass;
        }

        return planeterySystem;
    }
    // Start is called before the first frame update
    void Start()
    {        
        Create(1f);
    }
}
