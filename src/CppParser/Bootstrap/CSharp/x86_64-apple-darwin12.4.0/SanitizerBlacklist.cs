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
        public unsafe partial class SanitizerBlacklist : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 16)]
            public partial struct Internal
            {
                [FieldOffset(8)]
                public global::System.IntPtr SM;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN5clang18SanitizerBlacklistC2ERKS0_")]
                internal static extern void cctor_2(global::System.IntPtr instance, global::System.IntPtr _0);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN5clang18SanitizerBlacklistD2Ev")]
                internal static extern void dtor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang18SanitizerBlacklist19isBlacklistedGlobalEN4llvm9StringRefES2_")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool isBlacklistedGlobal_0(global::System.IntPtr instance, llvm.StringRef.Internal GlobalName, llvm.StringRef.Internal Category);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang18SanitizerBlacklist17isBlacklistedTypeEN4llvm9StringRefES2_")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool isBlacklistedType_0(global::System.IntPtr instance, llvm.StringRef.Internal MangledTypeName, llvm.StringRef.Internal Category);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang18SanitizerBlacklist21isBlacklistedFunctionEN4llvm9StringRefE")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool isBlacklistedFunction_0(global::System.IntPtr instance, llvm.StringRef.Internal FunctionName);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang18SanitizerBlacklist17isBlacklistedFileEN4llvm9StringRefES2_")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool isBlacklistedFile_0(global::System.IntPtr instance, llvm.StringRef.Internal FileName, llvm.StringRef.Internal Category);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNK5clang18SanitizerBlacklist21isBlacklistedLocationENS_14SourceLocationEN4llvm9StringRefE")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                internal static extern bool isBlacklistedLocation_0(global::System.IntPtr instance, clang.SourceLocation.Internal Loc, llvm.StringRef.Internal Category);
            }

            public global::System.IntPtr __Instance { get; protected set; }
            public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, SanitizerBlacklist> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, SanitizerBlacklist>();

            private readonly bool __ownsNativeInstance;

            public static SanitizerBlacklist __CreateInstance(global::System.IntPtr native)
            {
                return new SanitizerBlacklist((SanitizerBlacklist.Internal*) native);
            }

            public static SanitizerBlacklist __CreateInstance(SanitizerBlacklist.Internal native)
            {
                return new SanitizerBlacklist(native);
            }

            private static SanitizerBlacklist.Internal* __CopyValue(SanitizerBlacklist.Internal native)
            {
                var ret = (SanitizerBlacklist.Internal*) Marshal.AllocHGlobal(16);
                *ret = native;
                return ret;
            }

            private SanitizerBlacklist(SanitizerBlacklist.Internal native)
                : this(__CopyValue(native))
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected SanitizerBlacklist(SanitizerBlacklist.Internal* native, bool isInternalImpl = false)
            {
                __Instance = new global::System.IntPtr(native);
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
                clang.SanitizerBlacklist __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance || force)
                    Internal.dtor_0(__Instance);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            public bool isBlacklistedGlobal(llvm.StringRef GlobalName, llvm.StringRef Category)
            {
                var arg0 = ReferenceEquals(GlobalName, null) ? new llvm.StringRef.Internal() : *(llvm.StringRef.Internal*) (GlobalName.__Instance);
                var arg1 = ReferenceEquals(Category, null) ? new llvm.StringRef.Internal() : *(llvm.StringRef.Internal*) (Category.__Instance);
                var __ret = Internal.isBlacklistedGlobal_0(__Instance, arg0, arg1);
                return __ret;
            }

            public bool isBlacklistedType(llvm.StringRef MangledTypeName, llvm.StringRef Category)
            {
                var arg0 = ReferenceEquals(MangledTypeName, null) ? new llvm.StringRef.Internal() : *(llvm.StringRef.Internal*) (MangledTypeName.__Instance);
                var arg1 = ReferenceEquals(Category, null) ? new llvm.StringRef.Internal() : *(llvm.StringRef.Internal*) (Category.__Instance);
                var __ret = Internal.isBlacklistedType_0(__Instance, arg0, arg1);
                return __ret;
            }

            public bool isBlacklistedFunction(llvm.StringRef FunctionName)
            {
                var arg0 = ReferenceEquals(FunctionName, null) ? new llvm.StringRef.Internal() : *(llvm.StringRef.Internal*) (FunctionName.__Instance);
                var __ret = Internal.isBlacklistedFunction_0(__Instance, arg0);
                return __ret;
            }

            public bool isBlacklistedFile(llvm.StringRef FileName, llvm.StringRef Category)
            {
                var arg0 = ReferenceEquals(FileName, null) ? new llvm.StringRef.Internal() : *(llvm.StringRef.Internal*) (FileName.__Instance);
                var arg1 = ReferenceEquals(Category, null) ? new llvm.StringRef.Internal() : *(llvm.StringRef.Internal*) (Category.__Instance);
                var __ret = Internal.isBlacklistedFile_0(__Instance, arg0, arg1);
                return __ret;
            }

            public bool isBlacklistedLocation(clang.SourceLocation Loc, llvm.StringRef Category)
            {
                var arg0 = ReferenceEquals(Loc, null) ? new clang.SourceLocation.Internal() : *(clang.SourceLocation.Internal*) (Loc.__Instance);
                var arg1 = ReferenceEquals(Category, null) ? new llvm.StringRef.Internal() : *(llvm.StringRef.Internal*) (Category.__Instance);
                var __ret = Internal.isBlacklistedLocation_0(__Instance, arg0, arg1);
                return __ret;
            }
        }
    }
}