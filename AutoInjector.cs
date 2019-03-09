using System.Reflection;
using TypeInspector;
using UnityEngine;
using Zenject;

namespace AutoInjector
{
    public class AutoInjector : MonoBehaviour
    {
        public TypeReference Type;
        
        [PropertyFilter(nameof(FilterTargetProperty))]
        public MonoPropertyReference TargetProperty;

        [Inject]
        public void Inject(DiContainer ctx)
        {
            if (!Type.IsValid())
            {
                Debug.LogError("Type is invalid!", this);
            }

            if (!TargetProperty.IsValid())
            {
                Debug.LogError("Target property is invalid!", this);
            }

            var instance = ctx.Resolve(Type.Get());
            
            TargetProperty.Set(instance);
        }

        private bool FilterTargetProperty(PropertyInfo property)
        {
            return Type.IsValid() && property.PropertyType.IsAssignableFrom(Type.Get());
        }
    }
}