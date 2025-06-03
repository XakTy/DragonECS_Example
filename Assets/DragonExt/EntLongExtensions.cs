using DCFApixels.DragonECS.EntLongExtensions.Internal;
using System.Runtime.CompilerServices;
using DCFApixels.DragonECS.Core;
#if ENABLE_IL2CPP
using Unity.IL2CPP.CompilerServices;

// Unity IL2CPP performance optimization attribute.
namespace Unity.IL2CPP.CompilerServices 
{
    using System;
    internal enum Option 
    {
        NullChecks = 1,
        ArrayBoundsChecks = 2,
        DivideByZeroChecks = 3,
    }
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Delegate, Inherited = false, AllowMultiple = true)]
    internal class Il2CppSetOptionAttribute : Attribute
    {
        public Option Option { get; private set; }
        public object Value { get; private set; }
        public Il2CppSetOptionAttribute(Option option, object value)
        {
            Option = option;
            Value = value;
        }
    }
}
#endif

namespace DCFApixels.DragonECS
{
#if ENABLE_IL2CPP
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
#endif
    internal static class EntLongBaseExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static entlong Clone(in this entlong self)
        {
#if (DEBUG && !DISABLE_DEBUG) || ENABLE_DRAGONECS_ASSERT_CHEKS
            if (self.IsAlive == false) { Throw.Ent_ThrowIsNotAlive(self); }
#endif
            var world = self.GetWorldUnchecked();
            entlong result = world.NewEntityLong();
            world.CopyEntity(self.GetIDUnchecked(), result.GetIDUnchecked());
            return result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static entlong Clone(in this entlong self, EcsWorld toWorld)
        {
#if (DEBUG && !DISABLE_DEBUG) || ENABLE_DRAGONECS_ASSERT_CHEKS
            if (self.IsAlive == false) { Throw.Ent_ThrowIsNotAlive(self); }
#endif
            entlong result = toWorld.NewEntityLong();
            self.GetWorldUnchecked().CopyEntity(self.GetIDUnchecked(), toWorld, result.GetIDUnchecked());
            return result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsMatchesMask(in this entlong self, IComponentMask mask)
        {
#if (DEBUG && !DISABLE_DEBUG) || ENABLE_DRAGONECS_ASSERT_CHEKS
            if (self.IsAlive == false) { Throw.Ent_ThrowIsNotAlive(self); }
#endif
            return self.GetWorldUnchecked().IsMatchesMask(mask, self.GetIDUnchecked());
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsMatchesMask(in this entlong self, EcsMask mask)
        {
#if (DEBUG && !DISABLE_DEBUG) || ENABLE_DRAGONECS_ASSERT_CHEKS
            if (self.IsAlive == false) { Throw.Ent_ThrowIsNotAlive(self); }
#endif
            return self.GetWorldUnchecked().IsMatchesMask(mask, self.GetIDUnchecked());
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short GetComponentsCount(in this entlong self)
        {
#if (DEBUG && !DISABLE_DEBUG) || ENABLE_DRAGONECS_ASSERT_CHEKS
            if (self.IsAlive == false) { Throw.Ent_ThrowIsNotAlive(self); }
#endif
            return self.GetWorldUnchecked().GetComponentsCount(self.GetIDUnchecked());
        }
    }

    #region EntLongPoolExtensions
#if ENABLE_IL2CPP
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
#endif
    internal static class EntLongPoolExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Has<T>(in this entlong self) where T : struct, IEcsComponent
        {
#if (DEBUG && !DISABLE_DEBUG) || ENABLE_DRAGONECS_ASSERT_CHEKS
            if (self.IsAlive == false) { Throw.Ent_ThrowIsNotAlive(self); }
#endif
            return EcsWorld.GetPoolInstance<EcsPool<T>>(self.GetWorldIDUnchecked()).Has(self.GetIDUnchecked());
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T Get<T>(in this entlong self) where T : struct, IEcsComponent
        {
#if (DEBUG && !DISABLE_DEBUG) || ENABLE_DRAGONECS_ASSERT_CHEKS
            if (self.IsAlive == false) { Throw.Ent_ThrowIsNotAlive(self); }
#endif
            return ref EcsWorld.GetPoolInstance<EcsPool<T>>(self.GetWorldIDUnchecked()).TryAddOrGet(self.GetIDUnchecked());
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Del<T>(in this entlong self) where T : struct, IEcsComponent
        {
#if (DEBUG && !DISABLE_DEBUG) || ENABLE_DRAGONECS_ASSERT_CHEKS
            if (self.IsAlive == false) { Throw.Ent_ThrowIsNotAlive(self); }
#endif
            EcsWorld.GetPoolInstance<EcsPool<T>>(self.GetWorldIDUnchecked()).TryDel(self.GetIDUnchecked());
        }
    }
    #endregion

    #region EntLongTagPoolExtensions
#if ENABLE_IL2CPP
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
#endif
    internal static class EntLongTagPoolExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Add<T>(in this entlong self) where T : struct, IEcsTagComponent
        {
#if (DEBUG && !DISABLE_DEBUG) || ENABLE_DRAGONECS_ASSERT_CHEKS
            if (self.IsAlive == false) { Throw.Ent_ThrowIsNotAlive(self); }
#endif
            EcsWorld.GetPoolInstance<EcsTagPool<T>>(self.GetWorldIDUnchecked()).TryAdd(self.GetIDUnchecked());
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Set<T>(in this entlong self, bool value) where T : struct, IEcsTagComponent
        {
#if (DEBUG && !DISABLE_DEBUG) || ENABLE_DRAGONECS_ASSERT_CHEKS
            if (self.IsAlive == false) { Throw.Ent_ThrowIsNotAlive(self); }
#endif
            EcsWorld.GetPoolInstance<EcsTagPool<T>>(self.GetWorldIDUnchecked()).Set(self.GetIDUnchecked(), value);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Toggle<T>(in this entlong self) where T : struct, IEcsTagComponent
        {
#if (DEBUG && !DISABLE_DEBUG) || ENABLE_DRAGONECS_ASSERT_CHEKS
            if (self.IsAlive == false) { Throw.Ent_ThrowIsNotAlive(self); }
#endif
            EcsWorld.GetPoolInstance<EcsTagPool<T>>(self.GetWorldIDUnchecked()).Toggle(self.GetIDUnchecked());
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Has<T>(in this entlong self) where T : struct, IEcsTagComponent
        {
#if (DEBUG && !DISABLE_DEBUG) || ENABLE_DRAGONECS_ASSERT_CHEKS
            if (self.IsAlive == false) { Throw.Ent_ThrowIsNotAlive(self); }
#endif
            return EcsWorld.GetPoolInstance<EcsTagPool<T>>(self.GetWorldIDUnchecked()).Has(self.GetIDUnchecked());
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Del<T>(in this entlong self) where T : struct, IEcsTagComponent
        {
#if (DEBUG && !DISABLE_DEBUG) || ENABLE_DRAGONECS_ASSERT_CHEKS
            if (self.IsAlive == false) { Throw.Ent_ThrowIsNotAlive(self); }
#endif
            EcsWorld.GetPoolInstance<EcsTagPool<T>>(self.GetWorldIDUnchecked()).TryDel(self.GetIDUnchecked());
        }
    }
    #endregion
}

namespace DCFApixels.DragonECS.EntLongExtensions.Internal
{
    internal static class Throw
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void Ent_ThrowIsNotAlive(entlong entity)
        {
            if (entity.IsNull)
            {
               
            }
            else
            {
          
            }
        }
    }
}