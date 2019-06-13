using System.Reflection;
using System.Linq;
using TypeInspector;
using UnityEngine;
using Zenject;

namespace AutoInjector
{
    public class AutoInjectorList : MonoBehaviour
    {
        public TypeReference Type;
        
        [PropertyFilter(nameof(FilterTargetProperty))]
        public MonoPropertyReference[] TargetProperties;

        [Inject]
        public void Inject(DiContainer ctx)
        {
            if (!Type.IsValid())
            {
                Debug.LogError("Type is invalid!", this);
            }

            if (!TargetProperties.All(p => p.IsValid()))
            {
                Debug.LogError("Target property is invalid!", this);
            }

            var instance = ctx.Resolve(Type.Get());
            
            foreach(var target in TargetProperties)
            {
                target.Set(instance);
            }
        }

        private bool FilterTargetProperty(PropertyInfo property)
        {
            return Type.IsValid() && property.PropertyType.IsAssignableFrom(Type.Get());
        }
    }
}