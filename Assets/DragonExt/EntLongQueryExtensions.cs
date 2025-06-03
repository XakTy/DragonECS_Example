namespace DCFApixels.DragonECS
{
    using System;
    using System.Runtime.CompilerServices;
    #if ENABLE_IL2CPP
    using Unity.IL2CPP.CompilerServices;
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    #endif

    public static class EntLongQueryExtensions
    {
        #region Tuple syntax
        public static EcsLongsSpan.Enumerator GetEnumerator<TM>(this (EcsDefaultWorld, TM) v)
        where TM : IIncExc
        {
            return v.Item1.Where(v.Item2.Mask).Longs.GetEnumerator();
        }
        public static EcsLongsSpan.Enumerator GetEnumerator<TM>(this (EcsDefaultWorld, TM) v, Comparison<int> comparison)
            where TM : IIncExc
        {
            return v.Item1.Where(v.Item2.Mask, comparison).Longs.GetEnumerator();
        }
        #endregion

        #region Where
        public static EcsSpan Where<TCollection, TM>(this TCollection entities, TM mask)
            where TCollection : IEntityStorage
            where TM : IIncExc
        {
            return entities.Where(mask.Mask);
        }
        public static EcsSpan Where<TM>(this EcsReadonlyGroup group, TM mask)
            where TM : IIncExc
        {
            return group.Where(mask.Mask);
        }
        public static EcsSpan Where<TM>(this EcsSpan span, TM mask)
            where TM : IIncExc
        {
            return span.Where(mask.Mask);
        }
        #endregion

        #region Where with sort
        public static EcsSpan Where<TCollection, TM>(this TCollection entities, TM mask, Comparison<int> comparison)
            where TCollection : IEntityStorage
            where TM : IIncExc
        {
            return entities.Where(mask.Mask);
        }
        public static EcsSpan Where<TM>(this EcsReadonlyGroup group, TM mask, Comparison<int> comparison)
            where TM : IIncExc
        {
            return group.Where(mask.Mask);
        }
        public static EcsSpan Where<TM>(this EcsSpan span, TM mask, Comparison<int> comparison)
            where TM : IIncExc
        {
            return span.Where(mask.Mask);
        }
        #endregion

        public interface IIncExc
        {
            public EcsStaticMask Mask { get; }
        }
    }

    #if ENABLE_IL2CPP
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    #endif
    public readonly struct Inc<INC0> : EntLongQueryExtensions.IIncExc
    {
        public static readonly Inc<INC0> m = default;
        public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Build();
        EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Inc<INC0> v) { return Mask; }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Exc<EXC0>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Exc<EXC0>().Exc<EXC1>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1, EXC2> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1, EXC2> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Exc<EXC0>().Exc<EXC1>().Exc<EXC2>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1, EXC2> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1, EXC2, EXC3> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1, EXC2, EXC3> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Exc<EXC0>().Exc<EXC1>().Exc<EXC2>().Exc<EXC3>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1, EXC2, EXC3> v) { return Mask; }
        }
    
    }
    #if ENABLE_IL2CPP
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    #endif
    internal readonly struct Inc<INC0, INC1> : EntLongQueryExtensions.IIncExc
    {
        public static readonly Inc<INC0, INC1> m = default;
        public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Build();
        EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Inc<INC0, INC1> v) { return Mask; }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Exc<EXC0>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Exc<EXC0>().Exc<EXC1>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1, EXC2> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1, EXC2> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Exc<EXC0>().Exc<EXC1>().Exc<EXC2>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1, EXC2> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1, EXC2, EXC3> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1, EXC2, EXC3> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Exc<EXC0>().Exc<EXC1>().Exc<EXC2>().Exc<EXC3>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1, EXC2, EXC3> v) { return Mask; }
        }
    
    }
    #if ENABLE_IL2CPP
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    #endif
    internal readonly struct Inc<INC0, INC1, INC2> : EntLongQueryExtensions.IIncExc
    {
        public static readonly Inc<INC0, INC1, INC2> m = default;
        public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Build();
        EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Inc<INC0, INC1, INC2> v) { return Mask; }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Exc<EXC0>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Exc<EXC0>().Exc<EXC1>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1, EXC2> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1, EXC2> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Exc<EXC0>().Exc<EXC1>().Exc<EXC2>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1, EXC2> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1, EXC2, EXC3> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1, EXC2, EXC3> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Exc<EXC0>().Exc<EXC1>().Exc<EXC2>().Exc<EXC3>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1, EXC2, EXC3> v) { return Mask; }
        }
    
    }
    #if ENABLE_IL2CPP
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    #endif
    internal readonly struct Inc<INC0, INC1, INC2, INC3> : EntLongQueryExtensions.IIncExc
    {
        public static readonly Inc<INC0, INC1, INC2, INC3> m = default;
        public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Build();
        EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Inc<INC0, INC1, INC2, INC3> v) { return Mask; }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Exc<EXC0>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Exc<EXC0>().Exc<EXC1>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1, EXC2> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1, EXC2> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Exc<EXC0>().Exc<EXC1>().Exc<EXC2>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1, EXC2> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1, EXC2, EXC3> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1, EXC2, EXC3> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Exc<EXC0>().Exc<EXC1>().Exc<EXC2>().Exc<EXC3>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1, EXC2, EXC3> v) { return Mask; }
        }
    
    }
    #if ENABLE_IL2CPP
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    #endif
    internal readonly struct Inc<INC0, INC1, INC2, INC3, INC4> : EntLongQueryExtensions.IIncExc
    {
        public static readonly Inc<INC0, INC1, INC2, INC3, INC4> m = default;
        public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Build();
        EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Inc<INC0, INC1, INC2, INC3, INC4> v) { return Mask; }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Exc<EXC0>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Exc<EXC0>().Exc<EXC1>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1, EXC2> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1, EXC2> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Exc<EXC0>().Exc<EXC1>().Exc<EXC2>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1, EXC2> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1, EXC2, EXC3> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1, EXC2, EXC3> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Exc<EXC0>().Exc<EXC1>().Exc<EXC2>().Exc<EXC3>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1, EXC2, EXC3> v) { return Mask; }
        }
    
    }
    #if ENABLE_IL2CPP
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    #endif
    internal readonly struct Inc<INC0, INC1, INC2, INC3, INC4, INC5> : EntLongQueryExtensions.IIncExc
    {
        public static readonly Inc<INC0, INC1, INC2, INC3, INC4, INC5> m = default;
        public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Inc<INC5>().Build();
        EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Inc<INC0, INC1, INC2, INC3, INC4, INC5> v) { return Mask; }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Inc<INC5>().Exc<EXC0>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Inc<INC5>().Exc<EXC0>().Exc<EXC1>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1, EXC2> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1, EXC2> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Inc<INC5>().Exc<EXC0>().Exc<EXC1>().Exc<EXC2>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1, EXC2> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1, EXC2, EXC3> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1, EXC2, EXC3> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Inc<INC5>().Exc<EXC0>().Exc<EXC1>().Exc<EXC2>().Exc<EXC3>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1, EXC2, EXC3> v) { return Mask; }
        }
    
    }
    #if ENABLE_IL2CPP
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    #endif
    internal readonly struct Inc<INC0, INC1, INC2, INC3, INC4, INC5, INC6> : EntLongQueryExtensions.IIncExc
    {
        public static readonly Inc<INC0, INC1, INC2, INC3, INC4, INC5, INC6> m = default;
        public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Inc<INC5>().Inc<INC6>().Build();
        EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Inc<INC0, INC1, INC2, INC3, INC4, INC5, INC6> v) { return Mask; }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Inc<INC5>().Inc<INC6>().Exc<EXC0>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Inc<INC5>().Inc<INC6>().Exc<EXC0>().Exc<EXC1>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1, EXC2> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1, EXC2> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Inc<INC5>().Inc<INC6>().Exc<EXC0>().Exc<EXC1>().Exc<EXC2>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1, EXC2> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1, EXC2, EXC3> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1, EXC2, EXC3> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Inc<INC5>().Inc<INC6>().Exc<EXC0>().Exc<EXC1>().Exc<EXC2>().Exc<EXC3>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1, EXC2, EXC3> v) { return Mask; }
        }
    
    }
    #if ENABLE_IL2CPP
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    #endif
    internal readonly struct Inc<INC0, INC1, INC2, INC3, INC4, INC5, INC6, INC7> : EntLongQueryExtensions.IIncExc
    {
        public static readonly Inc<INC0, INC1, INC2, INC3, INC4, INC5, INC6, INC7> m = default;
        public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Inc<INC5>().Inc<INC6>().Inc<INC7>().Build();
        EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Inc<INC0, INC1, INC2, INC3, INC4, INC5, INC6, INC7> v) { return Mask; }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Inc<INC5>().Inc<INC6>().Inc<INC7>().Exc<EXC0>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Inc<INC5>().Inc<INC6>().Inc<INC7>().Exc<EXC0>().Exc<EXC1>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1, EXC2> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1, EXC2> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Inc<INC5>().Inc<INC6>().Inc<INC7>().Exc<EXC0>().Exc<EXC1>().Exc<EXC2>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1, EXC2> v) { return Mask; }
        }
        #if ENABLE_IL2CPP
        [Il2CppSetOption(Option.NullChecks, false)]
        [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
        #endif
        internal readonly struct Exc<EXC0, EXC1, EXC2, EXC3> : EntLongQueryExtensions.IIncExc
        {
            public static readonly Exc<EXC0, EXC1, EXC2, EXC3> m = default;
            public static readonly EcsStaticMask Mask = EcsStaticMask.Inc<INC0>().Inc<INC1>().Inc<INC2>().Inc<INC3>().Inc<INC4>().Inc<INC5>().Inc<INC6>().Inc<INC7>().Exc<EXC0>().Exc<EXC1>().Exc<EXC2>().Exc<EXC3>().Build();
            EcsStaticMask EntLongQueryExtensions.IIncExc.Mask { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Mask; } }
            [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator EcsStaticMask(Exc<EXC0, EXC1, EXC2, EXC3> v) { return Mask; }
        }
    
    }

}