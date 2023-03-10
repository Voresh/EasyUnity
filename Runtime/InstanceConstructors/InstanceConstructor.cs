using System;
using System.Runtime.CompilerServices;

namespace EasyUnity.InstanceConstructors {
    public abstract class InstanceConstructor {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public abstract bool TryGetInstance(Type type, Container container, out object instance);
    }
}
