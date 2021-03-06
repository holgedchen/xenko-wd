// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using System;

namespace Xenko.Core.IO
{
    /// <summary>
    /// File access equivalent of <see cref="System.IO.FileAccess"/>.
    /// </summary>
    [Flags]
    public enum VirtualFileAccess : uint
    {
        /// <summary>
        /// Read access.
        /// </summary>
        Read = 1,

        /// <summary>
        /// Write access.
        /// </summary>
        Write = 2,

        /// <summary>
        /// Read/Write Access,
        /// </summary>
        ReadWrite = Read | Write,
    }
}
