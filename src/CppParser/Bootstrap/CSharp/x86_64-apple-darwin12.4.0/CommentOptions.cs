//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CppSharp
{
    namespace clang
    {
        /// <summary>
        /// <para>Options for controlling comment parsing.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// \brief Options for controlling comment parsing.</para>
        /// </remarks>
        public unsafe partial class CommentOptions : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 32)]
            public partial struct Internal
            {
                [FieldOffset(24)]
                public bool ParseAllComments;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN5clang14CommentOptionsC2Ev")]
                internal static extern void ctor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN5clang14CommentOptionsC2ERKS0_")]
                internal static extern void cctor_2(global::System.IntPtr instance, global::System.IntPtr _0);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN5clang14CommentOptionsD2Ev")]
                internal static extern void dtor_0(global::System.IntPtr instance);
            }

            public global::System.IntPtr __Instance { get; protected set; }
            public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, CommentOptions> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, CommentOptions>();

            private readonly bool __ownsNativeInstance;

            public static CommentOptions __CreateInstance(global::System.IntPtr native)
            {
                return new CommentOptions((CommentOptions.Internal*) native);
            }

            public static CommentOptions __CreateInstance(CommentOptions.Internal native)
            {
                return new CommentOptions(native);
            }

            private static CommentOptions.Internal* __CopyValue(CommentOptions.Internal native)
            {
                var ret = (CommentOptions.Internal*) Marshal.AllocHGlobal(32);
                *ret = native;
                return ret;
            }

            private CommentOptions(CommentOptions.Internal native)
                : this(__CopyValue(native))
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected CommentOptions(CommentOptions.Internal* native, bool isInternalImpl = false)
            {
                __Instance = new global::System.IntPtr(native);
            }

            public CommentOptions()
            {
                __Instance = Marshal.AllocHGlobal(32);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                Internal.ctor_0(__Instance);
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
                clang.CommentOptions __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance || force)
                    Internal.dtor_0(__Instance);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            public bool ParseAllComments
            {
                get
                {
                    return ((Internal*) __Instance)->ParseAllComments;
                }

                set
                {
                    ((Internal*) __Instance)->ParseAllComments = value;
                }
            }
        }
    }
}