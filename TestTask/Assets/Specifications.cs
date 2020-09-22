using System.Collections.Generic;

public class Specifications
{
    public struct specifications
    {
        public MassClassEnum name;

        public float minMass;
        public float maxMass;

        public float minRad;
        public float maxRad;
    }
    public List<specifications> metrixs;

    public Specifications()
    {
        metrixs = new List<specifications>();
        metrixs.Add(new specifications { name = MassClassEnum.Asteroidan, minMass = 0f, maxMass = 0.00001f, minRad = 0, maxRad = 0.03f });
        metrixs.Add(new specifications { name = MassClassEnum.Mercurian, minMass = 0.00001f, maxMass = 0.1f, minRad = 0.03f, maxRad = 0.7f });
        metrixs.Add(new specifications { name = MassClassEnum.Subterran, minMass = 0.1f, maxMass = 0.5f, minRad = 0.5f, maxRad = 1.2f });
        metrixs.Add(new specifications { name = MassClassEnum.Terran, minMass = 0.5f, maxMass = 2, minRad = 0.8f, maxRad = 1.9f });
        metrixs.Add(new specifications { name = MassClassEnum.Superterran, minMass = 2f, maxMass = 10, minRad = 1.3f, maxRad = 3.3f });
        metrixs.Add(new specifications { name = MassClassEnum.Neptunian, minMass = 10f, maxMass = 50, minRad = 2.1f, maxRad = 5.7f });
        metrixs.Add(new specifications { name = MassClassEnum.Jovian, minMass = 50f, maxMass = 5000, minRad = 3.5f, maxRad = 27f });
    }
}
