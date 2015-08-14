//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CppSharp
{
    namespace llvm
    {
        /// <summary>
        /// <para>This interface provides simple read-only access to a block of
        /// memory, and provides simple methods for reading files and standard input
        /// into a memory buffer. In addition to basic access to the characters in the
        /// file, this interface guarantees you can read one character past the end of
        /// the file, and that this character will read as '\0'.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// This interface provides simple read-only access to a block of
        /// memory, and</para>
        /// <para>/// provides simple methods for reading files and standard input
        /// into a memory</para>
        /// <para>/// buffer.  In addition to basic access to the characters in the
        /// file, this</para>
        /// <para>/// interface guarantees you can read one character past the end
        /// of the file,</para>
        /// <para>/// and that this character will read as '\0'.</para>
        /// <para>///</para>
        /// <para>/// The '\0' guarantee is needed to support an optimization --
        /// it's intended to</para>
        /// <para>/// be more efficient for clients which are reading all the data
        /// to stop</para>
        /// <para>/// reading when they encounter a '\0' than to continually check
        /// the file</para>
        /// <para>/// position to see if it has reached the end of the file.</para>
        /// </remarks>
        public unsafe abstract partial class MemoryBuffer : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 12)]
            public partial struct Internal
            {
                [FieldOffset(4)]
                public global::System.IntPtr BufferStart;

                [FieldOffset(8)]
                public global::System.IntPtr BufferEnd;

                [FieldOffset(0)]
                public global::System.IntPtr vfptr0;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm12MemoryBufferC2Ev")]
                internal static extern void ctor_1(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm12MemoryBufferD2Ev")]
                internal static extern void dtor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm12MemoryBuffer4initEPKcS2_b")]
                internal static extern void init_0(global::System.IntPtr instance, global::System.IntPtr BufStart, global::System.IntPtr BufEnd, bool RequiresNullTerminator);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm12MemoryBuffer14getBufferStartEv")]
                internal static extern global::System.IntPtr getBufferStart_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm12MemoryBuffer12getBufferEndEv")]
                internal static extern global::System.IntPtr getBufferEnd_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm12MemoryBuffer13getBufferSizeEv")]
                internal static extern uint getBufferSize_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm12MemoryBuffer9getBufferEv")]
                internal static extern llvm.StringRef.Internal getBuffer_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm12MemoryBuffer19getBufferIdentifierEv")]
                internal static extern global::System.IntPtr getBufferIdentifier_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm12MemoryBuffer15getMemBufferRefEv")]
                internal static extern void getMemBufferRef_0(global::System.IntPtr @return, global::System.IntPtr instance);
            }

            /// <summary>
            /// <para>The kind of memory backing used to support the
            /// MemoryBuffer.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// The kind of memory backing used to support the
            /// MemoryBuffer.</para>
            /// </remarks>
            public enum BufferKind : uint
            {
                MemoryBuffer_Malloc = 0,
                MemoryBuffer_MMap = 1
            }

            public global::System.IntPtr __Instance { get; protected set; }
            public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, MemoryBuffer> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, MemoryBuffer>();

            private readonly bool __ownsNativeInstance;

            public static MemoryBuffer __CreateInstance(global::System.IntPtr native)
            {
                return new MemoryBufferInternal((MemoryBuffer.Internal*) native);
            }

            public static MemoryBuffer __CreateInstance(MemoryBuffer.Internal native)
            {
                return new MemoryBufferInternal(native);
            }

            protected MemoryBuffer(MemoryBuffer.Internal* native, bool isInternalImpl = false)
            {
                __Instance = new global::System.IntPtr(native);
                if (__Instance != global::System.IntPtr.Zero && !isInternalImpl)
                    SetupVTables(__Instance);
            }

            protected MemoryBuffer()
            {
                __Instance = Marshal.AllocHGlobal(12);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                Internal.ctor_1(__Instance);
                SetupVTables(__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
            }

            protected virtual void Dispose(bool disposing)
            {
                DestroyNativeInstance(false);
            }

            public virtual void DestroyNativeInstance()
            {
                DestroyNativeInstance(true);
            }

            private void DestroyNativeInstance(bool force)
            {
                llvm.MemoryBuffer __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance || force)
                    Internal.dtor_0(__Instance);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            protected void init(string BufStart, string BufEnd, bool RequiresNullTerminator)
            {
                var arg0 = Marshal.StringToHGlobalAnsi(BufStart);
                var arg1 = Marshal.StringToHGlobalAnsi(BufEnd);
                Internal.init_0(__Instance, arg0, arg1, RequiresNullTerminator);
                Marshal.FreeHGlobal(arg0);
                Marshal.FreeHGlobal(arg1);
            }

            public string getBufferStart()
            {
                var __ret = Internal.getBufferStart_0(__Instance);
                return Marshal.PtrToStringAnsi(__ret);
            }

            public string getBufferEnd()
            {
                var __ret = Internal.getBufferEnd_0(__Instance);
                return Marshal.PtrToStringAnsi(__ret);
            }

            public uint getBufferSize()
            {
                var __ret = Internal.getBufferSize_0(__Instance);
                return __ret;
            }

            public llvm.StringRef getBuffer()
            {
                var __ret = Internal.getBuffer_0(__Instance);
                return llvm.StringRef.__CreateInstance(__ret);
            }

            /// <summary>
            /// <para>Return an identifier for this buffer, typically the filename it
            /// was read from.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// Return an identifier for this buffer, typically the filename
            /// it was read</para>
            /// <para>  /// from.</para>
            /// </remarks>
            public virtual string getBufferIdentifier()
            {
                var __ret = Internal.getBufferIdentifier_0(__Instance);
                return Marshal.PtrToStringAnsi(__ret);
            }

            /// <summary>
            /// <para>Return information on the memory mechanism used to support the
            /// MemoryBuffer.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// Return information on the memory mechanism used to support
            /// the</para>
            /// <para>  /// MemoryBuffer.</para>
            /// </remarks>
            public abstract llvm.MemoryBuffer.BufferKind getBufferKind();

            public llvm.MemoryBufferRef getMemBufferRef()
            {
                var __ret = new llvm.MemoryBufferRef.Internal();
                Internal.getMemBufferRef_0(new IntPtr(&__ret), __Instance);
                return llvm.MemoryBufferRef.__CreateInstance(__ret);
            }

            #region Virtual table interop

            // virtual ~MemoryBuffer()
            [SuppressUnmanagedCodeSecurity]
            [UnmanagedFunctionPointerAttribute(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
            internal delegate void _dtor_0Delegate(global::System.IntPtr instance);
            private static _dtor_0Delegate _dtor_0DelegateInstance;

            private static void _dtor_0DelegateHook(global::System.IntPtr instance)
            {
                if (!_References.ContainsKey(instance))
                    throw new global::System.Exception("No managed instance was found");

                var target = (MemoryBuffer) _References[instance].Target;
                target.DestroyNativeInstance();
            }

            // char *getBufferIdentifier() const
            [SuppressUnmanagedCodeSecurity]
            [UnmanagedFunctionPointerAttribute(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
            internal delegate global::System.IntPtr _getBufferIdentifier_0Delegate(global::System.IntPtr instance);
            private static _getBufferIdentifier_0Delegate _getBufferIdentifier_0DelegateInstance;

            private static global::System.IntPtr _getBufferIdentifier_0DelegateHook(global::System.IntPtr instance)
            {
                if (!_References.ContainsKey(instance))
                    throw new global::System.Exception("No managed instance was found");

                var target = (MemoryBuffer) _References[instance].Target;
                var __ret = target.getBufferIdentifier();
                return Marshal.StringToHGlobalAnsi(__ret);
            }

            // BufferKind getBufferKind() const = 0
            [SuppressUnmanagedCodeSecurity]
            [UnmanagedFunctionPointerAttribute(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
            internal delegate llvm.MemoryBuffer.BufferKind _getBufferKind_0Delegate(global::System.IntPtr instance);
            private static _getBufferKind_0Delegate _getBufferKind_0DelegateInstance;

            private static llvm.MemoryBuffer.BufferKind _getBufferKind_0DelegateHook(global::System.IntPtr instance)
            {
                if (!_References.ContainsKey(instance))
                    throw new global::System.Exception("No managed instance was found");

                var target = (MemoryBuffer) _References[instance].Target;
                var __ret = target.getBufferKind();
                return __ret;
            }

            private static void*[] _OldVTables;
            private static void*[] _NewVTables;
            private static void*[] _Thunks;
            private static System.Collections.Generic.Dictionary<IntPtr, WeakReference> _References;

            void SetupVTables(global::System.IntPtr instance)
            {
                var native = (Internal*)instance.ToPointer();

                if (_References == null)
                    _References = new System.Collections.Generic.Dictionary<IntPtr, WeakReference>();

                if (_References.ContainsKey(instance))
                    return;

                _References[instance] = new WeakReference(this);

                if (_OldVTables == null)
                {
                    _OldVTables = new void*[1];
                    _OldVTables[0] = native->vfptr0.ToPointer();
                }

                if (_Thunks == null)
                {
                    _Thunks = new void*[3];
                    _dtor_0DelegateInstance += _dtor_0DelegateHook;
                    _Thunks[0] = Marshal.GetFunctionPointerForDelegate(_dtor_0DelegateInstance).ToPointer();
                    _getBufferIdentifier_0DelegateInstance += _getBufferIdentifier_0DelegateHook;
                    _Thunks[1] = Marshal.GetFunctionPointerForDelegate(_getBufferIdentifier_0DelegateInstance).ToPointer();
                    _getBufferKind_0DelegateInstance += _getBufferKind_0DelegateHook;
                    _Thunks[2] = Marshal.GetFunctionPointerForDelegate(_getBufferKind_0DelegateInstance).ToPointer();
                }

                if (_NewVTables == null)
                {
                    _NewVTables = new void*[1];
                    var vfptr0 = Marshal.AllocHGlobal(3 * 4);
                    _NewVTables[0] = vfptr0.ToPointer();
                    *(void**)(vfptr0 + 4) = _Thunks[0];
                    *(void**)(vfptr0 + 8) = _Thunks[1];
                    *(void**)(vfptr0 + 12) = _Thunks[2];
                }

                native->vfptr0 = new IntPtr(_NewVTables[0]);
            }

            #endregion
        }

        public unsafe partial class MemoryBufferRef : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 16)]
            public partial struct Internal
            {
                [FieldOffset(0)]
                public llvm.StringRef.Internal Buffer;

                [FieldOffset(8)]
                public llvm.StringRef.Internal Identifier;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm15MemoryBufferRefC2Ev")]
                internal static extern void ctor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm15MemoryBufferRefC2ENS_9StringRefES1_")]
                internal static extern void ctor_1(global::System.IntPtr instance, llvm.StringRef.Internal Buffer, llvm.StringRef.Internal Identifier);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN4llvm15MemoryBufferRefC2ERKS0_")]
                internal static extern void cctor_2(global::System.IntPtr instance, global::System.IntPtr _0);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm15MemoryBufferRef9getBufferEv")]
                internal static extern llvm.StringRef.Internal getBuffer_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm15MemoryBufferRef19getBufferIdentifierEv")]
                internal static extern llvm.StringRef.Internal getBufferIdentifier_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm15MemoryBufferRef14getBufferStartEv")]
                internal static extern global::System.IntPtr getBufferStart_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm15MemoryBufferRef12getBufferEndEv")]
                internal static extern global::System.IntPtr getBufferEnd_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK4llvm15MemoryBufferRef13getBufferSizeEv")]
                internal static extern uint getBufferSize_0(global::System.IntPtr instance);
            }

            public global::System.IntPtr __Instance { get; protected set; }
            public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, MemoryBufferRef> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, MemoryBufferRef>();

            private readonly bool __ownsNativeInstance;

            public static MemoryBufferRef __CreateInstance(global::System.IntPtr native)
            {
                return new MemoryBufferRef((MemoryBufferRef.Internal*) native);
            }

            public static MemoryBufferRef __CreateInstance(MemoryBufferRef.Internal native)
            {
                return new MemoryBufferRef(native);
            }

            private static MemoryBufferRef.Internal* __CopyValue(MemoryBufferRef.Internal native)
            {
                var ret = (MemoryBufferRef.Internal*) Marshal.AllocHGlobal(16);
                *ret = native;
                return ret;
            }

            private MemoryBufferRef(MemoryBufferRef.Internal native)
                : this(__CopyValue(native))
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected MemoryBufferRef(MemoryBufferRef.Internal* native, bool isInternalImpl = false)
            {
                __Instance = new global::System.IntPtr(native);
            }

            public MemoryBufferRef()
            {
                __Instance = Marshal.AllocHGlobal(16);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                Internal.ctor_0(__Instance);
            }

            public MemoryBufferRef(llvm.StringRef Buffer, llvm.StringRef Identifier)
            {
                __Instance = Marshal.AllocHGlobal(16);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                var arg0 = ReferenceEquals(Buffer, null) ? new llvm.StringRef.Internal() : *(llvm.StringRef.Internal*) (Buffer.__Instance);
                var arg1 = ReferenceEquals(Identifier, null) ? new llvm.StringRef.Internal() : *(llvm.StringRef.Internal*) (Identifier.__Instance);
                Internal.ctor_1(__Instance, arg0, arg1);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
            }

            protected virtual void Dispose(bool disposing)
            {
                DestroyNativeInstance(false);
            }

            public virtual void DestroyNativeInstance()
            {
                DestroyNativeInstance(true);
            }

            private void DestroyNativeInstance(bool force)
            {
                llvm.MemoryBufferRef __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            public llvm.StringRef getBuffer()
            {
                var __ret = Internal.getBuffer_0(__Instance);
                return llvm.StringRef.__CreateInstance(__ret);
            }

            public llvm.StringRef getBufferIdentifier()
            {
                var __ret = Internal.getBufferIdentifier_0(__Instance);
                return llvm.StringRef.__CreateInstance(__ret);
            }

            public string getBufferStart()
            {
                var __ret = Internal.getBufferStart_0(__Instance);
                return Marshal.PtrToStringAnsi(__ret);
            }

            public string getBufferEnd()
            {
                var __ret = Internal.getBufferEnd_0(__Instance);
                return Marshal.PtrToStringAnsi(__ret);
            }

            public uint getBufferSize()
            {
                var __ret = Internal.getBufferSize_0(__Instance);
                return __ret;
            }
        }

        internal unsafe partial class MemoryBufferInternal : llvm.MemoryBuffer, IDisposable
        {
            private readonly bool __ownsNativeInstance;

            private static MemoryBuffer.Internal* __CopyValue(MemoryBuffer.Internal native)
            {
                var ret = (MemoryBuffer.Internal*) Marshal.AllocHGlobal(12);
                *ret = native;
                return ret;
            }

            internal MemoryBufferInternal(MemoryBuffer.Internal native)
                : this(__CopyValue(native))
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            internal MemoryBufferInternal(MemoryBuffer.Internal* native, bool isInternalImpl = false)
                : base((llvm.MemoryBuffer.Internal*) native, true)
            {
            }

            protected override void Dispose(bool disposing)
            {
                DestroyNativeInstance(false);
                base.Dispose(disposing);
            }

            public override void DestroyNativeInstance()
            {
                DestroyNativeInstance(true);
            }

            private void DestroyNativeInstance(bool force)
            {
                llvm.MemoryBuffer __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            /// <summary>
            /// <para>Return information on the memory mechanism used to support the
            /// MemoryBuffer.</para>
            /// </summary>
            /// <remarks>
            /// <para>/// Return information on the memory mechanism used to support
            /// the</para>
            /// <para>  /// MemoryBuffer.</para>
            /// </remarks>
            public override llvm.MemoryBuffer.BufferKind getBufferKind()
            {
                void* slot = *(void**) (((MemoryBuffer.Internal*) __Instance)->vfptr0 + 3 * 4);
                var ___getBufferKind_0Delegate = (_getBufferKind_0Delegate) Marshal.GetDelegateForFunctionPointer(new IntPtr(slot), typeof(_getBufferKind_0Delegate));
                var __ret = ___getBufferKind_0Delegate(__Instance);
                return __ret;
            }
        }
    }
}
