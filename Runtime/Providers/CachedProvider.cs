using System;
using System.Runtime.CompilerServices;

namespace EasyUnity.Providers {
    public class CachedProvider : IProvider {
        private readonly Container _Container;
        private readonly Type _Type;
        private bool _Created;
        private object _Instance;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public object GetInstance() {
            if (_Created)
                return _Instance;
            _Instance = _Container.CreateInstance(_Type);
            _Created = true;
            return _Instance;
        }

        public CachedProvider(Container container, Type type) {
            _Container = container;
            _Type = type;
        }
    }
}
