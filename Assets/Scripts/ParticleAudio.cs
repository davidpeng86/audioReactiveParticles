using UnityEngine;
using System.Collections;

namespace Reaktion {

[AddComponentMenu("Reaktion/Gear/Light Gear")]
public class ParticleAudio : MonoBehaviour {

	ParticlePlexus pp;
	public ReaktorLink reaktor;
    public Modifier intensity;
    public bool enableColor;
    public Gradient colorGradient;

    
    void Awake()
    {
        pp = GetComponent<ParticlePlexus>();
        reaktor.Initialize(this);
        UpdateLight(0);
    }

    void Update()
    {   
        UpdateLight(reaktor.Output);
    }

    void UpdateLight(float param)
    {
        if (intensity.enabled){
            pp.maxConnections = (int)(intensity.Evaluate(param)*10);
            //GetComponent<Light>().intensity = intensity.Evaluate(param);

        }
        if (enableColor){
            pp.maxDistance = (int)(intensity.Evaluate(param)*5);
            pp.SC = colorGradient.Evaluate(param);
            pp.EC = colorGradient.Evaluate( 1 - param);
            //GetComponent<Light>().color = colorGradient.Evaluate(param);
        }
    }
}

} // namespace Reaktion