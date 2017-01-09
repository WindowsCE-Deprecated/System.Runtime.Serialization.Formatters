// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*============================================================
**
** Interface: ISerializable
**
**
** Purpose: Implemented by any object that needs to control its
**          own serialization.
**
**
===========================================================*/
namespace System.Runtime.Serialization
{
    /// <summary>
    /// Allows an object to control its own serialization and deserialization.
    /// </summary>
    public interface ISerializable
    {
        /// <summary>
        /// Populates a <see cref="SerializationInfo" /> with the data needed to serialize the target object.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo" /> to populate with data. </param>
        /// <param name="context">The destination (see <see cref="StreamingContext" />) for this serialization.</param>
        /// <exception cref="Security.SecurityException">The caller does not have the required permission.</exception>
        void GetObjectData(SerializationInfo info, StreamingContext context);
    }
}
