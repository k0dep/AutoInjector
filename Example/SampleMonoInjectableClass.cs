using UnityEngine;

namespace AutoInjector.Examples
{
    public class SampleMonoInjectableClass : MonoBehaviour
    {
        public SampleClass TargetProperty
        {
            get { return null;}
            set { Debug.Log($"Install {nameof(TargetProperty)}"); }
        }

        public ISampleClass TargetPropertyInterface
        {
            get { return null;}
            set { Debug.Log($"Install {nameof(TargetPropertyInterface)}"); }
        }
    }
}