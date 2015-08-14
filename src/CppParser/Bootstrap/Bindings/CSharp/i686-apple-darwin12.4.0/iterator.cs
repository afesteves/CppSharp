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
        /// <para>CRTP base class for adapting an iterator to a different
        /// type.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// \brief CRTP base class for adapting an iterator to a
        /// different type.</para>
        /// <para>///</para>
        /// <para>/// This class can be used through CRTP to adapt one iterator
        /// into another.</para>
        /// <para>/// Typically this is done through providing in the derived class
        /// a custom \c</para>
        /// <para>/// operator* implementation. Other methods can be overridden as
        /// well.</para>
        /// </remarks>
        public unsafe partial class iterator_adaptor_base
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct Internal
            {
            }
        }

        /// <summary>
        /// <para>CRTP base class which implements the entire standard iterator
        /// facade in terms of a minimal subset of the interface.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// \brief CRTP base class which implements the entire standard
        /// iterator facade</para>
        /// <para>/// in terms of a minimal subset of the interface.</para>
        /// <para>///</para>
        /// <para>/// Use this when it is reasonable to implement most of the
        /// iterator</para>
        /// <para>/// functionality in terms of a core subset. If you need special
        /// behavior or</para>
        /// <para>/// there are performance implications for this, you may want to
        /// override the</para>
        /// <para>/// relevant members instead.</para>
        /// <para>///</para>
        /// <para>/// Note, one abstraction that this does *not* provide is
        /// implementing</para>
        /// <para>/// subtraction in terms of addition by negating the difference.
        /// Negation isn't</para>
        /// <para>/// always information preserving, and I can see very reasonable
        /// iterator</para>
        /// <para>/// designs where this doesn't work well. It doesn't really force
        /// much added</para>
        /// <para>/// boilerplate anyways.</para>
        /// <para>///</para>
        /// <para>/// Another abstraction that this doesn't provide is implementing
        /// increment in</para>
        /// <para>/// terms of addition of one. These aren't equivalent for all
        /// iterator</para>
        /// <para>/// categories, and respecting that adds a lot of complexity for
        /// little gain.</para>
        /// </remarks>
        public unsafe static partial class iterator_facade_base
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct Internal
            {
            }
        }

        /// <summary>
        /// <para>An iterator type that allows iterating over the pointees via some
        /// other iterator.</para>
        /// </summary>
        /// <remarks>
        /// <para>/// \brief An iterator type that allows iterating over the
        /// pointees via some</para>
        /// <para>/// other iterator.</para>
        /// <para>///</para>
        /// <para>/// The typical usage of this is to expose a type that iterates
        /// over Ts, but</para>
        /// <para>/// which is implemented with some iterator over T*s:</para>
        /// <para>///</para>
        /// <para>/// \code</para>
        /// <para>///   typedef pointee_iterator&lt;SmallVectorImpl&lt;T
        /// *&gt;::iterator&gt; iterator;</para>
        /// <para>/// \endcode</para>
        /// </remarks>
        public unsafe partial class pointee_iterator
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct Internal
            {
            }
        }
    }
}
